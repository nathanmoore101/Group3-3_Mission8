using Group3_3_Mission8.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using TaskModel = Group3_3_Mission8.Models.TaskModel;

// Your controller code here


namespace Group3_3_Mission8.Controllers
{
    public class HomeController : Controller
    {
        private IDataRepo _repo;
        public HomeController(IDataRepo repo)
        {
            _repo = repo;
        }

        public IActionResult TaskView()
        {
            ViewBag.Categories = _repo.GetCategories();

            return View();
        }

        [HttpPost]
        public IActionResult TaskView(TaskModel task)
        {
            {
                _repo.AddTask(task);
            }

            return View("Submit");

        }

        public IActionResult QuadrantView()
        {
            var tasks = _repo.GetTasks();

            return View(tasks);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _repo.GetTasks()
                .Single(x => x.Id == id);

            return View("TaskView", recordToEdit);

        }

        [HttpPost]
        public IActionResult Edit(TaskModel task)
        {
            _repo.UpdateTask(task);
            return RedirectToAction("QuadrantView");
        }

        [HttpPost]
        public IActionResult Completion(int id)
        {
            _repo.ChangeCompletion(id);


            return RedirectToAction("QuadrantView");

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _repo.GetTasks()
                .Single(x => x.Id == id);
            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(TaskModel task)
        {
            _repo.RemoveTask(task);
            return RedirectToAction("QuadrantView");
        }
    }
}
