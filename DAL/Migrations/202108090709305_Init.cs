namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Academics",
                c => new
                    {
                        AcademicId = c.Int(nullable: false, identity: true),
                        InstituteName = c.String(),
                        PassedYear = c.DateTime(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        ExamId = c.Int(nullable: false),
                        BoardId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AcademicId)
                .ForeignKey("dbo.Boards", t => t.BoardId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Exams", t => t.ExamId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.ExamId)
                .Index(t => t.BoardId);
            
            CreateTable(
                "dbo.Boards",
                c => new
                    {
                        BoardId = c.Int(nullable: false, identity: true),
                        BoardName = c.String(),
                    })
                .PrimaryKey(t => t.BoardId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Applies",
                c => new
                    {
                        ApplyId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        JobPostId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        JobPost_JobPostId = c.Int(),
                        Employee_EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.ApplyId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .ForeignKey("dbo.JobPosts", t => t.JobPost_JobPostId)
                .ForeignKey("dbo.JobPosts", t => t.JobPostId)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeId)
                .Index(t => t.JobPostId)
                .Index(t => t.EmployeeId)
                .Index(t => t.JobPost_JobPostId)
                .Index(t => t.Employee_EmployeeId);
            
            CreateTable(
                "dbo.JobPosts",
                c => new
                    {
                        JobPostId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        DeadLine = c.DateTime(nullable: false),
                        Vacancies = c.Int(nullable: false),
                        SalaryMin = c.Double(nullable: false),
                        SalaryMax = c.Double(nullable: false),
                        EmployeerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.JobPostId)
                .ForeignKey("dbo.Employeers", t => t.EmployeerId, cascadeDelete: true)
                .Index(t => t.EmployeerId);
            
            CreateTable(
                "dbo.Employeers",
                c => new
                    {
                        EmployeerId = c.Int(nullable: false, identity: true),
                        Organization = c.String(),
                        YearEstablishment = c.DateTime(nullable: false),
                        CompanySize = c.Int(nullable: false),
                        OrganizationType = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeerId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        ExamId = c.Int(nullable: false, identity: true),
                        ExamName = c.String(),
                    })
                .PrimaryKey(t => t.ExamId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Academics", "ExamId", "dbo.Exams");
            DropForeignKey("dbo.Applies", "Employee_EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Applies", "JobPostId", "dbo.JobPosts");
            DropForeignKey("dbo.Employees", "UserId", "dbo.Users");
            DropForeignKey("dbo.Employeers", "UserId", "dbo.Users");
            DropForeignKey("dbo.JobPosts", "EmployeerId", "dbo.Employeers");
            DropForeignKey("dbo.Applies", "JobPost_JobPostId", "dbo.JobPosts");
            DropForeignKey("dbo.Applies", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Academics", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Academics", "BoardId", "dbo.Boards");
            DropIndex("dbo.Employeers", new[] { "UserId" });
            DropIndex("dbo.JobPosts", new[] { "EmployeerId" });
            DropIndex("dbo.Applies", new[] { "Employee_EmployeeId" });
            DropIndex("dbo.Applies", new[] { "JobPost_JobPostId" });
            DropIndex("dbo.Applies", new[] { "EmployeeId" });
            DropIndex("dbo.Applies", new[] { "JobPostId" });
            DropIndex("dbo.Employees", new[] { "UserId" });
            DropIndex("dbo.Academics", new[] { "BoardId" });
            DropIndex("dbo.Academics", new[] { "ExamId" });
            DropIndex("dbo.Academics", new[] { "EmployeeId" });
            DropTable("dbo.Exams");
            DropTable("dbo.Users");
            DropTable("dbo.Employeers");
            DropTable("dbo.JobPosts");
            DropTable("dbo.Applies");
            DropTable("dbo.Employees");
            DropTable("dbo.Boards");
            DropTable("dbo.Academics");
        }
    }
}
