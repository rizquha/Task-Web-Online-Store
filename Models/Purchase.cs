using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Web_Product.Models
{
    public class Purchase
    {
        public int id{get;set;}
        public string firstName {get;set;}
        public string lastName {get;set;}
        public string email {get;set;}
        public string phoneNumber {get;set;}
        public string shippingAddress {get;set;}
        public string Province {get;set;}
        public string Regency {get;set;}
        public int Zip {get;set;}
        public int totalPrice {get;set;}
        

        [ForeignKey("CartsId")]
        public int? CartsId {get;set;}=null;
        public Carts Carts {get;set;}
    }
}