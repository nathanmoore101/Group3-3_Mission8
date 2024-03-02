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
            return View();
        }



            //[HttpGet]
            //public IActionResult Edit(int id)
            //{
            //    var recordToEdit = _context.Tasks
            //        .Single(x => x.Id == id);

            //    ViewBag.Categories = _context.Categories
            //      .OrderBy(x => x.Name)
            //      .ToList();
            //    return View("Tasks", recordToEdit);
            //}

            //[HttpPost]
            //public IActionResult Edit(TaskModel updatedInfo)
            //{
            //    _context.Update(updatedInfo);
            //    _context.SaveChanges();

            //    return RedirectToAction("Quadrants");
            //}

            //[HttpGet]
            //public IActionResult Delete(int id)
            //{
            //    var recordToDelete = _context.Tasks
            //        .Single(x => x.Id == id);

            //    return View(recordToDelete);
            //}

            //[HttpPost]
            //public IActionResult Delete(TaskModel task)
            //{
            //    _context.Tasks.Remove(task);
            //    _context.SaveChanges();
            //    return RedirectToAction("Quadrants");
            //}

        
    }
}
