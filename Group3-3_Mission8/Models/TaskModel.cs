using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System;




namespace Group3_3_Mission8.Models
{
    public class TaskModel

    {
        public int Id { get; set; }

        [Required]
        public string TaskName { get; set; }

        public DateTime? DueDate { get; set; }

        [Required]
        public string Quadrant { get; set; }

        public Category? Category { get; set; }

        public bool? Completed { get; set; }

    }


}
