using Microsoft.AspNetCore.Mvc;

namespace SaleSystem.AppWeb.Controllers
{
    public class NegocioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
