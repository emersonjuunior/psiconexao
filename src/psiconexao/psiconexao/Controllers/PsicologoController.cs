using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using psiconexao.Models;

namespace psiconexao.Controllers
{
    [Authorize(Roles = "Psicologo")]
    public class PsicologoController : Controller
    {
        private readonly AppDbContext _context;

        public PsicologoController(AppDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Perfil(int id)
        {
            var psicologo = await _context.Psicologos
                .SingleOrDefaultAsync(p => p.UsuarioId == id);

            if (psicologo == null)
            {
                return NotFound();
            }

            return View(psicologo);
        }

        public async Task<IActionResult> Editar(int id)
        {
            var psicologo = await _context.Psicologos
                .SingleOrDefaultAsync(p => p.UsuarioId == id);

            if (psicologo == null)
            {
                return NotFound();
            }

            return View(psicologo);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Psicologo psicologo)
        {
            var psicologoP = await _context.Psicologos
                .SingleOrDefaultAsync(p => p.UsuarioId == psicologo.UsuarioId);

            if (psicologoP == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                psicologoP.Nome = psicologo.Nome;
                psicologoP.UrlFoto = psicologo.UrlFoto;
                psicologoP.Email = psicologo.Email;
                psicologoP.Telefone = psicologo.Telefone;
                psicologoP.Crp = psicologo.Crp;
                psicologoP.PrecoConsulta = psicologo.PrecoConsulta;
                psicologoP.TEspecialidade = psicologo.TEspecialidade;
                psicologoP.TAbordagem = psicologo.TAbordagem;
                psicologoP.Biografia = psicologo.Biografia;

                await _context.SaveChangesAsync();
                return RedirectToAction("Perfil", "Psicologo", new { id = psicologo.UsuarioId });
            }
            else if (!ModelState.IsValid)
            {
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        Console.WriteLine(error.ErrorMessage);
                    }
                }

                return View(psicologo);
            }

            return View(psicologo);
        }
    }
}
