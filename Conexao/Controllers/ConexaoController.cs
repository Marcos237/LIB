using Microsoft.AspNetCore.Mvc;

namespace Conexao.Controllers
{
    public class ConexaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
