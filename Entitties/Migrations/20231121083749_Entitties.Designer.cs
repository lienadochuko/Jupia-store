﻿// <auto-generated />
using System;
using Entitties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entitties.Migrations
{
    [DbContext(typeof(GoodsDbContext))]
    [Migration("20231121083749_Entitties")]
    partial class Entitties
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entitties.Goods", b =>
                {
                    b.Property<Guid>("GoodsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GoodType")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("GoodsDescription")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<double?>("GoodsDiscount")
                        .HasColumnType("float");

                    b.Property<string>("GoodsName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("GoodsPrice")
                        .HasColumnType("float");

                    b.Property<string>("GoodsStore")
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.HasKey("GoodsID");

                    b.ToTable("Goods", (string)null);

                    b.HasData(
                        new
                        {
                            GoodsID = new Guid("f461a9c2-b695-4e47-9113-deec98c91830"),
                            GoodType = "Mobile",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.20000000000000001,
                            GoodsName = "Iphone 14",
                            GoodsPrice = 60000.0,
                            GoodsStore = "Makinde_Store"
                        },
                        new
                        {
                            GoodsID = new Guid("ee69e6b7-641c-4abb-80b6-1d3971edc904"),
                            GoodType = "Godfry_Store",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.29999999999999999,
                            GoodsName = "AppleWatch",
                            GoodsPrice = 80000.0,
                            GoodsStore = "Godfry_Store"
                        },
                        new
                        {
                            GoodsID = new Guid("6ebdef38-3035-4499-ac23-690f9641f448"),
                            GoodType = "Utensils",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.90000000000000002,
                            GoodsName = "VeggieNoodle",
                            GoodsPrice = 15000.0,
                            GoodsStore = "Will_Store"
                        },
                        new
                        {
                            GoodsID = new Guid("a5386467-0411-44ca-90c8-e3a26b655b94"),
                            GoodType = "Drinks",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.10000000000000001,
                            GoodsName = "PowerHorse",
                            GoodsPrice = 150000.0,
                            GoodsStore = "Will_Store"
                        },
                        new
                        {
                            GoodsID = new Guid("1e00daea-f817-4375-9ec9-a6e6bd48bace"),
                            GoodType = "JudithStore",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.14999999999999999,
                            GoodsName = "Oliver Duigan",
                            GoodsPrice = 40000.0,
                            GoodsStore = "BodyWearsMale"
                        },
                        new
                        {
                            GoodsID = new Guid("84312db0-4672-407d-b212-87e550c74428"),
                            GoodType = "JudithStore",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.14999999999999999,
                            GoodsName = "Olive Oil",
                            GoodsPrice = 400000.0,
                            GoodsStore = "FoodItem"
                        },
                        new
                        {
                            GoodsID = new Guid("c9b583ca-eba3-428a-bdcc-c692d086ea61"),
                            GoodType = "Appliance",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.0,
                            GoodsName = "Kessiah Blower",
                            GoodsPrice = 699980.0,
                            GoodsStore = "JumStore"
                        },
                        new
                        {
                            GoodsID = new Guid("bf9830c7-8e3d-485c-8fb1-9c7f9652fc75"),
                            GoodType = "Appliance",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.0,
                            GoodsName = "Kessiah Glue",
                            GoodsPrice = 699980.0,
                            GoodsStore = "JumStore"
                        },
                        new
                        {
                            GoodsID = new Guid("852e5f08-d85d-43dc-a485-88a7ad445d8b"),
                            GoodType = "Others",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.34000000000000002,
                            GoodsName = "Rosalyn toy",
                            GoodsPrice = 20000.0,
                            GoodsStore = "GraspStore"
                        },
                        new
                        {
                            GoodsID = new Guid("0887293c-1d55-46fd-b7ff-6033b62be031"),
                            GoodType = "BodyWearsMale",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.089999999999999997,
                            GoodsName = "Blaine shirt",
                            GoodsPrice = 900090.0,
                            GoodsStore = "GavinStore"
                        },
                        new
                        {
                            GoodsID = new Guid("09508eb3-57db-49ce-b368-0a00ffb75828"),
                            GoodType = "BodyWearsMale",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.58999999999999997,
                            GoodsName = "Blaine Glover",
                            GoodsPrice = 990090.0,
                            GoodsStore = "GavinStore"
                        },
                        new
                        {
                            GoodsID = new Guid("0f8128d1-9f2a-4656-803e-79bf6de10818"),
                            GoodType = "Books",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.5,
                            GoodsName = "Maureen Grotty",
                            GoodsPrice = 70000.0,
                            GoodsStore = "GraspStore"
                        },
                        new
                        {
                            GoodsID = new Guid("40db2e52-37ab-43c3-8b22-eb24a2084ded"),
                            GoodType = "Others",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.59999999999999998,
                            GoodsName = "Grim Cream",
                            GoodsPrice = 70000.0,
                            GoodsStore = "GraspStore"
                        },
                        new
                        {
                            GoodsID = new Guid("1dd4e94b-be3b-4ad4-9a1e-c15ffa625cbb"),
                            GoodType = "Others",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.78000000000000003,
                            GoodsName = "Lethia Laurenceau",
                            GoodsPrice = 560000.0,
                            GoodsStore = "JumStore"
                        },
                        new
                        {
                            GoodsID = new Guid("e801e3c0-7835-4760-9e0b-27078011a2e5"),
                            GoodType = "FoodItem",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.5,
                            GoodsName = "Laurenceau Beans",
                            GoodsPrice = 56000.0,
                            GoodsStore = "Ayo_Store"
                        },
                        new
                        {
                            GoodsID = new Guid("30da7678-7ccc-4e26-96e6-f3f51f4561f5"),
                            GoodType = "Mobile",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.69999999999999996,
                            GoodsName = "Techno Phantom 6",
                            GoodsPrice = 60000.0,
                            GoodsStore = "Will_Store"
                        },
                        new
                        {
                            GoodsID = new Guid("6e0a41b7-baf4-4f2b-bace-a654e87c664b"),
                            GoodType = "Mobile",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.29999999999999999,
                            GoodsName = "Techno Phantom 8",
                            GoodsPrice = 120000.0,
                            GoodsStore = "Will_Store"
                        },
                        new
                        {
                            GoodsID = new Guid("bc4b49cc-8826-4781-a8fa-d4340b506e2b"),
                            GoodType = "MobileGadget",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.42999999999999999,
                            GoodsName = "Techno BlackBuds",
                            GoodsPrice = 100000.0,
                            GoodsStore = "Makinde_Store"
                        },
                        new
                        {
                            GoodsID = new Guid("7680241d-34b8-4f39-b494-87c27831866c"),
                            GoodType = "BodyWearsMale",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.42999999999999999,
                            GoodsName = "Korean shirts",
                            GoodsPrice = 100000.0,
                            GoodsStore = "JudithStore"
                        },
                        new
                        {
                            GoodsID = new Guid("8fa6b3e5-5dc4-484c-a6aa-77a95b3bd00f"),
                            GoodType = "Others",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.13,
                            GoodsName = "Keen Matress",
                            GoodsPrice = 80000.0,
                            GoodsStore = "Ayo_Store"
                        },
                        new
                        {
                            GoodsID = new Guid("a6939d16-ea43-442c-adee-68738a2b39cb"),
                            GoodType = "Others",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.20000000000000001,
                            GoodsName = "Keen Pillows",
                            GoodsPrice = 20000.0,
                            GoodsStore = "Ayo_Store"
                        },
                        new
                        {
                            GoodsID = new Guid("b34ad391-adb2-4837-9293-68bccb99b199"),
                            GoodType = "Others",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.40000000000000002,
                            GoodsName = "MickeyMouse Game",
                            GoodsPrice = 78000.0,
                            GoodsStore = "GraspStore"
                        },
                        new
                        {
                            GoodsID = new Guid("9ce71166-8a69-481d-9c5c-2ea5aac9e73b"),
                            GoodType = "Others",
                            GoodsDescription = "Description",
                            GoodsDiscount = 0.40000000000000002,
                            GoodsName = "MortalKombat Game",
                            GoodsPrice = 98000.0,
                            GoodsStore = "GraspStore"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
