using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using psiconexao.Models;
using System.Security.Claims;

namespace psiconexao.Controllers
{
    public class AuthController : Controller
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastro(Usuario usuario, string confirmarEmail, string confirmarSenha)
        {
            var usuarioExistente = await _context.Usuarios.AnyAsync(u => u.Email == usuario.Email);
            Console.WriteLine(usuarioExistente);

            if (usuarioExistente)
            {
                ModelState.AddModelError(string.Empty, "E-mail já cadastrado");
                return View(usuario);
            }
            else
            {
                if (usuario.Email != confirmarEmail || usuario.Password != confirmarSenha)
                {
                    ModelState.AddModelError(string.Empty, "E-mail ou senha não correspondem.");
                    return View(usuario);
                }

                if (ModelState.IsValid)
                {
                    if (usuario.Perfil == Perfil.Paciente)
                    {
                        var paciente = new Paciente
                        {
                            Nome = usuario.Nome,
                            Email = usuario.Email,
                            Telefone = usuario.Telefone,
                            Password = usuario.Password,
                            Perfil = usuario.Perfil,
                            Cpf = "xxx.xxx.xxx-xx",
                            Trauma = "Nenhum trauma foi adicionado.",
                            HistoricoConsulta = "Nenhum histórico foi adicionado."
                        }; 

                        _context.Pacientes.Add(paciente);
                        await _context.SaveChangesAsync();
                        return RedirectToAction("Agenda");

                    }
                    else if (usuario.Perfil == Perfil.Psicologo)
                    {
                        var psicologo = new Psicologo
                        {
                            Nome = usuario.Nome,
                            Email = usuario.Email,
                            Telefone = usuario.Telefone,
                            Password = usuario.Password,
                            Perfil = usuario.Perfil,
                            Crp = "xx/xxxxx",
                            UrlFoto = "https://i.pinimg.com/736x/21/9e/ae/219eaea67aafa864db091919ce3f5d82.jpg",
                            Biografia = "Nenhuma biografia foi adicionada.",
                            PrecoConsulta = 30,
                            TEspecialidade = Psicologo.TipoEspecialidade.Clínica,
                            TAbordagem = Psicologo.TipoAbordagem.CognitivoComportamental
                        };

                        _context.Psicologos.Add(psicologo);
                        await _context.SaveChangesAsync();

                        return RedirectToAction("CadastroEmAnalise");
                    }
                }
                return View(usuario);
            }
        }

        public IActionResult CadastroEmAnalise()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var usuario = await _context.Usuarios.SingleOrDefaultAsync(u => u.Email == email && u.Password == password);

            if (usuario != null)
            {
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, usuario.Nome),
                        new Claim(ClaimTypes.NameIdentifier, usuario.UsuarioId.ToString()),
                        new Claim(ClaimTypes.Role, usuario.Perfil.ToString())
                    };

                var usuarioIdentity = new ClaimsIdentity(claims, "cadastro");
                ClaimsPrincipal principal = new ClaimsPrincipal(usuarioIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true,
                };

                await HttpContext.SignInAsync(principal, props);

                if (usuario.Perfil == Perfil.Psicologo)
                {
                    return RedirectToAction("Editar", "Psicologo", new { id = usuario.UsuarioId });
                }
                else if (usuario.Perfil == Perfil.Paciente)
                {
                    return RedirectToAction("Agenda", "Paciente", new { id = usuario.UsuarioId });
                }
            }

            ModelState.AddModelError(string.Empty, "E-mail ou senha inválidos.");
            return View();
        }

        public IActionResult EsqueceuSenha()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EsqueceuSenha(string email)
        {
            var usuario = await _context.Usuarios.SingleOrDefaultAsync(u => u.Email == email);

            if (usuario != null)
            {
                return RedirectToAction("RedefinirSenha");
            }

            ModelState.AddModelError(string.Empty, "E-mail não cadastrado.");
            return View();
        }

        public IActionResult RedefinirSenha()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RedefinirSenha(string email, string novaSenha, string confirmarSenha)
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == email);

            if (usuario == null)
            {
                ModelState.AddModelError(string.Empty, "Usuário não encontrado.");
                return View();
            }

            if (novaSenha != confirmarSenha)
            {
                ModelState.AddModelError(string.Empty, "Senhas não correspondem.");
                return View();
            }

            if (ModelState.IsValid)
            {
                usuario.Password = novaSenha; 
                _context.Usuarios.Update(usuario);
                await _context.SaveChangesAsync();

                return RedirectToAction("Login");
            }

            return View();
        }

        public async Task<IActionResult> Sair()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

        public IActionResult AcessoNegado()
        {
            return View();
        }
    }
}
