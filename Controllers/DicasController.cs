using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Covid19.Controllers
{
    public class DicasController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dicas()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        
    }
}