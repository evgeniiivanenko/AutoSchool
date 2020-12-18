namespace AutoSchool.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentView")]
    public partial class StudentView
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(60)]
        public string FIO { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DateOfBirth { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [StringLength(30)]
        public string Phone { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string CategoryName { get; set; }
    }
}
