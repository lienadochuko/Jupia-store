using System.ComponentModel.DataAnnotations;

namespace Entitties
{
    public class Goods
    {
        [Key]
        public Guid GoodsID { get; set; }

        [StringLength(50)]
        public string? GoodsName { get; set; }

        public double? GoodsPrice { get; set; }

        public double? GoodsDiscount { get; set; }

        [StringLength(80)]
        public string? GoodType { get; set; }

        [StringLength(200)]
        public string? GoodsDescription { get; set; }

        [StringLength(90)]
        public string? GoodsStore { get; set; }
    }
}