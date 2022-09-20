using Microsoft.AspNetCore.Mvc;
using Day03_20092022.Models;
using System.Text.Json;

namespace Day03_20092022.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {   
        return View();
    }

    string JsonFileName = "Student.json";
    string TxTFileName = "Student.txt";
    [HttpPost]

    public IActionResult Manage(Student sinhVien, string buttonName)
    {
        if (buttonName == "Ghi file Json")
        {
            var jsonString = JsonSerializer.Serialize(sinhVien);
            var fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", JsonFileName);
            System.IO.File.WriteAllText(fullPath, jsonString);
        }
        return View("Index", sinhVien);
    }
}



