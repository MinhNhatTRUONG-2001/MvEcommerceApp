using MvEcommerceApp.Models;

namespace MvEcommerceApp.ActionModels
{
    public class mvSupplierClientAction
    {
        public string APIKEY { get; set; }
        public mvSupplierClient mvSupplierClient { get; set; }
        public string mvRecordAction { get; set; }
        public string? mvInsertUpdateDeleteSourceApplication { get; set; }
    }
}
