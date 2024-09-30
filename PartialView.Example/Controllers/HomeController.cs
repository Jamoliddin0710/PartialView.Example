using Microsoft.AspNetCore.Mvc;
using PartialView.Example.Model;

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

    [Route("programming-languages")]
    public IActionResult ProgrammingLanguages()
    {
        var model = new ModelEntity()
        {
            Title = "Programming Languages",
            Items = new List<string>()
            {
                "C#",
                "JS",
                "Java",
                "Php"
            }
        };

        return PartialView("_ListPartialView1", model);
    }
    
    // RenderPartialView bilan PartialView farqi RenderPartialView void qaytaradi u bajarilganda ma'lumotlar 
    // stream holatida browserga saqlanadi.
    // Partial da esa ma'lumot IHtmlContent qaytaradi undan qayta foydalanish ham mumkin
}