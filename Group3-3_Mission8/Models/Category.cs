using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Group3_3_Mission8.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
