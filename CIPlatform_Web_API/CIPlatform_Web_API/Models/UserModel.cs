using CIPlatform_Web_API.Infrastructure;
using CIPlatform_Web_API.Models.Request;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace CIPlatform_Web_API.Models
{
    public class UserModel : UserRequestModel
    {
        public UserModel()
        {
        }

        public UserModel(User tddrive)
        {
            if (tddrive != null)
            {
                Id = tddrive.Id;
            }
        }

        [Key]
        public int Id { get; set; }

    }
}
