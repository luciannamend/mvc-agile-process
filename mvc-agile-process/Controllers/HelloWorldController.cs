using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    //public string Index()
    //{
    //    return "This is my default action...";
    //}
    public IActionResult Index()
    {
        return View(); // This will look for a file in Views/HelloWorld/Index.cshtml
    }

    //// 
    //// GET: /HelloWorld/Welcome/ 
    //public string Welcome()
    //{
    //    return "This is the Welcome action method...";
    //}
    //// Requires using System.Text.Encodings.Web;
    //public string Welcome(string name, int numTimes = 1)
    //{
    //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    //}
    //public string Welcome(string name, int ID = 1)
    //{
    //    return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    //}

    // GET: /HelloWorld/Welcome/
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        // The ViewData dictionary object contains data that will be passed to the view
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}