using Microsoft.AspNetCore.Mvc;
using MvEcommerceApp.ActionModels;
using MvEcommerceApp.Models;

namespace MvEcommerceApp.Controllers
{
    [Route("api/relationships")]
    [ApiController]
    public class RelationshipController : ControllerBase
    {
        private string apikey = "15b1e56f9de03a18@m139631";

        //Create or update:
        // - Product-client relationships
        [HttpPost("product_client")]
        public async Task<string> UpdateProductClientRelationship([FromBody] mvProductClient productClient)
        {
            mvProductClientAction actionPayload = new mvProductClientAction();
            actionPayload.APIKEY = apikey;
            actionPayload.mvProductClientUpdate = productClient;
            actionPayload.mvRecordAction = "InsertOrUpdateNonEmptyFields";
            using (var client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync("https://api.megaventory.com/v2017a/ProductClient/ProductClientUpdate", actionPayload);
                return await response.Content.ReadAsStringAsync();
            }
        }

        // - Product-supplier relationships
        [HttpPost("product_supplier")]
        public async Task<string> UpdateProductSupplierRelationship([FromBody] mvProductSupplier productSupplier)
        {
            mvProductSupplierAction actionPayload = new mvProductSupplierAction();
            actionPayload.APIKEY = apikey;
            actionPayload.mvProductSupplierUpdate = productSupplier;
            actionPayload.mvRecordAction = "InsertOrUpdateNonEmptyFields";
            using (var client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync("https://api.megaventory.com/v2017a/ProductSupplier/ProductSupplierUpdate", actionPayload);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
