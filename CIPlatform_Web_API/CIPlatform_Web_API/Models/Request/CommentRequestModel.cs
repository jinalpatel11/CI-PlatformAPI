using CIPlatform_Web_API.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIPlatform_Web_API.Models.Request
{
    public class CommentRequestModel
    {


        public int? UserId { get; set; }

        [Column("CommentTable")]
        [StringLength(10)]
        [Unicode(false)]
        public string? CommentTable1 { get; set; }

        public CommentTable ToEntity()
        {
            return new CommentTable { UserId = UserId, CommentTable1 = CommentTable1 };
        }
    }
}
