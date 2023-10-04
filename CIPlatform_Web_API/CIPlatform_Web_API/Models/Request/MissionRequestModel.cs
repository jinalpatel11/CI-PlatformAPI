using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CIPlatform_Web_API.Infrastructure;

namespace CIPlatform_Web_API.Models.Request
{
    public class MissionRequestModel
    {
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


        public MissionTable ToEntity()
        {
            return new MissionTable
            {
               CityId = this.CityId,
               CountryId= this.CountryId,
               MissionAvailability  = this.MissionAvailability,
               MissionDescription = this.MissionDescription ,
               MissionDocumnets = this.MissionDocumnets   ,
               MissionEndDate = this.MissionEndDate     ,
               MissionImages = this.MissionImages   ,
               MissionOrganisationDetail = this.MissionOrganisationDetail   ,
               MissionOrganisationName= this.MissionOrganisationName ,
               MissionRegistrationDeadline = this.MissionRegistrationDeadline ,
               MissionSkills= this.MissionSkills ,
               MissionStartDate= this.MissionStartDate ,
               MissionTheme= this.MissionTheme ,
               MissionTitle = this.MissionTitle ,   
               TotalSeats= this.TotalSeats ,
            };
        }
    }
}
