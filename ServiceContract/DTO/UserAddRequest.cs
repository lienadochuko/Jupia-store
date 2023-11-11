using Entitties;
using ServiceContract.Enums;
using System.ComponentModel.DataAnnotations;

namespace ServiceContract.DTO
{
    public class UserAddRequest
    {
        [Required(ErrorMessage = "Please input username")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Please input your FirstName")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please input your LastName")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please select your Gender")]
        public GenderTypeOptions? Gender { get; set; }

        [Required(ErrorMessage = "Please input a valid email address")]
        [EmailAddress(ErrorMessage = "Please input a valid email address")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please input a valid phone")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please input a password")]
        public string? Password { get; set; }


        public User ToUser()
        {
            return new User
            {
                UserName = UserName,
                FirstName = FirstName,
                LastName = LastName,
                Gender = Gender.ToString(),
                Email = Email,
                Phone = Phone,
                Password = Password,
            };
        }
    }
}
