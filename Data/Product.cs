using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GS_MVC.Data
{
    public class Product {
        [Key]
        public int Id {get;set;}
        [Required]
        public string Name {get;set;}
        [Required]
        public int QuantityInStock {get;set;}
        [Required]
        public double Price {get;set;}
    }
}