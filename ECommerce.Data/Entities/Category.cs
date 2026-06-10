using System.Collections.Generic; 

namespace ECommerce.Data.Entities
{
        public class Category
    {
        public int Id {get; set;}
        public string Name {get; set;} = string.Empty; 

        // Navigation Property 

         public List<Product> Products { get; set; } = new List<Product>();
         
    }
}