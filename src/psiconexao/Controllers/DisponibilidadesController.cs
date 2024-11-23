using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using psiconexao.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace psiconexao.Controllers
{
    public class DisponibilidadesController : Controller
    {
        private readonly AppDbContext _context;

        public DisponibilidadesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Disponibilidades
        [Authorize(Roles = "Psicologo")]
        public async Task<IActionResult> Index()
        {
            var usuarioIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);

            IQueryable<Disponibilidade> disponibilidadesQuery = _context.Disponibilidades.Include(d => d.Psicologo);

            if (usuarioIdClaim != null)
            {
                int usuarioId = int.Parse(usuarioIdClaim);
                disponibilidadesQuery = disponibilidadesQuery.Where(d => d.PsicologoId == usuarioId);
            }

            // retorna a view com as disponibilidades filtradas
            return View(await disponibilidadesQuery.ToListAsync());
        }

        // GET: Disponibilidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disponibilidade = await _context.Disponibilidades
                .Include(d => d.Psicologo)
                .FirstOrDefaultAsync(m => m.DisponibilidadeId == id);
            if (disponibilidade == null)
            {
                return NotFound();
            }

            return View(disponibilidade);
        }

        // GET: Disponibilidades/Create
        public IActionResult Create()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewData["PsicologoId"] = userId;
            return View();
        }

        // POST: Disponibilidades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DisponibilidadeId,DataInicio,DataFim,HoraInicio,HoraFim,Estado,PsicologoId")] Disponibilidade disponibilidade)
        {
            if (ModelState.IsValid)
            {
                _context.Add(disponibilidade);
                await _context.SaveChangesAsync();
                return RedirectToAction("Perfil", "Psicologo", new { id = disponibilidade.PsicologoId });
            }
            ViewData["PsicologoId"] = new SelectList(_context.Psicologos, "UsuarioId", "Nome", disponibilidade.PsicologoId);
            return View(disponibilidade);
        }

        // GET: Disponibilidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disponibilidade = await _context.Disponibilidades.FindAsync(id);
            if (disponibilidade == null)
            {
                return NotFound();
            }
            ViewData["PsicologoId"] = new SelectList(_context.Psicologos, "UsuarioId", "Nome", disponibilidade.PsicologoId);
            return View(disponibilidade);
        }

        // POST: Disponibilidades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DisponibilidadeId,DataInicio,DataFim,HoraInicio,HoraFim,Estado,PsicologoId")] Disponibilidade disponibilidade)
        {
            if (id != disponibilidade.DisponibilidadeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(disponibilidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DisponibilidadeExists(disponibilidade.DisponibilidadeId))
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
            ViewData["PsicologoId"] = new SelectList(_context.Psicologos, "UsuarioId", "Nome", disponibilidade.PsicologoId);
            return View(disponibilidade);
        }

        // GET: Disponibilidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disponibilidade = await _context.Disponibilidades
                .Include(d => d.Psicologo)
                .FirstOrDefaultAsync(m => m.DisponibilidadeId == id);
            if (disponibilidade == null)
            {
                return NotFound();
            }

            return View(disponibilidade);
        }

        // POST: Disponibilidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var disponibilidade = await _context.Disponibilidades.FindAsync(id);
            if (disponibilidade != null)
            {
                _context.Disponibilidades.Remove(disponibilidade);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //Para obter as disponibilidades
        public JsonResult GetDisponibilidades(int psicologoId)
        {
            var disponibilidades = _context.Disponibilidades
                .Where(d => d.PsicologoId == psicologoId)
                .Select(d => new {
                    title = d.Estado ? "Disponível" : "Indisponível",
                    start = d.DataInicio.ToString("yyyy-MM-dd") + "T" + d.HoraInicio.ToString(@"hh\:mm\:ss"),
                    end = d.DataFim.ToString("yyyy-MM-dd") + "T" + d.HoraFim.ToString(@"hh\:mm\:ss"),
                    backgroundColor = d.Estado ? "rgb(100 231 153)" : "rgb(229 229 229)"
                }).ToList();

            return new JsonResult(disponibilidades);
        }

        public JsonResult GetConsultasParaData(int psicologoId, DateTime data)
        {
            var consultas = _context.Consultas
                .Where(c => c.PsicologoId == psicologoId && c.Data == data)
                .Select(c => new
                {
                    HoraInicio = c.Hora,
                    HoraFim = c.Hora.Add(new TimeSpan(0, 59, 0)) // Cada consulta dura 59 minutos
                })
                .ToList();

            return new JsonResult(consultas);
        }
        private bool DisponibilidadeExists(int id)
        {
            return _context.Disponibilidades.Any(e => e.DisponibilidadeId == id);
        }
    }
}
