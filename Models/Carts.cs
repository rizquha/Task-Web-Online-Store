using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Web_Product.Models
{
    public class Carts
    {
        public int id {get;set;}
        public int totalPrice {get;set;}
        public ICollection<Items> Items {get;set;}

        [ForeignKey("User")]
        public int UserId {get;set;}
        public virtual User User {get;set;}

    }
}