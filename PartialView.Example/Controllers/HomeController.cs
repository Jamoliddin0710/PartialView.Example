using Microsoft.AspNetCore.Mvc;

namespace PartialView.Example.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public IActionResult Index()
    {
        ViewData["Title"] = "Countries";
        ViewData["ListItems"] = new List<string>()
        {
            "Spain",
            "Germany",
            "USA",
            "UAE"
        };
        
        return View();
    }

    [Route("/about")]
    public IActionResult About()
    {
        return View();
    }
    
    // RenderPartialView bilan PartialView farqi RenderPartialView void qaytaradi u bajarilganda ma'lumotlar 
    // stream holatida browserga saqlanadi.
    // Partial da esa ma'lumot IHtmlContent qaytaradi undan qayta foydalanish ham mumkin
}