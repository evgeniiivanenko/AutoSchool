using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AutoSchool.Context
{
    public partial class AutoSchoolContext : DbContext
    {
        public AutoSchoolContext()
            : base("name=AutoSchoolContext")
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<BranchCategory> BranchCategory { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ContactInformation> ContactInformation { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Lesson> Lesson { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudyClass> StudyClass { get; set; }
        public virtual DbSet<StudyRoom> StudyRoom { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Transport> Transport { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.Cost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Lesson>()
                .HasMany(e => e.Rating)
                .WithRequired(e => e.Lesson)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.Salary)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Rating)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);
        }
    }
}
