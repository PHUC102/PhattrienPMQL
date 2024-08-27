using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;



namespace DemoMvc.Controllers;
public class PDPController: Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(PDP pdp)
        {
            ViewBag.PDP = "PDP xin chao " + pdp.FullName + '-' + pdp.Age + '-' + pdp.Hight;
           
            return View();
        }
 
}


