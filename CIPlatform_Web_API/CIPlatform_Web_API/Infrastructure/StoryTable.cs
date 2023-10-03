using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CIPlatform_Web_API.Infrastructure;

[Table("StoryTable")]
public partial class StoryTable
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

    [Column(TypeName = "image")]
    public byte[]? StoryPhoto { get; set; }

    public int? Views { get; set; }

    [ForeignKey("MissionId")]
    [InverseProperty("StoryTables")]
    public virtual MissionTable? Mission { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("StoryTables")]
    public virtual UserTable? User { get; set; }
}
