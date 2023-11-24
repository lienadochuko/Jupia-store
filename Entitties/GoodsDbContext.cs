using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitties
{
    public class GoodsDbContext : DbContext
    {
        public GoodsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Goods> Goods { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Goods>().ToTable("Goods");

            //seading data
            string goodsJson = System.IO.File.ReadAllText("Goods.json");

            List<Goods> goods= System.Text.Json.JsonSerializer.Deserialize<List<Goods>>(goodsJson);

            foreach (Goods good in goods)
            {
                modelBuilder.Entity<Goods>().HasData(good);
            }
        }

    }
}
