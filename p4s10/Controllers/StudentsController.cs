using Microsoft.AspNetCore.Mvc;
using p4s10.Models;

namespace p4s10.Controllers
{
    public class StudentsController : Controller
    {
        List<Student> student = new List<Student>()
        {
            new Student { Id = 1, Name = "kalpana", Class = "9", Age = 15, Address = "aaa"},
            new Student { Id = 2, Name = "Sindhu", Class = "8", Age = 14, Address = "bbb"},
            new Student { Id = 3, Name = "pavi", Class = "7", Age = 11, Address = "ccc"},
        };
        public IActionResult Index()
        {
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                student.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}

