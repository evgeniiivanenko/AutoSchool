namespace AutoSchool.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BranchCategory")]
    public partial class BranchCategory
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public int BranchId { get; set; }

        public virtual Branch Branch { get; set; }

        public virtual Category Category { get; set; }
    }
}
