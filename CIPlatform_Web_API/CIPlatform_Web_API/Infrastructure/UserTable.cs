using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIPlatform_Web_API.Infrastructure;

[Table("UserTable")]
public partial class UserTable
{
    [Key]
    public int Id { get; set; }

    public int? Status { get; set; }

    [Column(TypeName = "image")]
    public byte[]? Image { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Password { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Surname { get; set; }

    public int? EmployeeId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Title { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Department { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ProfileSummary { get; set; }

    [Column("WhyIVolunteer")]
    [StringLength(10)]
    [Unicode(false)]
    public string? WhyIvolunteer { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Country { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Availability { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MySkills { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<CommentTable> CommentTables { get; set; } = new List<CommentTable>();

    [InverseProperty("User")]
    public virtual ICollection<DocumentTable> DocumentTables { get; set; } = new List<DocumentTable>();

    [InverseProperty("User")]
    public virtual ICollection<VolunteeringTable> VolunteeringTables { get; set; } = new List<VolunteeringTable>();
}
