using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Student> _studentRepository;
        public HomeController(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            return View(_studentRepository.GetAll().OrderBy(s => s.Id));

        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            student.Id = _studentRepository.GetAll().Count() + 1;
            var isSuccess = _studentRepository.Add(student);
            if(isSuccess)
                return RedirectToAction("Index");

            return View();
        }

        public IActionResult Edit(int id)
        {
            return View(_studentRepository.Get(id));
        }
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            var isSuccess = _studentRepository.Update(student);
            if(isSuccess)
                return RedirectToAction("Index");

            return View();
        }

        public IActionResult Delete(int id)
        {
            var student = _studentRepository.Get(id);
            var isSuccess = _studentRepository.Delete(student);
            if(isSuccess)
                return RedirectToAction("Index");

            return View();
        }

        public IActionResult Details(int id)
        {
            return View(_studentRepository.Get(id));
        }

    }
}
