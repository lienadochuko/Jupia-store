using Entitties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContract.DTO
{
    public class UserResponse
    {
        public Guid UserID { get; set; }

        public string? UserName { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Gender { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? Password { get; set; }

        public UserUpdateRequest ToUserUpdateRequest()
        {
            return new UserUpdateRequest()
            {
                UserID = UserID,
                UserName = UserName,
                FirstName = FirstName,
                LastName = LastName,
                Gender = Gender,
                Email = Email,
                Phone = Phone,
                Password = Password,
            };
        }
    }

    public static class UserExtension
    {
        /// <summary>
        /// an extension to convert an object of User class into UserResponse class
        /// </summary>
        /// <param name="user">the User object to convert</param>
        /// <returns>Returns the converted UserRespnse object</returns>
        public static UserResponse ToUserResponse(this User user)
        {
            return new UserResponse()
            {
                UserID = user.UserID,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Gender = user.Gender,
                Email = user.Email,
                Phone = user.Phone,
                Password = user.Password,
            };
        }
    }
}
