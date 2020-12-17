namespace AutoSchool.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactInformation")]
    public partial class ContactInformation
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Phone { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        public int? CityId { get; set; }

        [StringLength(30)]
        public string Street { get; set; }

        [StringLength(30)]
        public string House { get; set; }

        [StringLength(30)]
        public string Flat { get; set; }

        public int PersonId { get; set; }

        public virtual City City { get; set; }

        public virtual Person Person { get; set; }
    }
}
