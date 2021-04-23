using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyfirstMVC.Data;
using MyfirstMVC.Models;

namespace MyfirstMVC.Controllers
{
    public class ShippingModelsController : Controller
    {
        private readonly MyfirstMVCContext _context;

        public ShippingModelsController(MyfirstMVCContext context)
        {
            _context = context;
        }

        // GET: ShippingModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShippingModel.ToListAsync());
        }

        // GET: ShippingModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shippingModel = await _context.ShippingModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shippingModel == null)
            {
                return NotFound();
            }

            return View(shippingModel);
        }

        // GET: ShippingModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ShippingModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Address,Company,PostalCode")] ShippingModel shippingModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shippingModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shippingModel);
        }

        // GET: ShippingModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shippingModel = await _context.ShippingModel.FindAsync(id);
            if (shippingModel == null)
            {
                return NotFound();
            }
            return View(shippingModel);
        }

        // POST: ShippingModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Address,Company,PostalCode")] ShippingModel shippingModel)
        {
            if (id != shippingModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shippingModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShippingModelExists(shippingModel.Id))
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
            return View(shippingModel);
        }

        // GET: ShippingModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shippingModel = await _context.ShippingModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shippingModel == null)
            {
                return NotFound();
            }

            return View(shippingModel);
        }

        // POST: ShippingModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shippingModel = await _context.ShippingModel.FindAsync(id);
            _context.ShippingModel.Remove(shippingModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShippingModelExists(int id)
        {
            return _context.ShippingModel.Any(e => e.Id == id);
        }
    }
}
