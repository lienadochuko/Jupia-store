using Entitties;
using ServiceContract;
using ServiceContract.DTO;
using ServiceContract.Enums;
using System;
using static System.Reflection.Metadata.BlobBuilder;
using System.Reflection;
using Services.Helpers;

namespace Services
{
    public class GoodsService : IGoodsService
    {
        private readonly List<Goods> _goods;
        //private readonly IUserService _userService;

        public GoodsService(bool initialize = true)
        {
            _goods = new List<Goods>();

            if (initialize)
            {
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("F461A9C2-B695-4E47-9113-DEEC98C91830"),
                    GoodsName = "Iphone 14",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.2,
                    GoodsPrice= 60000,
                    GoodsStore = "Makinde_Store",
                    GoodType = "Mobile",
                });

                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("EE69E6B7-641C-4ABB-80B6-1D3971EDC904"),
                    GoodsName = "AppleWatch",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.30,
                    GoodsPrice = 80000,
                    GoodType = "Godfry_Store",
                    GoodsStore = "Godfry_Store",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("6EBDEF38-3035-4499-AC23-690F9641F448"),
                    GoodsName = "VeggieNoodle",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.90,
                    GoodsPrice = 15000,
                    GoodType = "Utensils",
                    GoodsStore = "Will_Store",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("A5386467-0411-44CA-90C8-E3A26B655B94"),
                    GoodsName = "PowerHorse",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.10,
                    GoodsPrice = 150000,
                    GoodType = "Drinks",
                    GoodsStore = "Will_Store",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("1E00DAEA-F817-4375-9EC9-A6E6BD48BACE"),
                    GoodsName = "Oliver Duigan",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.15,
                    GoodsPrice = 40000,
                    GoodType = "JudithStore",
                    GoodsStore = "BodyWearsMale",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("84312DB0-4672-407D-B212-87E550C74428"),
                    GoodsName = "Olive Oil",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.15,
                    GoodsPrice = 400000,
                    GoodType = "JudithStore",
                    GoodsStore = "FoodItem",

                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("C9B583CA-EBA3-428A-BDCC-C692D086EA61"),
                    GoodsName = "Kessiah Blower",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.00, 
                    GoodsPrice = 699980,
                    GoodType = "Appliance",
                    GoodsStore = "JumStore",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("BF9830C7-8E3D-485C-8FB1-9C7F9652FC75"),
                    GoodsName = "Kessiah Glue",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.00, 
                    GoodsPrice = 699980,
                    GoodType = "Appliance",
                    GoodsStore = "JumStore",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("852E5F08-D85D-43DC-A485-88A7AD445D8B"),
                    GoodsName = "Rosalyn toy",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.34,
                    GoodsPrice = 20000,
                    GoodType = "Others",
                    GoodsStore = "GraspStore",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("0887293C-1D55-46FD-B7FF-6033B62BE031"),
                    GoodsName = "Blaine shirt",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.09,
                    GoodsPrice = 900090,
                    GoodType = "BodyWearsMale",
                    GoodsStore = "GavinStore",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("09508EB3-57DB-49CE-B368-0A00FFB75828"),
                    GoodsName = "Blaine Glover",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.59,
                    GoodsPrice = 990090,
                    GoodType = "BodyWearsMale",
                    GoodsStore = "GavinStore",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("0F8128D1-9F2A-4656-803E-79BF6DE10818"),
                    GoodsName = "Maureen Grotty",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.5,
                    GoodsPrice = 70000,
                    GoodType = "Books",
                    GoodsStore = "GraspStore",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("40DB2E52-37AB-43C3-8B22-EB24A2084DED"),
                    GoodsName = "Grim Cream",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.6,
                    GoodsPrice = 70000,
                    GoodType = "Others",
                    GoodsStore = "GraspStore",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("1DD4E94B-BE3B-4AD4-9A1E-C15FFA625CBB"),
                    GoodsName = "Lethia Laurenceau",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.78,
                    GoodsPrice = 560000,
                    GoodType = "Others",
                    GoodsStore = "JumStore",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("E801E3C0-7835-4760-9E0B-27078011A2E5"),
                    GoodsName = "Laurenceau Beans",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.5,
                    GoodsPrice = 56000,
                    GoodType = "FoodItem",
                    GoodsStore = "Ayo_Store",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("30DA7678-7CCC-4E26-96E6-F3F51F4561F5"),
                    GoodsName = "Techno Phantom 6",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.7,
                    GoodsPrice = 60000,
                    GoodsStore = "Will_Store",
                    GoodType = "Mobile",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("6E0A41B7-BAF4-4F2B-BACE-A654E87C664B"),
                    GoodsName = "Techno Phantom 8",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.3,
                    GoodsPrice = 120000,
                    GoodsStore = "Will_Store",
                    GoodType = "Mobile",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("BC4B49CC-8826-4781-A8FA-D4340B506E2B"),
                    GoodsName = "Techno BlackBuds",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.43,
                    GoodsPrice = 100000,
                    GoodsStore = "Makinde_Store",
                    GoodType = "MobileGadget",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("7680241D-34B8-4F39-B494-87C27831866C"),
                    GoodsName = "Korean shirts",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.43,
                    GoodsPrice = 100000,
                    GoodsStore = "JudithStore",
                    GoodType = "BodyWearsMale",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("8FA6B3E5-5DC4-484C-A6AA-77A95B3BD00F"),
                    GoodsName = "Keen Matress",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.13,
                    GoodsPrice = 80000,
                    GoodsStore = "Ayo_Store",
                    GoodType = "Others",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("A6939D16-EA43-442C-ADEE-68738A2B39CB"),
                    GoodsName = "Keen Pillows",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.2,
                    GoodsPrice = 20000,
                    GoodsStore = "Ayo_Store",
                    GoodType = "Others",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("B34AD391-ADB2-4837-9293-68BCCB99B199"),
                    GoodsName = "MickeyMouse Game",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.40,
                    GoodsPrice = 78000,
                    GoodsStore = "GraspStore",
                    GoodType = "Others",
                });
                _goods.Add(new Goods()
                {
                    GoodsID = Guid.Parse("9CE71166-8A69-481D-9C5C-2EA5AAC9E73B"),
                    GoodsName = "MortalKombat Game",
                    GoodsDescription = "Description",
                    GoodsDiscount = 0.40,
                    GoodsPrice = 98000,
                    GoodsStore = "GraspStore",
                    GoodType = "Others",
                });
            }
        }

        private GoodsResponse ConvertGoodsResponse(Goods goods)
        {
            GoodsResponse goodsResponse = goods.ToGoodsResponse();

            return goodsResponse;
        }

        public GoodsResponse AddGoods(GoodsAddRequest? goodsAddRequest)
        {
            if (goodsAddRequest == null)
            {
                throw new ArgumentNullException(nameof(goodsAddRequest));
            }

            //Model validation
            ValidationHelpers.ModelValidation(goodsAddRequest);

            //Convert from GoodsAddRequest obj to Goods obj
            Goods goods = goodsAddRequest.ToGoods();

            //generate GoodsID
            goods.GoodsID = Guid.NewGuid();

            //add person to Goods list
            _goods.Add(goods);

            //convert the Goods object into GoodsResponse type
            return ConvertGoodsResponse(goods);
        }

        public bool DeleteGoods(Guid? GoodsID)
        {
            throw new NotImplementedException();
        }

        public List<GoodsResponse> GetFilteredGoods(string searchBy, string? searchString)
        {
            List<GoodsResponse> allGoods = GettAllGoods();
            List<GoodsResponse> matchingResponse = allGoods;

            if(string.IsNullOrEmpty(searchBy) || string.IsNullOrEmpty(searchString))
            {
                return matchingResponse;
            }

            switch(searchBy)
            {
                case nameof(GoodsResponse.GoodsName)
            }
        }

        public List<GoodsResponse> GetSortedGoods(List<GoodsResponse> allGoods, string? sortBy, SortOrderOptions sortOrderOptions)
        {
            if(string.IsNullOrEmpty(sortBy))
                return allGoods;

            List<GoodsResponse> sortedGoods = (sortBy, sortOrderOptions)
                switch
            {
                (nameof(GoodsResponse.GoodsName), SortOrderOptions.ASC) =>
                allGoods.OrderBy(temp => temp.GoodsName, StringComparer.OrdinalIgnoreCase).ToList(),

                (nameof(GoodsResponse.GoodsName), SortOrderOptions.DESC) =>
                allGoods.OrderByDescending(temp => temp.GoodsName, StringComparer.OrdinalIgnoreCase).ToList(),


                (nameof(GoodsResponse.GoodsDescription), SortOrderOptions.ASC) =>
                allGoods.OrderBy(temp => temp.GoodsDescription, StringComparer.OrdinalIgnoreCase).ToList(),

                (nameof(GoodsResponse.GoodsDescription), SortOrderOptions.DESC) =>
                allGoods.OrderByDescending(temp => temp.GoodsDescription, StringComparer.OrdinalIgnoreCase).ToList(),


                (nameof(GoodsResponse.GoodsPrice), SortOrderOptions.ASC) =>
                allGoods.OrderBy(temp => temp.GoodsPrice.ToString(), StringComparer.OrdinalIgnoreCase ).ToList(),

                (nameof(GoodsResponse.GoodsPrice), SortOrderOptions.DESC) =>
                allGoods.OrderByDescending(temp => temp.GoodsPrice.ToString(), StringComparer.OrdinalIgnoreCase).ToList(),


                (nameof(GoodsResponse.GoodsDiscount), SortOrderOptions.ASC) =>
                allGoods.OrderBy(temp => temp.GoodsDiscount.ToString(), StringComparer.OrdinalIgnoreCase).ToList(),

                (nameof(GoodsResponse.GoodsDiscount), SortOrderOptions.DESC) =>
                allGoods.OrderByDescending(temp => temp.GoodsDiscount.ToString(), StringComparer.OrdinalIgnoreCase).ToList(),


                (nameof(GoodsResponse.GoodType), SortOrderOptions.ASC) =>
                allGoods.OrderBy(temp => temp.GoodType, StringComparer.OrdinalIgnoreCase).ToList(),

                (nameof(GoodsResponse.GoodType), SortOrderOptions.DESC) =>
                allGoods.OrderByDescending(temp => temp.GoodType, StringComparer.OrdinalIgnoreCase).ToList(),


                (nameof(GoodsResponse.GoodsStore), SortOrderOptions.ASC) =>
                allGoods.OrderBy(temp => temp.GoodsStore, StringComparer.OrdinalIgnoreCase).ToList(),

                (nameof(GoodsResponse.GoodsStore), SortOrderOptions.DESC) =>
                allGoods.OrderByDescending(temp => temp.GoodsStore, StringComparer.OrdinalIgnoreCase).ToList(),

                _=> allGoods
            };

            return sortedGoods;
        }

        public List<GoodsResponse> GettAllGoods()
        {
            return _goods.Select(goods => ConvertGoodsResponse(goods)).ToList();
        }

        public GoodsResponse? GettGoodsById(Guid GoodsID)
        {
            if (GoodsID == null)
                return null;

            Goods? good = _goods.FirstOrDefault(temp => temp.GoodsID == GoodsID);
            if(good == null)
                return null;

            return ConvertGoodsResponse(good);
        }

        public GoodsResponse UpdateGoods(GoodsUpdateResponse? goodsUpdateResponse)
        {
            if (goodsUpdateResponse == null)
                throw new ArgumentNullException(nameof(goodsUpdateResponse));

            //Validation
            ValidationHelpers.ModelValidation(goodsUpdateResponse);

            if(goodsUpdateResponse.GoodsID == new Guid())
                throw new ArgumentNullException(nameof(goodsUpdateResponse.GoodsID));

            Goods? matchingGoods = _goods.FirstOrDefault(temp => temp.GoodsID ==  goodsUpdateResponse.GoodsID);
            if (matchingGoods == null)
            {
                throw new ArgumentException("Given GoodsID does not exists");
            }

            //update all details
            matchingGoods.GoodsName = goodsUpdateResponse.GoodsName;
            matchingGoods.GoodsDiscount = goodsUpdateResponse.GoodsDiscount;
            matchingGoods.GoodsPrice = goodsUpdateResponse.GoodsPrice;
            matchingGoods.GoodsDescription = goodsUpdateResponse.GoodsDescription;
            matchingGoods.GoodType = goodsUpdateResponse?.GoodType.ToString();
            matchingGoods.GoodsStore = goodsUpdateResponse.GoodsStore.ToString();


            return ConvertGoodsResponse(matchingGoods);

        }
    }
}