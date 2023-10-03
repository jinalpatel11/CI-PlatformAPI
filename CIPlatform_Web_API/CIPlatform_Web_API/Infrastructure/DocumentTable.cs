using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CIPlatform_Web_API.Infrastructure;

[Table("DocumentTable")]
public partial class DocumentTable
{
    [Key]
    public int Id { get; set; }

    public int? UserId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DocumentType { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DocumentValue { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("DocumentTables")]
    public virtual UserTable? User { get; set; }
}
