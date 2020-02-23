using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Web_Product.Models
{
    public class Carts
    {
        public int id {get;set;}
        public int totalPrice {get;set;}
        public ICollection<Items> Items {get;set;}
        public ICollection<Purchase> purchase {get;set;}

    }
}