namespace Client.Models
{
    public class ProductsInCartModel
    {
        public string pic_CartId { get; set; }
        public string pic_ProductId { get; set; }
        public string pic_ProductName { get; set; }
        public string pic_ProductImg { get; set; }
        public int pic_quantity { get; set; }
        public int pic_ProductPrice { get; set; }
        public string pic_size { get; set; }
        public string pic_color { get; set; }
        public int pic_SumPrice { get { return pic_quantity * pic_ProductPrice; } }
    }
}
