using Microsoft.AspNetCore.Mvc;
using System;




namespace Group3_3_Mission8.Models
{
    public class TaskModel

    {
        public int Id { get; set; }

        public required string TaskName { get; set; }

        public DateTime? DueDate { get; set; }

        public required string Quadrant { get; set; }

        public Category? Category { get; set; }

        public bool? Completed { get; set; }

    }


}
