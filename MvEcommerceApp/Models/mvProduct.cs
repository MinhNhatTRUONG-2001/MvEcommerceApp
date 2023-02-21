namespace MvEcommerceApp.Models
{
    public class mvProduct
    {
        public int? ProductId { get; set; }
        public string ProductSKU { get; set; }
        public string ProductDescription { get; set; }
        public double? ProductSellingPrice { get; set; }
        public double? ProductPurchasePrice { get; set; }
    }
}
