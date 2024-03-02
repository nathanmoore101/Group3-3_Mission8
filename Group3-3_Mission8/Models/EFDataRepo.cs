

﻿namespace Group3_3_Mission8.Models

{
    public class EFDataRepo : IDataRepo
    {
        private TaskDbContext _context;
        public EFDataRepo(TaskDbContext temp) 
        { 
            _context = temp;
        }
        public List<TaskModel> Tasks => _context.Tasks.ToList();
        public List<Category> Categories => _context.Categories.ToList();

        public void AddTask(TaskModel task)
        {
            _context.Add(task);
            _context.SaveChanges();

        }

        public void RemoveTask(TaskModel task)
        {
            _context.Remove(task);
            _context.SaveChanges();
        }

        public void UpdateTask(TaskModel task)
        {
            _context.Update(task);
            _context.SaveChanges();
        }

        public List<TaskModel> GetTasks()
        {
            return _context.Tasks.ToList();
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }


        public void ChangeCompletion(int Id)
        {
            var task = _context.Tasks.FirstOrDefault(t => t.Id == Id);
            if (task != null)
            {
                task.Completed = task.Completed == false ? true : false;
                _context.SaveChanges();
            }
        }
    }
}
