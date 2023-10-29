using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tabuleria_luderia.Models;

namespace tabuleria_luderia.Controllers
{
    public class LojasController : Controller
    {
        private readonly AppDbContext _context;

        public LojasController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.Lojas.ToListAsync();

            return View(dados);

        }

        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Create(Loja loja)
        {

            if (ModelState.IsValid)
            {
                _context.Lojas.Add(loja);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(loja);

        }

        public async Task<IActionResult> Edit(int? id) 
        {
           if (id == null)
            return NotFound();

            var dados = await _context.Lojas.FindAsync(id);
            if (dados == null)
                return NotFound();
            
            return View(dados);   
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Loja loja)
        {
            if (id != loja.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Lojas.Update(loja);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            
            return View();
        }
        public async Task<IActionResult> Details(int? id) 
        {
            if(id == null)
                return NotFound();
            
            var dados = await _context.Lojas.FindAsync(id);

            if(dados == null)
                return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Lojas.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Lojas.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.Lojas.Remove(dados);
            await _context.SaveChangesAsync();

            return View(dados);
        }

    }

}
