using System; 
using System.Collections.Generic; 

namespace ECommerce.Data.Entities
{
    public class Order
    {
        public int Id {get; set;}
        public int UserId {get; set;}
        public decimal TotalPrice {get; set;}
        public string Status {get; set;} = string.Empty; 
        public DateTime CreatedAt {get; set;}

        public User User {get; set;} = null!; 
        public List<OrderItem> OrderItems {get; set;} = new List<OrderItem>(); 

    }
}