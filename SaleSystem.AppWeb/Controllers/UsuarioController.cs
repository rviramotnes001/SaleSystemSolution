using Microsoft.AspNetCore.Mvc;

namespace SaleSystem.AppWeb.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
