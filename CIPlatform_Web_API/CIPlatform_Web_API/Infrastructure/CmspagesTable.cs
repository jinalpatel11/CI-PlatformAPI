using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIPlatform_Web_API.Infrastructure;

[Table("CMSPagesTable")]
public partial class CmspagesTable
{
    [Key]
    public int Id { get; set; }

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
}
