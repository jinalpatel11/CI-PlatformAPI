﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CIPlatform_Web_API.Infrastructure;

namespace CIPlatform_Web_API.Models.Request
{
    public class VolunteeringRequestModel
    {

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

        public VolunteeringTable ToEntity()
        {
            return new VolunteeringTable
            {
                Mission = this.Mission,
                Hours = this.Hours,
                Minutes = this.Minutes,
                DateVolunteered = this.DateVolunteered,
                Notes = this.Notes,
                UserId = this.UserId
            };
        }
    }
}
