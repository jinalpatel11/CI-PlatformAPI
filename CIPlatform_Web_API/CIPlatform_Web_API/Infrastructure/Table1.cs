using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIPlatform_Web_API.Infrastructure;

[Keyless]
[Table("Table_1")]
public partial class Table1
{
    [Column("fgfd fgdf")]
    [StringLength(10)]
    public string? FgfdFgdf { get; set; }

    [Column("dfgs fdgdf")]
    [StringLength(10)]
    public string? DfgsFdgdf { get; set; }
}
