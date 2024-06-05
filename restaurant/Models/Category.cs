using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace restaurant.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        [NotMapped]
        public IFormFile File { get; set; } 

        public string Icon { get; set; } 
        public List<Product>? Products { get; set; }

        public bool SoftDelete { get; set; }   
    }
}
