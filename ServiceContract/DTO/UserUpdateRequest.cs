using Entitties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContract.DTO
{
    public class UserUpdateRequest
    {
        [Required(ErrorMessage = "Please input User Guid")]
        public Guid UserID { get; set; }

        [Required(ErrorMessage = "Please input username")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Please input FirstName")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please input LastName")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please input select Gender")]
        public string? Gender { get; set; }

        [Required(ErrorMessage = "Please input email address")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please input phone number")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please input password")]
        public string? Password { get; set; }

        public User ToUser()
        {
            return new User()
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
}
