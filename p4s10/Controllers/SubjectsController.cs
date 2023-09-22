﻿using Microsoft.AspNetCore.Mvc;
using p4s10.Models;

namespace p4s10.Controllers
{
    public class SubjectsController : Controller
    {
        List<Subject> subject = new List<Subject>()
        {
            new Subject { Id = 1, Name = "English"},
            new Subject {Id = 2, Name = "Science"},
            new Subject {Id = 3, Name = "Maths"},
        };
        public IActionResult Index()
        {
            return View(subject);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Subject());
        }

        [HttpPost]
        public IActionResult Create(Subject model)
        {
            if (ModelState.IsValid)
            {
                subject.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}

