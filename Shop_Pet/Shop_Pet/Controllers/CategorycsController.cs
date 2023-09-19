using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shop_Pet.Data;
using Shop_Pet.Models;

namespace Shop_Pet.Controllers
{
    public class CategorycsController : Controller
    {
        private readonly Shop_PetContext _context;

        public CategorycsController(Shop_PetContext context)
        {
            _context = context;
        }

        // GET: Categorycs
        public async Task<IActionResult> Index()
        {
              return _context.Categorycs != null ? 
                          View(await _context.Categorycs.ToListAsync()) :
                          Problem("Entity set 'Shop_PetContext.Categorycs'  is null.");
        }

        // GET: Categorycs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Categorycs == null)
            {
                return NotFound();
            }

            var categorycs = await _context.Categorycs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categorycs == null)
            {
                return NotFound();
            }

            return View(categorycs);
        }

        // GET: Categorycs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categorycs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NamePet,HienThi")] Categorycs categorycs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categorycs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categorycs);
        }

        // GET: Categorycs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Categorycs == null)
            {
                return NotFound();
            }

            var categorycs = await _context.Categorycs.FindAsync(id);
            if (categorycs == null)
            {
                return NotFound();
            }
            return View(categorycs);
        }

        // POST: Categorycs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NamePet,HienThi")] Categorycs categorycs)
        {
            if (id != categorycs.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categorycs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategorycsExists(categorycs.Id))
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
            return View(categorycs);
        }

        // GET: Categorycs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Categorycs == null)
            {
                return NotFound();
            }

            var categorycs = await _context.Categorycs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categorycs == null)
            {
                return NotFound();
            }

            return View(categorycs);
        }

        // POST: Categorycs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Categorycs == null)
            {
                return Problem("Entity set 'Shop_PetContext.Categorycs'  is null.");
            }
            var categorycs = await _context.Categorycs.FindAsync(id);
            if (categorycs != null)
            {
                _context.Categorycs.Remove(categorycs);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategorycsExists(int id)
        {
          return (_context.Categorycs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
