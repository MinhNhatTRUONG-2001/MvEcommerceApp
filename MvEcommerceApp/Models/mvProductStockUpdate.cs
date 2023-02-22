namespace MvEcommerceApp.Models
{
    public class mvProductStockUpdate
    {
        public string ProductSKU { get; set; }
        public double ProductQuantity { get; set; }
        public double? ProductUnitCost { get; set; }
        public int InventoryLocationID { get; set; }
    }
}
