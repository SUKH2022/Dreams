namespace Dreams.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public CategoryProduct Product { get; set; } = new CategoryProduct();
    }
}