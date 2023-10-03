using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CIPlatform_Web_API.Infrastructure;

[Table("ContactUsTable")]
public partial class ContactUsTable
{
    [Key]
    public int Id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Name { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? EmailAddress { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Subject { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Message { get; set; }
}
