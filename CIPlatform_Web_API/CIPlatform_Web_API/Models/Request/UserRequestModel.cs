using CIPlatform_Web_API.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIPlatform_Web_API.Models.Request
{
    public class UserRequestModel
    {
        [Required]
        [StringLength(10)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(10)]
        public string? Surname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string? Password { get; set; }

        [Required]
        public string? ConfirmPassword { get; set; }


        public User ToEntity()
        {
            return new User
            {
               FirstName= this.FirstName,
               Surname= this.Surname,
               Email= this.Email ,
               Password= this.Password ,
               PhoneNumber = this.PhoneNumber
            
            };
        }
    }
}
