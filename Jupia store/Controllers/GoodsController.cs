using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using ServiceContract;
using ServiceContract.DTO;
using ServiceContract.Enums;
using System.Net.Http;

namespace Jupia_store.Controllers
{
    [Route("[controller]")]
    public class GoodsController : Controller
    {
        //private fields
        private readonly IGoodsService _goodsService;
        private readonly IHttpClientFactory _httpClientFactory;


        public GoodsController(IGoodsService goodsService)
        {
            _goodsService = goodsService;
            //_httpClientFactory = httpClientFactory;
        }

        //Url: goods/index
        [Route("[action]")]
        //Url: goods/
        [Route("/")]
        public async Task<IActionResult> Index(string searchBy, string? searchString, 
            string sortBy = nameof(GoodsResponse.GoodsName), SortOrderOptions sortOrderOptions = SortOrderOptions.ASC)
        {
            var sanityApiUrl = "https://mdr7r2qw.api.sanity.io/v2022-03-07/data/query/production?query=*%5B_type+%3D%3D+%27Goods%27%5D+";
            string apiKey = "yourApiKey";
            try
            {

                using (HttpClient client = new HttpClient())
                {
                    // Set up the request headers or any other configurations
                    client.DefaultRequestHeaders.Add("Authorization", "apiToken YourAccessToken");

                    // Make a GET request
                    HttpResponseMessage response = await client.GetAsync(sanityApiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        // Handle the successful response
                        string content = await response.Content.ReadAsStringAsync();
                        // Deserialize content as needed
                        ;
                        ViewBag.SanityGoods = content.ToString();
                        //return Content(content);
                    }
                    else
                    {
                        // Handle error responses
                        ViewBag.SanityGoodsErrors = StatusCode((int)response.StatusCode, response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //Searching
            ViewBag.SearchFields = new Dictionary<string, string>()
            {
                {nameof(GoodsResponse.GoodsName), "Goods Name"},
                {nameof(GoodsResponse.GoodsDescription), "Goods Description"},
                {nameof(GoodsResponse.GoodsPrice), "Goods Price"},
                {nameof(GoodsResponse.GoodsDiscount), "Goods Discount" },
                {nameof(GoodsResponse.GoodType), "Goods Type"},
                {nameof(GoodsResponse.GoodsStore), "Goods Store"}
            };
            
            //searchBy
            List<GoodsResponse> goodsResponses = _goodsService.GetFilteredGoods(searchBy, searchString);
            ViewBag.CurrentSearchBy = searchBy;
            ViewBag.CurrentSearchString = searchString;

            //Sort
            List<GoodsResponse> sortGoods = _goodsService.GetSortedGoods(goodsResponses, sortBy, sortOrderOptions);
            ViewBag.CurrentSortBy = sortBy.ToString();
            ViewBag.CurrentSortOrderOptions = sortOrderOptions.ToString();
            return View(sortGoods);
        }
      
    }
}
