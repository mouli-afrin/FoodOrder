using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceProject.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Image { get; set; }
        //[Display(Name = "Product Color")]
        //public string ProductColor { get; set; }
		
        [Required]
        [Display(Name = "Available")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Food Type")]
        [Required]
        public int FoodTypeId { get; set; }
        [ForeignKey("FoodTypeId")]
        public virtual ProductTypes ProductTypes { get; set; }

        public virtual List<OrderDetails> OrderDetails { get; set; }


    }
}
