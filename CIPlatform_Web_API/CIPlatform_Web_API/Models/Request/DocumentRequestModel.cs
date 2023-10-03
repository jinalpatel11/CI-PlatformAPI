using CIPlatform_Web_API.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CIPlatform_Web_API.Models.Request
{
    public class DocumentRequestModel
    {

        public int? UserId { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? DocumentType { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? DocumentValue { get; set; }

        public DocumentTable ToEntity()
        {
            return new DocumentTable
            {
                UserId = this.UserId,
                DocumentType = this.DocumentType,
                DocumentValue = this.DocumentValue
            };
        }
    }
}
