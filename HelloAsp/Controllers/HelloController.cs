 using Microsoft.AspNetCore.Mvc;
 
 namespace HelloAsp;

public class HelloController : Controller
{
    public IActionResult Index()
    {
        ViewBag.message="HelloWorld";
        return View();
    }

}
