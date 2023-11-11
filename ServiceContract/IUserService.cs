using ServiceContract.DTO;

namespace ServiceContract
{
    public interface IUserService
    {
        /// <summary>
        /// Add a new user to the list of Users
        /// </summary>
        /// <param name="userAddRequest">user object to add</param>
        /// <returns>Returns the User object after adding it</returns>
        UserResponse AddUser(UserAddRequest? userAddRequest);

        /// <summary>
        /// Returns a list of all users
        /// </summary>
        /// <returns>All users from the list as a list of UserResponse</returns>
        List<UserResponse> GetUsers();

        UserResponse? GetUserByUserName(string? username);
    }
}
