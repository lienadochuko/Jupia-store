using Entitties;
using ServiceContract.Enums;
using System.ComponentModel.DataAnnotations;

namespace ServiceContract.DTO
{
    public class GoodsResponse
    {
        public Guid GoodsID { get; set; }

        public string? GoodsName { get; set; }

        public double? GoodsPrice { get; set; }

        public double? GoodsDiscount { get; set; }

        public double? AfterDiscountPrice { get; set; }

        public string? GoodType { get; set; }

        public string? GoodsDescription { get; set; }

        public string? GoodsStore { get; set; }

        public GoodsUpdateResponse ToGoodsUpdateResponse()
        {
            return new GoodsUpdateResponse()
            {
                GoodsID = GoodsID,
                GoodsName = GoodsName,
                GoodsPrice = GoodsPrice,
                GoodsDiscount = GoodsDiscount,
                GoodType = (GoodsTypeOptions)Enum.Parse(typeof(GoodsTypeOptions), GoodType, true),
                GoodsDescription = GoodsDescription,
                GoodsStore = (StoreOptions)Enum.Parse(typeof(StoreOptions), GoodType, true),
            };
        }

    }
    public static class GoodsExtension
    {
        /// <summary>
        /// An extension method to convert an object of Goods class into GoodsResponse class
        /// </summary>
        /// <param name="goods">the goods object to convert</param>
        /// <returns>Returns the converted GoodsResponse object</returns>
        public static GoodsResponse ToGoodsResponse(this Goods goods)
        {
            return new GoodsResponse
            {
                GoodsID = goods.GoodsID,
                GoodsName = goods.GoodsName,
                GoodsPrice = goods.GoodsPrice,
                AfterDiscountPrice = (goods.GoodsDiscount <= 0) ? goods.GoodsPrice : goods.GoodsPrice * goods.GoodsDiscount,
                GoodType = goods.GoodType,
                GoodsDiscount = goods.GoodsDiscount,
                GoodsDescription = goods.GoodsDescription,
                GoodsStore = goods.GoodsStore,
            };
        }
    }
}
