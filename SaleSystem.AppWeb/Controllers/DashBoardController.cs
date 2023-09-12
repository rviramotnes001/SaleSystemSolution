using Microsoft.AspNetCore.Mvc;

namespace SaleSystem.AppWeb.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
