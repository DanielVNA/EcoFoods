using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoFoods.DomainEntities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage = "The price cannot be a negative number")]
        public double Price { get; set; }
        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage = "The quantity cannot be a negative number")]
        public double Quantity { get; set; }

    }
}
