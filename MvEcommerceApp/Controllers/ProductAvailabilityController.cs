using Microsoft.AspNetCore.Mvc;
using MvEcommerceApp.ActionModels;
using MvEcommerceApp.Models;

namespace MvEcommerceApp.Controllers
{
    [Route("api/product_availability")]
    [ApiController]
    public class ProductAvailabilityController : ControllerBase
    {
        private string apikey = "15b1e56f9de03a18@m139631";

        //Update the availability of products in a warehouse
        [HttpPost]
        public async Task<string> UpdateProductAvailability([FromBody] mvProductStockUpdate[] productStockUpdateList)
        {
            mvProductStockUpdateAction actionPayload = new mvProductStockUpdateAction();
            actionPayload.APIKEY = apikey;
            actionPayload.mvProductStockUpdateList = productStockUpdateList;
            using (var client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync("https://api.megaventory.com/v2017a/InventoryLocationStock/ProductStockUpdate", actionPayload);
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
