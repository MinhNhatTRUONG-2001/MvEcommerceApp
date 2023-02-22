using MvEcommerceApp.Models;

namespace MvEcommerceApp.ActionModels
{
    public class mvProductStockUpdateAction
    {
        public string APIKEY { get; set; }
        public mvProductStockUpdate[] mvProductStockUpdateList { get; set; }
    }
}
