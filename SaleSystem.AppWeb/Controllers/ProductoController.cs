using Microsoft.AspNetCore.Mvc;

namespace SaleSystem.AppWeb.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
