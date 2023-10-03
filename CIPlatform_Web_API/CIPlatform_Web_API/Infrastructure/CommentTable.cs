using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CIPlatform_Web_API.Infrastructure;

[Table("CommentTable")]
public partial class CommentTable
{
    [Key]
    public int Id { get; set; }

    public int? UserId { get; set; }

    [Column("CommentTable")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CommentTable1 { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("CommentTables")]
    public virtual UserTable? User { get; set; }
}
