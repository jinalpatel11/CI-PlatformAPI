using CIPlatform_Web_API.Models.Request;
using System.ComponentModel.DataAnnotations;

namespace CIPlatform_Web_API.Models
{
    public class CommentModel : CommentRequestModel
    {

        [Key]
        public int Id { get; set; }
    }
}
