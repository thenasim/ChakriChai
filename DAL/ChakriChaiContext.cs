using DAL.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ChakriChaiContext : DbContext
    {
        public ChakriChaiContext() : base("name=DbConnectionString")
        {
            var dbCreate = new MigrateDatabaseToLatestVersion<ChakriChaiContext, Configuration>();
            Database.SetInitializer(dbCreate);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Academic> Academics { get; set; }
        public DbSet<Employeer> Employeers { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<JobPost> JobPosts { get; set; }
        public DbSet<Apply> Applies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Apply>()
                .HasRequired(a => a.Employee)
                .WithMany()
                .HasForeignKey(a => a.EmployeeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Apply>()
                .HasRequired(a => a.JobPost)
                .WithMany()
                .HasForeignKey(a => a.JobPostId)
                .WillCascadeOnDelete(false);
        }
    }
}
