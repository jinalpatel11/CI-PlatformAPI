using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CIPlatform_Web_API.Infrastructure;

[Table("User")]
public partial class User
{
    [Key]
    public int Id { get; set; }

    [StringLength(10)]
    public string? Status { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Image { get; set; }

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

    [Column("EmployeeID")]
    [StringLength(10)]
    [Unicode(false)]
    public string? EmployeeId { get; set; }

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

    [StringLength(10)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PhoneNumber { get; set; }
}
