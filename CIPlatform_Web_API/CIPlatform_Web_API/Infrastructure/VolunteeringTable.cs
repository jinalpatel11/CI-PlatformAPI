using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CIPlatform_Web_API.Infrastructure;

[Table("VolunteeringTable")]
public partial class VolunteeringTable
{
    [Key]
    public int Id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Mission { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Hours { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Minutes { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DateVolunteered { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Notes { get; set; }

    public int? UserId { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("VolunteeringTables")]
    public virtual UserTable? User { get; set; }
}
