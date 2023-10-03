using CIPlatform_Web_API.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CIPlatform_Web_API.Models.Request
{
    public class ContactUsRequestModel
    {
        [StringLength(10)]
        [Unicode(false)]
        public string? Name { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? EmailAddress { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? Subject { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? Message { get; set; }

        public ContactUsTable ToEntity()
        {
            return new ContactUsTable
            {
                Name = Name,
                EmailAddress = EmailAddress,
                Subject = Subject,
                Message = Message
            };
        }
    }
}
