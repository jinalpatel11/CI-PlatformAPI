using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIPlatform_Web_API.Infrastructure;

[Table("Mission")]
public partial class Mission
{
    [Key]
    public int Id { get; set; }

    public int? CountryId { get; set; }

    public int? CityId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MissionTitle { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MissionDescription { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MissionOrganisationName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MissionOrganisationDetail { get; set; }

    [Column(TypeName = "date")]
    public DateTime? MissionStartDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime? MissionEndDate { get; set; }

    public int? TotalSeats { get; set; }

    [Column(TypeName = "date")]
    public DateTime? MissionRegistrationDeadline { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MissionTheme { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MissionSkills { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MissionImages { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MissionDocumnets { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MissionAvailability { get; set; }

    [InverseProperty("Mission")]
    public virtual ICollection<Story> Stories { get; set; } = new List<Story>();
}
