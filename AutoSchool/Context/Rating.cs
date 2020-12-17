namespace AutoSchool.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Rating")]
    public partial class Rating
    {
        public int Id { get; set; }

        public int NumberOfTest { get; set; }

        public bool Passed { get; set; }

        public int LessonId { get; set; }

        public int StudentId { get; set; }

        public virtual Lesson Lesson { get; set; }

        public virtual Student Student { get; set; }
    }
}
