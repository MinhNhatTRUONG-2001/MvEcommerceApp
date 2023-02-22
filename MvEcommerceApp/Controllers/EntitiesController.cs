using Microsoft.AspNetCore.Mvc;
using MvEcommerceApp.ActionModels;
using MvEcommerceApp.Models;

namespace MvEcommerceApp.Controllers
{
    [Route("api/entities")]
    [ApiController]
    public class EntitiesController : ControllerBase
    {
        private string apikey = "15b1e56f9de03a18@m139631";
        
        //Insert (a new) or update (an existing):
        // - Product
        [HttpPost("product")]
        public async Task<string> InsertOrUpdateProduct([FromBody] mvProduct product)
        {
            mvProductAction actionPayload = new mvProductAction();
            actionPayload.APIKEY = apikey;
            actionPayload.mvProduct = product;
            actionPayload.mvRecordAction = "InsertOrUpdate";
            using (var client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync("https://api.megaventory.com/v2017a/Product/ProductUpdate", actionPayload);
                return await response.Content.ReadAsStringAsync();
            }
        }

        // - Supplier or Client
        [HttpPost("supplier_client")]
        public async Task<string> InsertOrUpdateSupplierClient([FromBody] mvSupplierClient supplierClient)
        {
            mvSupplierClientAction actionPayload = new mvSupplierClientAction();
            actionPayload.APIKEY = apikey;
            actionPayload.mvSupplierClient = supplierClient;
            actionPayload.mvRecordAction = "InsertOrUpdateNonEmptyFields";
            using (var client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync("https://api.megaventory.com/v2017a/SupplierClient/SupplierClientUpdate", actionPayload);
                return await response.Content.ReadAsStringAsync();
            }
        }

        // - Inventory location (warehouse)
        [HttpPost("inventory_location")]
        public async Task<string> InsertOrUpdateInventoryLocation([FromBody] mvInventoryLocation inventoryLocation)
        {
            mvInventoryLocationAction actionPayload = new mvInventoryLocationAction();
            actionPayload.APIKEY = apikey;
            actionPayload.mvInventoryLocation = inventoryLocation;
            actionPayload.mvRecordAction = "InsertOrUpdate";
            using (var client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync("https://api.megaventory.com/v2017a/InventoryLocation/InventoryLocationUpdate", actionPayload);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
