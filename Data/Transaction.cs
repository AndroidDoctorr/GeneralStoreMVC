using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace GS_MVC.Data
{
    public class Transaction {
        [Key]
        public int Id {get;set;}
        [Required]
        public int ProductId {get;set;}
        [Required]
        public int CustomerId {get;set;}
        [Required]
        public int Quantity {get;set;}
        [Required]
        public DateTime DateOfTransaction {get;set;}
    }
}