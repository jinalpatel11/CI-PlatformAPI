using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CIPlatform_Web_API.Infrastructure;

[Table("Story")]
public partial class Story
{
    [Key]
    public int Id { get; set; }

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

    [StringLength(10)]
    [Unicode(false)]
    public string? StoryPhoto { get; set; }

    public int? Views { get; set; }

    [ForeignKey("MissionId")]
    [InverseProperty("Stories")]
    public virtual Mission? Mission { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("Stories")]
    public virtual User? User { get; set; }
}
