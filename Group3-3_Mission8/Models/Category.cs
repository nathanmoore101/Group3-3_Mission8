using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace Group3_3_Mission8.Models
{
    [Table("Categories")]
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
