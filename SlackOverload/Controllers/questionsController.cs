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
            if(DAL.CurrentUser == null)
            {
                DAL.loginerror = "Please First Login";
                return Redirect("/home/loginform");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Create(questions q)
        {
            q.posted = DateTime.Now;
            q.status = 0;
            q.username = DAL.CurrentUser;
            DAL.CreateQ(q);
            return Redirect("/questions");
        }
        public IActionResult Upvote(int id)
        {
            int qid = DAL.UpvoteA(id);
            return RedirectToAction($"detail/{qid}");
        }
        public IActionResult DeleteWarning(int id)
        {
            questions q = DAL.GetOneQuestion(id);
            List<answers> a = DAL.GetSomeAnswers(id);
            ViewBag.AnswerCount = a.Count;
            return View(q);
        }
        public IActionResult DeleteQ(int id)
        {
            questions q = DAL.GetOneQuestion(id);
            DAL.DeleteQ(q);
            return Redirect("/questions");
        }
        public IActionResult CloseQ(int id)
        {
            questions q = DAL.GetOneQuestion(id);
            DAL.CloseQ(q);
            return Redirect($"/questions/detail/{id}");
        }
        public IActionResult OpenQ(int id)
        {
            questions q = DAL.GetOneQuestion(id);
            DAL.OpenQ(q);
            return Redirect($"/questions/detail/{id}");
        }
        public IActionResult EditForm(int id)
        {
            questions q = DAL.GetOneQuestion(id);
            return View(q);
        }
        public IActionResult Edit(questions q)
        {
            q.posted = DateTime.Now;
            q.status = 0;
            q.username = DAL.CurrentUser;
            DAL.EditQ(q);
            return Redirect("/questions");
        }
    }
}
