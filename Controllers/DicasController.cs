using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcTips.Data;
using MvcTips.Models;
using Microsoft.AspNetCore.Authorization;

namespace Covid19.Controllers
{
    public class DicasController : Controller
    {
        
        private readonly MvcTipsContext _context;

         public DicasController(MvcTipsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Tips.ToListAsync());
        }

        public async Task<IActionResult> Detalhes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tips = await _context.Tips
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tips == null)
            {
                return NotFound();
            }

            return View(tips);
        }
    }
}