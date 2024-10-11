using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using psiconexao.Models;

namespace psiconexao.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly AppDbContext _context;
        public UsuariosController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult> Index()
        {
            var dados = await _context.Usuarios.ToListAsync();

            return View(dados);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }       
        
        public async Task<ActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

           var dados = await _context.Usuarios.FindAsync(id);

            if (dados == null)
            {
                return NotFound();
            }

            return View(dados);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int id, Usuario usuario)
        {
            if(id != usuario.Id) 
            {
                return NotFound();
            }
         
            if (ModelState.IsValid)
            {
                _context.Usuarios.Update(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<ActionResult> Details(int? id) 
        {
            if (id == null)
            {
                return NotFound();
            }
            var dados = await _context.Usuarios.FindAsync(id);

            if (dados == null)
            {
                return NotFound();
            }

            return View(dados);
        }

        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var dados = await _context.Usuarios.FindAsync(id);

            if (dados == null)
            {
                return NotFound();
            }

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var dados = await _context.Usuarios.FindAsync(id);

            if (dados == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }
}
