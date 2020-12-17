namespace AutoSchool.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transport")]
    public partial class Transport
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Brand { get; set; }

        [Required]
        [StringLength(60)]
        public string Model { get; set; }

        [Required]
        [StringLength(10)]
        public string Nubmer { get; set; }

        public int YearOfManufacture { get; set; }

        public int DateOfInspection { get; set; }

        public int DateEndOfInspection { get; set; }

        public int EmployeeId { get; set; }

        public bool? IsServiceable { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
