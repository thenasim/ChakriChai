namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedEnum : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Status", c => c.String());
            AlterColumn("dbo.Users", "Role", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Role", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Status", c => c.Int(nullable: false));
        }
    }
}
