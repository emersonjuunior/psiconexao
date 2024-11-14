using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using psiconexao.Models;
using System.Linq;

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

        [AllowAnonymous]
        public async Task<IActionResult> Lista(string nome, string abordagem, string especialidade, string crp, float? precoMin,float? precoMax, DateTime? dataDisponivel, TimeSpan? horaDisponivel)
        {
            var psicologos = await _context.Psicologos.ToListAsync();

            if (psicologos == null || !psicologos.Any())
            {
                return NotFound("Nenhum psicólogo encontrado.");
            }

            var consulta = _context.Psicologos.AsQueryable();

            if (!string.IsNullOrEmpty(nome))
            {
                consulta = consulta.Where(p => p.Nome.Contains(nome));
                ViewBag.Nome = nome;
            }

            if (!string.IsNullOrEmpty(crp))
            {
                consulta = consulta.Where(p => p.Crp.Contains(crp));
                ViewBag.Crp = crp;
            }

            if (!string.IsNullOrEmpty(especialidade))
            {
                Psicologo.TipoEspecialidade valorEspecialidade = (Psicologo.TipoEspecialidade)Enum.Parse(typeof(Psicologo.TipoEspecialidade), especialidade);
                consulta = consulta.Where(p => p.TEspecialidade.Equals(valorEspecialidade));
                ViewBag.Especialidade = especialidade;
            }

            Console.WriteLine(abordagem);

            if (!string.IsNullOrEmpty(abordagem))
            {
                Psicologo.TipoAbordagem valorAbordagem = (Psicologo.TipoAbordagem)Enum.Parse(typeof(Psicologo.TipoAbordagem), abordagem);
                consulta = consulta.Where(p => p.TAbordagem.Equals(valorAbordagem));
                ViewBag.Abordagem = abordagem;
            }

            if (precoMin.HasValue)
            {
                consulta = consulta.Where(p => p.PrecoConsulta >= precoMin.Value);
                ViewBag.PrecoMin = precoMin;
            }

            if (precoMax.HasValue)
            {
                consulta = consulta.Where(p => p.PrecoConsulta <= precoMax.Value);
                ViewBag.PrecoMax = precoMax;
            }

            if (dataDisponivel.HasValue)
            {
                consulta = consulta.Where(p => p.Disponibilidades.Any(d =>
                    d.DataInicio <= dataDisponivel && d.DataFim >= dataDisponivel));
                ViewBag.DataDisponivel = dataDisponivel.Value.ToString("yyyy-MM-dd");
            }

            if (horaDisponivel.HasValue)
            {
                consulta = consulta.Where(p => p.Disponibilidades.Any(d =>
                    d.HoraInicio <= horaDisponivel && d.HoraFim >= horaDisponivel));
                ViewBag.HoraDisponivel = horaDisponivel.Value.ToString(@"hh\:mm");
            }

            Console.WriteLine(consulta.ToString());
            Console.WriteLine(consulta.Where(p => p.TAbordagem.ToString() == abordagem));

            return View(await consulta.ToListAsync());
        }
    }
}
