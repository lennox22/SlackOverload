using Microsoft.AspNetCore.Mvc;
using SlackOverload.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlackOverload.Controllers
{
    public class questionsController : Controller
    {
        public IActionResult Index()
        {
            List<questions> q = DAL.GetAllQuestions();
            return View(q);
        }
        public IActionResult Detail(int id)
        {
            questions singleq = DAL.GetOneQuestion(id);
            List<answers> a = DAL.GetSomeAnswers(id);
            ViewBag.answers = a;
            return View(singleq);
        }
        public IActionResult CreateForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(questions q)
        {
            q.posted = DateTime.Now;
            q.status = 0;
            DAL.CreateQ(q);
            return RedirectToAction("/index");
        }
    }
}
