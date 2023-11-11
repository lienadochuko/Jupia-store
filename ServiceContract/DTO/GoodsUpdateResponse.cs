using Entitties;
using ServiceContract.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace ServiceContract.DTO
{
    public class GoodsUpdateResponse
    {
        [Required(ErrorMessage = "Please input Goods ID")]
        public Guid GoodsID { get; set; }

        [Required(ErrorMessage = "Please input Goods name")]
        public string? GoodsName { get; set; }

        [Required(ErrorMessage = "Please input Goods price")]
        public double? GoodsPrice { get; set; }

        [Required(ErrorMessage = "Please input Goods discount")]
        public double? GoodsDiscount { get; set; }

        [Required(ErrorMessage = "Please input Goods type")]
        public GoodsTypeOptions? GoodType { get; set; }

        [Required(ErrorMessage = "Please input Goods description")]
        public string? GoodsDescription { get; set; }

        [Required(ErrorMessage = "Please input Goods Store")]
        public StoreOptions? GoodsStore { get; set; }

        public Goods ToGoods()
        {
            return new Goods
            {
                GoodsID = GoodsID,
                GoodsName = GoodsName,
                GoodsPrice = GoodsPrice,
                GoodsDiscount = GoodsDiscount,
                GoodType = GoodType.ToString(),
                GoodsDescription = GoodsDescription,
                GoodsStore = GoodsStore.ToString()
            };
        }
    }
}
