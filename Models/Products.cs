namespace front_to_back_code.Models
{
    public class Products
    {
        public class Product
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public int Discount { get; set; }
            public double Price { get; set; }
            public string Image { get; set; }
            public int Order { get; set; }
        }
    }
}
