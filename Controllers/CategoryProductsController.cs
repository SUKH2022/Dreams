using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dreams.Models;
using Microsoft.AspNetCore.Authorization;

namespace Dreams.Controllers
{
    public class CategoryProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CategoryProducts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CategoryProducts.Include(c => c.Category);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CategoryProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CategoryProducts == null)
            {
                return NotFound();
            }

            var categoryProduct = await _context.CategoryProducts
                .Include(c => c.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoryProduct == null)
            {
                return NotFound();
            }

            return View(categoryProduct);
        }

        // GET: CategoryProducts/Create
        [Authorize(Roles="Admin")]
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        // POST: CategoryProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles="Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategoryId,Name,Description,Image,MSRP")] CategoryProduct categoryProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoryProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", categoryProduct.CategoryId);
            return View(categoryProduct);
        }

        // GET: CategoryProducts/Edit/5
        [Authorize(Roles="Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CategoryProducts == null)
            {
                return NotFound();
            }

            var categoryProduct = await _context.CategoryProducts.FindAsync(id);
            if (categoryProduct == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", categoryProduct.CategoryId);
            return View(categoryProduct);
        }

        // POST: CategoryProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles="Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoryId,Name,Description,Image,MSRP")] CategoryProduct categoryProduct)
        {
            if (id != categoryProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(categoryProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryProductExists(categoryProduct.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", categoryProduct.CategoryId);
            return View(categoryProduct);
        }

        // GET: CategoryProducts/Delete/5
        [Authorize(Roles="Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CategoryProducts == null)
            {
                return NotFound();
            }

            var categoryProduct = await _context.CategoryProducts
                .Include(c => c.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoryProduct == null)
            {
                return NotFound();
            }

            return View(categoryProduct);
        }

        // POST: CategoryProducts/Delete/5
        [Authorize(Roles="Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CategoryProducts == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CategoryProducts'  is null.");
            }
            var categoryProduct = await _context.CategoryProducts.FindAsync(id);
            if (categoryProduct != null)
            {
                _context.CategoryProducts.Remove(categoryProduct);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryProductExists(int id)
        {
            return (_context.CategoryProducts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
