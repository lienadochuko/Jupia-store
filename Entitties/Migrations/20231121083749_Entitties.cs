using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Entitties.Migrations
{
    /// <inheritdoc />
    public partial class Entitties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    GoodsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GoodsName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GoodsPrice = table.Column<double>(type: "float", nullable: true),
                    GoodsDiscount = table.Column<double>(type: "float", nullable: true),
                    GoodType = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    GoodsDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    GoodsStore = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.GoodsID);
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "GoodsID", "GoodType", "GoodsDescription", "GoodsDiscount", "GoodsName", "GoodsPrice", "GoodsStore" },
                values: new object[,]
                {
                    { new Guid("0887293c-1d55-46fd-b7ff-6033b62be031"), "BodyWearsMale", "Description", 0.089999999999999997, "Blaine shirt", 900090.0, "GavinStore" },
                    { new Guid("09508eb3-57db-49ce-b368-0a00ffb75828"), "BodyWearsMale", "Description", 0.58999999999999997, "Blaine Glover", 990090.0, "GavinStore" },
                    { new Guid("0f8128d1-9f2a-4656-803e-79bf6de10818"), "Books", "Description", 0.5, "Maureen Grotty", 70000.0, "GraspStore" },
                    { new Guid("1dd4e94b-be3b-4ad4-9a1e-c15ffa625cbb"), "Others", "Description", 0.78000000000000003, "Lethia Laurenceau", 560000.0, "JumStore" },
                    { new Guid("1e00daea-f817-4375-9ec9-a6e6bd48bace"), "JudithStore", "Description", 0.14999999999999999, "Oliver Duigan", 40000.0, "BodyWearsMale" },
                    { new Guid("30da7678-7ccc-4e26-96e6-f3f51f4561f5"), "Mobile", "Description", 0.69999999999999996, "Techno Phantom 6", 60000.0, "Will_Store" },
                    { new Guid("40db2e52-37ab-43c3-8b22-eb24a2084ded"), "Others", "Description", 0.59999999999999998, "Grim Cream", 70000.0, "GraspStore" },
                    { new Guid("6e0a41b7-baf4-4f2b-bace-a654e87c664b"), "Mobile", "Description", 0.29999999999999999, "Techno Phantom 8", 120000.0, "Will_Store" },
                    { new Guid("6ebdef38-3035-4499-ac23-690f9641f448"), "Utensils", "Description", 0.90000000000000002, "VeggieNoodle", 15000.0, "Will_Store" },
                    { new Guid("7680241d-34b8-4f39-b494-87c27831866c"), "BodyWearsMale", "Description", 0.42999999999999999, "Korean shirts", 100000.0, "JudithStore" },
                    { new Guid("84312db0-4672-407d-b212-87e550c74428"), "JudithStore", "Description", 0.14999999999999999, "Olive Oil", 400000.0, "FoodItem" },
                    { new Guid("852e5f08-d85d-43dc-a485-88a7ad445d8b"), "Others", "Description", 0.34000000000000002, "Rosalyn toy", 20000.0, "GraspStore" },
                    { new Guid("8fa6b3e5-5dc4-484c-a6aa-77a95b3bd00f"), "Others", "Description", 0.13, "Keen Matress", 80000.0, "Ayo_Store" },
                    { new Guid("9ce71166-8a69-481d-9c5c-2ea5aac9e73b"), "Others", "Description", 0.40000000000000002, "MortalKombat Game", 98000.0, "GraspStore" },
                    { new Guid("a5386467-0411-44ca-90c8-e3a26b655b94"), "Drinks", "Description", 0.10000000000000001, "PowerHorse", 150000.0, "Will_Store" },
                    { new Guid("a6939d16-ea43-442c-adee-68738a2b39cb"), "Others", "Description", 0.20000000000000001, "Keen Pillows", 20000.0, "Ayo_Store" },
                    { new Guid("b34ad391-adb2-4837-9293-68bccb99b199"), "Others", "Description", 0.40000000000000002, "MickeyMouse Game", 78000.0, "GraspStore" },
                    { new Guid("bc4b49cc-8826-4781-a8fa-d4340b506e2b"), "MobileGadget", "Description", 0.42999999999999999, "Techno BlackBuds", 100000.0, "Makinde_Store" },
                    { new Guid("bf9830c7-8e3d-485c-8fb1-9c7f9652fc75"), "Appliance", "Description", 0.0, "Kessiah Glue", 699980.0, "JumStore" },
                    { new Guid("c9b583ca-eba3-428a-bdcc-c692d086ea61"), "Appliance", "Description", 0.0, "Kessiah Blower", 699980.0, "JumStore" },
                    { new Guid("e801e3c0-7835-4760-9e0b-27078011a2e5"), "FoodItem", "Description", 0.5, "Laurenceau Beans", 56000.0, "Ayo_Store" },
                    { new Guid("ee69e6b7-641c-4abb-80b6-1d3971edc904"), "Godfry_Store", "Description", 0.29999999999999999, "AppleWatch", 80000.0, "Godfry_Store" },
                    { new Guid("f461a9c2-b695-4e47-9113-deec98c91830"), "Mobile", "Description", 0.20000000000000001, "Iphone 14", 60000.0, "Makinde_Store" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Goods");
        }
    }
}
