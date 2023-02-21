using MvEcommerceApp.Models;

namespace MvEcommerceApp.ActionModels
{
    public class mvInventoryLocationAction
    {
        public string APIKEY { get; set; }
        public mvInventoryLocation mvInventoryLocation { get; set; }
        public string mvRecordAction { get; set; }
        public string? mvInsertUpdateDeleteSourceApplication { get; set; }
    }
}
