using CIPlatform_Web_API.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIPlatform_Web_API.Models.Request
{
    public class StoryRequestModel
    {
        [StringLength(10)]
        [Unicode(false)]
        public string? StoryThumbnail { get; set; }

        public int? MissionId { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? StoryTitle { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? StoryDescription { get; set; }

        public int? UserId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PublishedDate { get; set; }

        [Column("VideoURL")]
        [StringLength(10)]
        [Unicode(false)]
        public string? VideoUrl { get; set; }

        [Column(TypeName = "image")]
        public string StoryPhoto { get; set; }


        public StoryTable ToEntity()
        {
            return new StoryTable
            {
                StoryThumbnail = this.StoryTitle,
                MissionId = this.MissionId,
                StoryTitle = this.StoryThumbnail,
                StoryDescription = this.StoryDescription,
                PublishedDate = this.PublishedDate,
                VideoUrl = this.VideoUrl,
            };
        }
    }
}
