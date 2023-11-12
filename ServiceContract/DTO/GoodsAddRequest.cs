using Entitties;
using ServiceContract.Enums;
using System.ComponentModel.DataAnnotations;

namespace ServiceContract.DTO
{
    public class GoodsAddRequest
    {
        [Required(ErrorMessage = "please input Goods names")]
        public string? GoodsName { get; set; }

        [Required(ErrorMessage = "Please input Goods price")]
        public double? GoodsPrice { get; set; }

        public double? GoodsDiscount { get; set; }

        [Required(ErrorMessage = "Please select the type Goods")]
        public GoodsTypeOptions? GoodType { get; set; }

        [Required(ErrorMessage = "Please input Goods Description")]
        public string? GoodsDescription { get; set; }

        [Required(ErrorMessage = "Please input store")]
        public StoreOptions? GoodsStore { get; set; }


        public Goods ToGoods()
        {
            return new Goods
            {
                GoodsName = GoodsName,
                GoodsPrice = GoodsPrice,
                GoodsDiscount = GoodsDiscount,
                GoodType = GoodType.ToString(),
                GoodsDescription = GoodsDescription,
                GoodsStore = GoodsStore.ToString(),
            };
        }
    }
}
