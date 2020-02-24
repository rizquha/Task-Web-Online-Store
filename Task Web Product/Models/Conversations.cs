using System;

namespace Task_Web_Product.Models
{
    public class Conversations
    {
            public int id { get; set; }
            public int sender_id { get; set; }
            public int receiver_id { get; set; }
            public string message { get; set; }
            public DateTime created_at { get; set; }
            public DateTime ? Read {get;set;}
    }
}