using MvEcommerceApp.Models;

namespace MvEcommerceApp.ActionModels
{
    public class mvProductAction
    {
        public string APIKEY { get; set; }
        public mvProduct mvProduct { get; set; }
        public string mvRecordAction { get; set; }
        public string? mvInsertUpdateDeleteSourceApplication { get; set; }
    }
}
