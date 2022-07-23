using Microsoft.AspNetCore.Mvc;

namespace CleanArchMvc.WebUI.Controllers;
public class PrivacyController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
