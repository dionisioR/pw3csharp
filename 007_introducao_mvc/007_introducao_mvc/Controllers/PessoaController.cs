using Microsoft.AspNetCore.Mvc;

namespace _007_introducao_mvc.Controllers
{
    public class PessoaController : Controller
    {
        public IActionResult Produto()
        {
            return View();
        }

        
        public IActionResult Contato()
        {
            return View();
        }
    }
}
