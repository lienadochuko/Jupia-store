using Microsoft.AspNetCore.Mvc;
using ServiceContract;
using ServiceContract.DTO;
using ServiceContract.Enums;

namespace Jupia_store.Controllers
{
    [Route("[controller]")]
    public class GoodsController : Controller
    {
        //private fields
        private readonly IGoodsService _goodsService;

        public GoodsController(IGoodsService goodsService)
        {
            _goodsService = goodsService;
        }

        //Url: goods/index
        [Route("[action]")]
        //Url: goods/
        [Route("/")]
        public IActionResult Index(string searchBy, string? searchString, 
            string sortBy = nameof(GoodsResponse.GoodsName), SortOrderOptions sortOrderOptions = SortOrderOptions.ASC)
        {
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
