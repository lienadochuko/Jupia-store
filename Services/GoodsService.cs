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
        //private readonly List<Goods> _goods;
        //private readonly IUserService _userService;

        private readonly GoodsDbContext _db;

        public GoodsService(GoodsDbContext goodsDbContext, bool initialize = true)
        {
            _db = goodsDbContext;
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
            _db.Add(goods);

            //convert the Goods object into GoodsResponse type
            return ConvertGoodsResponse(goods);
        }

        public bool DeleteGoods(Guid? GoodsID)
        {
            if (GoodsID == null)
                throw new ArgumentNullException(nameof(GoodsID));

            Goods? matchingResponse = _db.Goods.FirstOrDefault(temp => temp.GoodsID == GoodsID);
            if(matchingResponse == null)
            {
                return false;
            }

            //_db.Goods.Remove(_db.Goods.(temp => temp.GoodsID == GoodsID));
            _db.Goods.Remove(matchingResponse);

            return true;
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
                case nameof(GoodsResponse.GoodsName): matchingResponse = allGoods.Where(temp =>
                (!string.IsNullOrEmpty(temp.GoodsName)? temp.GoodsName.Contains(searchString, 
                StringComparison.OrdinalIgnoreCase) : true)).ToList(); 
                    
                    break;

                case nameof(GoodsResponse.GoodsDescription):
                    matchingResponse = allGoods.Where(temp =>
                (!string.IsNullOrEmpty(temp.GoodsDescription) ? temp.GoodsDescription.Contains(searchString,
                StringComparison.OrdinalIgnoreCase) : true)).ToList();

                    break;

                case nameof(GoodsResponse.GoodsPrice):
                    matchingResponse = allGoods.Where(temp =>
                (!string.IsNullOrEmpty(temp.GoodsPrice.ToString()) ? temp.GoodsPrice.ToString().Contains(searchString,
                StringComparison.OrdinalIgnoreCase) : true)).ToList();

                    break;

                case nameof(GoodsResponse.GoodsDiscount):
                    matchingResponse = allGoods.Where(temp =>
                (!string.IsNullOrEmpty(temp.GoodsDiscount.ToString()) ? temp.GoodsDiscount.ToString().Contains(searchString,
                StringComparison.OrdinalIgnoreCase) : true)).ToList();

                    break;

                case nameof(GoodsResponse.GoodType):
                    matchingResponse = allGoods.Where(temp =>
                (!string.IsNullOrEmpty(temp.GoodType) ? temp.GoodType.Contains(searchString,
                StringComparison.OrdinalIgnoreCase) : true)).ToList();

                    break;

                case nameof(GoodsResponse.GoodsStore):
                    matchingResponse = allGoods.Where(temp =>
                (!string.IsNullOrEmpty(temp.GoodsStore) ? temp.GoodsStore.Contains(searchString,
                StringComparison.OrdinalIgnoreCase) : true)).ToList();

                    break;

                default: matchingResponse = allGoods; break;
            }
            return matchingResponse;
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
            return _db.Goods.ToList().Select(goods => ConvertGoodsResponse(goods)).ToList();
        }

        public GoodsResponse? GettGoodsById(Guid GoodsID)
        {
            if (GoodsID == null)
                return null;

            Goods? good = _db.Goods.FirstOrDefault(temp => temp.GoodsID == GoodsID);
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

            Goods? matchingGoods = _db.Goods.FirstOrDefault(temp => temp.GoodsID ==  goodsUpdateResponse.GoodsID);
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