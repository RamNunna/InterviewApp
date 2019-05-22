using InterviewApp.Business;
using InterviewApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace InterviewApp.Controllers
{
    public class OnlineTestController : Controller
    {
        IConfiguration _configuration;
        string connStr;
        public OnlineTestController(IConfiguration configuration)
        {
            _configuration = configuration;
            connStr = _configuration["ConnectionStrings:DefaultConnection"];
        }
        // GET: OnlineTest
        public IActionResult Index()
        {
            return View(OnlineTestManager.GetQuestionAndAnswers(connStr));
        }

        // GET: OnlineTest/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OnlineTest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OnlineTest/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OnlineTest/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OnlineTest/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OnlineTest/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OnlineTest/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}