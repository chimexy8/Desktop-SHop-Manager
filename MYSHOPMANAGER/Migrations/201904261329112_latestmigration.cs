namespace MYSHOPMANAGER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class latestmigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SalesDetails", "SalesID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SalesDetails", "SalesID", c => c.Int(nullable: false));
        }
    }
}
