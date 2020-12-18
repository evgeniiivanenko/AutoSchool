namespace AutoSchool.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment")]
    public partial class Payment
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        [StringLength(60)]
        public string Name { get; set; }

        public DateTime DateOfPayment { get; set; }

        public int StudentId { get; set; }

        [StringLength(60)]
        public string Type { get; set; }

        public virtual Student Student { get; set; }
    }
}
