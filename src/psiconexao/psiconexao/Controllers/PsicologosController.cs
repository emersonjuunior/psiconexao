using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using psiconexao.Models;

namespace psiconexao.Controllers
{
    public class PsicologosController : Controller
    {
        private readonly AppDbContext _context;

        public PsicologosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Psicologos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Psicologos.ToListAsync());
        }

        // GET: Psicologos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var psicologo = await _context.Psicologos
                .FirstOrDefaultAsync(m => m.UsuarioId == id);
            if (psicologo == null)
            {
                return NotFound();
            }

            return View(psicologo);
        }

        // GET: Psicologos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Psicologos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("crp,UrlFoto,Biografia,PrecoConsulta,TEspecialidade,TAbordagem,UsuarioId,Nome,Email,Telefone,Password")] Psicologo psicologo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(psicologo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(psicologo);
        }

        // GET: Psicologos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var psicologo = await _context.Psicologos.FindAsync(id);
            if (psicologo == null)
            {
                return NotFound();
            }
            return View(psicologo);
        }

        // POST: Psicologos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("crp,UrlFoto,Biografia,PrecoConsulta,TEspecialidade,TAbordagem,UsuarioId,Nome,Email,Telefone,Password")] Psicologo psicologo)
        {
            if (id != psicologo.UsuarioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(psicologo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PsicologoExists(psicologo.UsuarioId))
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
            return View(psicologo);
        }

        // GET: Psicologos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var psicologo = await _context.Psicologos
                .FirstOrDefaultAsync(m => m.UsuarioId == id);
            if (psicologo == null)
            {
                return NotFound();
            }

            return View(psicologo);
        }

        // POST: Psicologos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var psicologo = await _context.Psicologos.FindAsync(id);
            if (psicologo != null)
            {
                _context.Psicologos.Remove(psicologo);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PsicologoExists(int id)
        {
            return _context.Psicologos.Any(e => e.UsuarioId == id);
        }
    }
}
