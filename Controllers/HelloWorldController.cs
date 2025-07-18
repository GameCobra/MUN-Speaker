using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MUN_Speaker.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }

    public string NameNum(string name, int numTimes = 1)
    {
    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }

    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }

    // 
    // GET: /HelloWorld/Welcome/ 
    public string HTMLWelcomEncoder(string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
}