using Group3_3_Mission8.Models;
using Microsoft.AspNetCore.Mvc;
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
            return View(new TaskModel());
        }

        [HttpPost]
        public IActionResult TaskView(TaskModel task)
        {
            if (ModelState.IsValid)
            {
                _repo.AddTask(task);
            }

            return View(new TaskModel());

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
