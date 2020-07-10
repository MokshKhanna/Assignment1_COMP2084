using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameWebApp.Data;
using GameWebApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace GameWebApp.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class GameCreatorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GameCreatorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GameCreators
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.GameCreators.ToListAsync());
        }

        // GET: GameCreators/Details/5

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameCreator = await _context.GameCreators
                .FirstOrDefaultAsync(m => m.CreatorId == id);
            if (gameCreator == null)
            {
                return NotFound();
            }

            return View(gameCreator);
        }

        // GET: GameCreators/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GameCreators/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("CreatorId,CreatorName,Description")] GameCreator gameCreator)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gameCreator);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gameCreator);
        }

        // GET: GameCreators/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameCreator = await _context.GameCreators.FindAsync(id);
            if (gameCreator == null)
            {
                return NotFound();
            }
            return View(gameCreator);
        }

        // POST: GameCreators/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("CreatorId,CreatorName,Description")] GameCreator gameCreator)
        {
            if (id != gameCreator.CreatorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gameCreator);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameCreatorExists(gameCreator.CreatorId))
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
            return View(gameCreator);
        }

        // GET: GameCreators/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gameCreator = await _context.GameCreators
                .FirstOrDefaultAsync(m => m.CreatorId == id);
            if (gameCreator == null)
            {
                return NotFound();
            }

            return View(gameCreator);
        }

        // POST: GameCreators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gameCreator = await _context.GameCreators.FindAsync(id);
            _context.GameCreators.Remove(gameCreator);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameCreatorExists(int id)
        {
            return _context.GameCreators.Any(e => e.CreatorId == id);
        }
    }
}
