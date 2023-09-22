using Microsoft.AspNetCore.Mvc;
using p4s10.Models;

namespace p4s10.Controllers
{
    public class TeachersController : Controller
    {

        List<Teacher> teacher = new List<Teacher>()
        {
            new Teacher { Id = 1, Name = "kalpana", TeachingSubject = "English" },
            new Teacher { Id = 2, Name = "pavi", TeachingSubject = "Science" },
            new Teacher { Id = 3, Name = "kavya", TeachingSubject = "Maths" },
        };

        public IActionResult Index()
        {
            return View(teacher);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Teacher());
        }

        [HttpPost]
        public IActionResult Create(Teacher model)
        {
            if (ModelState.IsValid)
            {
                teacher.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

    }
}

