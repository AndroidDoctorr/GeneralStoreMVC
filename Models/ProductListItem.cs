using System;

namespace GS_MVC.Models
{
    public class ProductListItem
    {
        public int ProductId {get;set;}
        public string Name { get; set; }
        public double Price {get;set;}
        public int QuantityInStock {get;set;}
    }
}
