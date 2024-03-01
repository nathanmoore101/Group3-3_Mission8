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
        private TaskDbContext _context;
        public HomeController(TaskDbContext temp)
        {
            _context = temp;

        }
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Task()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Name)
                .ToList();

            return View("Task", new TaskModel());
        }

        [HttpPost]
        public IActionResult Task(TaskModel taskModel)
        {
            if (ModelState.IsValid)
            {
                _context.Tasks.Add(taskModel);
                _context.SaveChanges();
                return View("Submit", taskModel);
            }
            else
            {
                ViewBag.Categories = _context.Categories
                    .OrderBy(x => x.Name)
                    .ToList();

                return View(taskModel);
            }

        }
  
        public IActionResult TaskModel()
        {
            var task = _context.Tasks
                .OrderBy(x => x.TaskName).ToList();

            return View(task);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Tasks
                .Single(x => x.Id == id);

            ViewBag.Categories = _context.Categories
              .OrderBy(x => x.Name)
              .ToList();
            return View("Task", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(TaskModel updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("TaskModel");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Tasks
                .Single(x => x.Id == id);
            ViewBag.Categories = _context.Tasks
                .ToList();

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(TaskModel task)
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
            return RedirectToAction("TaskModel");
        }

    }
}
