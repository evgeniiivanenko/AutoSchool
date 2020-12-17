namespace AutoSchool.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lesson")]
    public partial class Lesson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lesson()
        {
            Rating = new HashSet<Rating>();
        }

        public int Id { get; set; }

        public DateTime Time { get; set; }

        public int EmployeeId { get; set; }

        public int StudyRoomId { get; set; }

        public int StudyClassId { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rating> Rating { get; set; }

        public virtual StudyClass StudyClass { get; set; }

        public virtual StudyRoom StudyRoom { get; set; }
    }
}
