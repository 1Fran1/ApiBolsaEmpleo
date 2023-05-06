using Microsoft.AspNetCore.Mvc;

namespace ApiBolsaEmpleo.Controllers
{
    public class CandidatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
