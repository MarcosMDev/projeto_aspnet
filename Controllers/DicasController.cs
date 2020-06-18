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
using MvcFill.ViewModels;

namespace Covid19.Controllers
{
    public class DicasController : Controller
    {

        private readonly MvcTipsContext _context;

        public DicasController(MvcTipsContext context)
        {
            _context = context;
        }
        
[HttpPost]
public string Index(string searchString, bool notUsed)
{
    return "From [HttpPost]Index: filter on " + searchString;
}
public async Task<IActionResult> Index(string tipsAutor, string searchString)
{
    // Use LINQ to get list of genres.
    IQueryable<string> genreQuery = from m in _context.Tips
                                    orderby m.Autor
                                    select m.Autor;

    var movies = from m in _context.Tips
                 select m;

    if (!string.IsNullOrEmpty(searchString))
    {
        movies = movies.Where(s => s.Title.Contains(searchString));
    }

    if (!string.IsNullOrEmpty(tipsAutor))
    {
        movies = movies.Where(z => z.Autor.Contains(tipsAutor));
    }

    var filtrei = new Fill
    {
        Autors = new SelectList(await genreQuery.Distinct().ToListAsync()),
        Tips = await movies.ToListAsync()
    };

    return View(filtrei);
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