using System.ComponentModel.DataAnnotations;

namespace ECommerceProject.Models
{
    public class ProductTypes
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Food Type")]
        public string FoodType { get; set; }
    }
}
