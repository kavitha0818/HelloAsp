 using Microsoft.AspNetCore.Mvc;
 
 namespace HelloAsp;

public class HelloController : Controller
{
    public IActionResult Index()
    {
        ViewBag.message="holamundo";
        return View();
    }

}
