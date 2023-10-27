namespace Zadanie_2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; } 
                                            

        public Category Category { get; set; } 
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
    }


    public class ShoppingCart
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; } 
        public decimal TotalPrice { get; set; } 
        public string UserId { get; set; } 
    }

    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }

}

