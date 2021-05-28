using Microsoft.AspNetCore.Mvc;
using SlackOverload.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlackOverload.Controllers
{
    public class answersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upvote(int id)
        {
            int qid = DAL.UpvoteA(id);
            return Redirect($"/questions/detail/{qid}");
        }
        public IActionResult CreateForm(int id)
        {
            if (DAL.CurrentUser == null)
            {
                DAL.loginerror = "Please First Login";
                return Redirect("/home/loginform");
            }
            questions q = DAL.GetOneQuestion(id);
            ViewBag.details = q.details;
            return View(id);
        }
        public IActionResult Create(answers a)
        {
            a.posted = DateTime.Now;
            a.username = DAL.CurrentUser;
            DAL.CreateA(a);
            return Redirect($"/questions/detail/{a.qid}");
        }
        public IActionResult EditForm(int id)
        {
            answers a = DAL.GetOneAnswer(id);
            return View(a);
        }
        public IActionResult Edit(answers a)
        {
            a.posted = DateTime.Now;
            a.username = DAL.CurrentUser;
            DAL.EditA(a);
            return Redirect($"/questions/detail/{a.qid}");
        }
        public IActionResult DeleteWarning(int id)
        {
            answers a = DAL.GetOneAnswer(id);
            return View(a);
        }
        public IActionResult DeleteA(int id)
        {
            answers a = DAL.GetOneAnswer(id);
            DAL.DeleteA(a);
            return Redirect($"/questions/detail/{a.qid}");
        }
    }
}
