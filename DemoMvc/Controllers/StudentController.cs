using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;

namespace DemoMvc.Controllers;

public class StudentController : Controller
{
    

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Student sd)
        {
            string strOutput = "PDP xin chao " + sd.StudentId + "-" + sd.Name + "-" + sd.Address;
            ViewBag.Message = strOutput;
            return View();
        }
 
}