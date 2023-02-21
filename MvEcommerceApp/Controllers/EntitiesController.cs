using Microsoft.AspNetCore.Mvc;
using MvEcommerceApp.ActionModels;
using MvEcommerceApp.Models;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvEcommerceApp.Controllers
{
    [Route("api/entities")]
    [ApiController]
    public class EntitiesController : ControllerBase
    {
        private string apikey = "15b1e56f9de03a18@m139631";
        
        [HttpPost("product")]
        public async Task<HttpStatusCode> InsertOrUpdateProduct([FromBody] mvProduct product)
        {
            mvProductAction actionPayload = new mvProductAction();
            actionPayload.APIKEY = apikey;
            actionPayload.mvProduct = product;
            actionPayload.mvRecordAction = "InsertOrUpdate";
            using (var client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync("https://api.megaventory.com/v2017a/Product/ProductUpdate", actionPayload);
                return response.StatusCode;
            }
        }

        [HttpPost("supplier_client")]
        public async Task<HttpStatusCode> InsertOrUpdateSupplierClient([FromBody] mvSupplierClient supplierClient)
        {
            mvSupplierClientAction actionPayload = new mvSupplierClientAction();
            actionPayload.APIKEY = apikey;
            actionPayload.mvSupplierClient = supplierClient;
            actionPayload.mvRecordAction = "InsertOrUpdateNonEmptyFields";
            using (var client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync("https://api.megaventory.com/v2017a/SupplierClient/SupplierClientUpdate", actionPayload);
                return response.StatusCode;
            }
        }

        [HttpPost("inventory_location")]
        public async Task<HttpStatusCode> InsertOrUpdateInventoryLocation([FromBody] mvInventoryLocation inventoryLocation)
        {
            mvInventoryLocationAction actionPayload = new mvInventoryLocationAction();
            actionPayload.APIKEY = apikey;
            actionPayload.mvInventoryLocation = inventoryLocation;
            actionPayload.mvRecordAction = "InsertOrUpdate";
            using (var client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync("https://api.megaventory.com/v2017a/InventoryLocation/InventoryLocationUpdate", actionPayload);
                return response.StatusCode;
            }
        }
    }
}
