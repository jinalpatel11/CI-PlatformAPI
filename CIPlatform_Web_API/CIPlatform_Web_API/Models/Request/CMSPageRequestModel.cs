using CIPlatform_Web_API.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CIPlatform_Web_API.Models.Request
{
    public class CMSPageRequestModel
    {
        [StringLength(10)]
        [Unicode(false)]
        public string? PageTitle { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? PageDescription { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? Slug { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? Status { get; set; }

        public CmspagesTable ToEntity()
        {
            return new CmspagesTable
            {
                PageDescription = this.PageDescription,
                Slug = this.Slug,
                Status = this.Status,
                PageTitle = this.PageTitle,
            };
        }
    }
}
