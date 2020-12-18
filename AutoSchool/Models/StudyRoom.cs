namespace AutoSchool.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudyRoom")]
    public partial class StudyRoom
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudyRoom()
        {
            Lesson = new HashSet<Lesson>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Number { get; set; }

        public int? BranchId { get; set; }

        public int NumberOfComputers { get; set; }

        public int NumberOfSeats { get; set; }

        public virtual Branch Branch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lesson> Lesson { get; set; }
    }
}
