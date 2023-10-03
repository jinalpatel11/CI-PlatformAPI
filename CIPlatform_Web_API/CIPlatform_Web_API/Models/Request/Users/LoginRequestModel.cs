using System.ComponentModel.DataAnnotations;

namespace CIPlatform_Web_API.Models.Request.Users
{
    public class LoginRequestModel
    {
        [StringLength(10)]
        public string Password { get; set; }

        public string Emial { get; set; }
    }
}
