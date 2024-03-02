using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System;




namespace Group3_3_Mission8.Models
{
    public class TaskModel

    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Task is required.")]
        public string TaskName { get; set; }

        public DateTime? DueDate { get; set; }


        [Required(ErrorMessage = "Quadrant is required.")]
        public string Quadrant { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }


        public bool? Completed { get; set; }

    }


}
