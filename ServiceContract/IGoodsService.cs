using ServiceContract.Enums;
using ServiceContract.DTO;

namespace ServiceContract
{
    public interface IGoodsService
    {
        /// <summary>
        /// adds a Goods into the list of Goods
        /// </summary>
        /// <param name="goodsAddRequest"></param>
        /// <returns></returns>
        GoodsResponse AddGoods(GoodsAddRequest? goodsAddRequest);

        /// <summary>
        /// Returns all Goods
        /// </summary>
        /// <returns>Returns a list of object of GoodsResponses type</returns>
        List<GoodsResponse> GettAllGoods();

        /// <summary>
        /// Returns the Goods based on the provide ID
        /// </summary>
        /// <param name="GoodsID"></param>
        /// <returns>Returns matching Goods object</returns>
        GoodsResponse? GettGoodsById(Guid GoodsID);

        /// <summary>
        /// Returns sorted list of  filtered Goods based on the searchBy and searchString
        /// </summary>
        /// <param name="searchBy">Search field to search</param> 
        /// <param name="searchString">Search string to search</param>
        /// <returns>Return the list of all Goods object that
        /// matches the given searchBy and search string</returns>
        List<GoodsResponse> GetFilteredGoods(string searchBy, string? searchString);

        /// <summary>
        /// Returns sorted List of Goods
        /// </summary>
        /// <param name="allGoods">Represents the List of Goods to sort</param>
        /// <param name="sortBy">Name of the property(key), based on which the 
        /// list of Goods should be sorted</param>
        /// <param name="sortOrderOptions">AC or DESC</param>
        /// <returns>Returns sorted List of GoodsResponse object</returns>
        List<GoodsResponse> GetSortedGoods(List<GoodsResponse> allGoods, string? sortBy,
            SortOrderOptions sortOrderOptions);

        /// <summary>
        /// updates the specified goods details based on the given Goods ID
        /// </summary>
        /// <param name="goodsUpdateResponse">Goods details to be updated</param>
        /// <returns>Return Goods object after updating</returns>
        GoodsResponse UpdateGoods(GoodsUpdateResponse? goodsUpdateResponse);

        /// <summary>
        /// Delete a Goods base on the provide Goods
        /// </summary>
        /// <param name="GoodsID">GoodsID to delete</param>
        /// <returns>Return true, if deletion is successful esle false</returns>
        bool DeleteGoods(Guid? GoodsID);
    }
}