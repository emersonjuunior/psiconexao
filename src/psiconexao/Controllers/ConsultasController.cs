﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using psiconexao.Models;
using psiconexao.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace psiconexao.Controllers
{
    public class ConsultasController : Controller
    {
        private readonly AppDbContext _context;
        private readonly EmailService _emailService;
        public ConsultasController(AppDbContext context, EmailService emailService)
        {
            _context = context;
            _emailService = emailService;

        }

        // GET: Consultas
        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appDbContext = _context.Consultas
                .Include(c => c.Paciente)
                .Include(c => c.Psicologo)
                .Where(c => c.PacienteId == id.Value || c.PsicologoId == id.Value);

            return View(await appDbContext.ToListAsync());
        }

        // GET: Consultas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas
                .Include(c => c.Paciente)
                .Include(c => c.Psicologo)
                .FirstOrDefaultAsync(m => m.ConsultaId == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // GET: Consultas/Create
        public IActionResult Create(int psicologoId, string data)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // Obter o ID do usuário logado
            if (!int.TryParse(userId, out int pacienteId))
            {
                TempData["ErrorMessage"] = "Apenas usuários logados podem agendar consulta!";

                return RedirectToAction("Perfil", "Psicologo", new { id = psicologoId });
            }

            if(User.IsInRole(Perfil.Psicologo.ToString()))
            {
                TempData["ErrorMessage"] = "Apenas pacientes podem agendar consulta!";

                return RedirectToAction("Perfil", "Psicologo", new { id = psicologoId });
            }

            var paciente = _context.Pacientes.FirstOrDefault(p => p.UsuarioId == pacienteId);

            if (paciente == null)
            {
                return NotFound("Paciente não encontrado.");
            }
           
            var consulta = new Consulta
            {
                PsicologoId = psicologoId,
                Data = DateTime.Parse(data),
                PacienteId = paciente.UsuarioId,
                Estado = Estado.Pendente
            };

            ViewData["PacienteId"] = new SelectList(_context.Pacientes, "UsuarioId", "Nome");
            ViewData["PsicologoId"] = new SelectList(_context.Psicologos, "UsuarioId", "Nome");
            return View(consulta);
        }

        // POST: Consultas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ConsultaId,Data,Hora,PsicologoId,PacienteId,Estado")] Consulta consulta)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (ModelState.IsValid)
            {
                _context.Add(consulta);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { id = userId });
            }
            ViewData["PacienteId"] = new SelectList(_context.Pacientes, "UsuarioId", "Email", consulta.PacienteId);
            ViewData["PsicologoId"] = new SelectList(_context.Psicologos, "UsuarioId", "Email", consulta.PsicologoId);
            return View(consulta);
        }

        // GET: Consultas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas.FindAsync(id);
            if (consulta == null)
            {
                return NotFound();
            }
            ViewData["PacienteId"] = new SelectList(_context.Pacientes, "UsuarioId", "Email", consulta.PacienteId);
            ViewData["PsicologoId"] = new SelectList(_context.Psicologos, "UsuarioId", "Email", consulta.PsicologoId);
            return View(consulta);
        }

        // POST: Consultas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ConsultaId,Data,Hora,PsicologoId,PacienteId,Estado")] Consulta consulta)
        {
            if (id != consulta.ConsultaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consulta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsultaExists(consulta.ConsultaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PacienteId"] = new SelectList(_context.Pacientes, "UsuarioId", "Email", consulta.PacienteId);
            ViewData["PsicologoId"] = new SelectList(_context.Psicologos, "UsuarioId", "Email", consulta.PsicologoId);
            return View(consulta);
        }

        // GET: Consultas/Delete/5
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas
                .Include(c => c.Paciente)
                .Include(c => c.Psicologo)
                .FirstOrDefaultAsync(m => m.ConsultaId == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // POST: Consultas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var consulta = await _context.Consultas.FindAsync(id);
            if (consulta != null)
            {
                _context.Consultas.Remove(consulta);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { id = userId });
        }              

        //GET: Consultas/Pendentes
        public async Task<IActionResult> Pendentes()
        {
            var consultasPendentes = _context.Consultas
                    .Include(c => c.Psicologo)
                    .Include(c => c.Paciente)
                    .Where(c => c.Estado == Estado.Pendente);
            return View(await consultasPendentes.ToListAsync());
        }

        // GET: Consultas/Agendadas
        public async Task<IActionResult> Agendadas()
        {
            var consultasAgendadas = _context.Consultas
                .Include(c => c.Psicologo)
                .Include(c => c.Paciente)
                .Where(c => c.Estado == Estado.Agendada);
            return View(await consultasAgendadas.ToListAsync());
        }

        // Método para confirmar uma consulta
        public async Task<IActionResult> Confirmar(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var consulta = await _context.Consultas.FindAsync(id);
            if (consulta == null)
            {
                return NotFound();
            }

            consulta.Estado = Estado.Agendada;
            _context.Update(consulta);
            await _context.SaveChangesAsync();

            // Enviar o e-mail de confirmação
            var paciente = await _context.Pacientes.FindAsync(consulta.PacienteId);
            await _emailService.SendEmailAsync(
                paciente.Email,
                "Confirmação de Consulta",
                $"Olá {paciente.Nome}, sua consulta foi confirmada para {consulta.Data.ToString("dd/MM/yyyy")} às {consulta.Hora}."
            );

            return RedirectToAction("Index", new { id = userId });
        }

        // Método para rejeitar uma consulta
        public async Task<IActionResult> Rejeitar(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var consulta = await _context.Consultas.FindAsync(id);
            if (consulta == null)
            {
                return NotFound();
            }

            _context.Consultas.Remove(consulta);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index", new { id = userId });
        }
        private bool ConsultaExists(int id)
        {
            return _context.Consultas.Any(e => e.ConsultaId == id);
        }
    }       
}
