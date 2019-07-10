namespace MYSHOPMANAGER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newmigration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sales", "TransactionID", c => c.Double(nullable: false));
            AddColumn("dbo.SalesDetails", "TransactionID", c => c.Double(nullable: false));
            DropColumn("dbo.SalesDetails", "SalesID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SalesDetails", "SalesID", c => c.Int(nullable: false));
            DropColumn("dbo.SalesDetails", "TransactionID");
            DropColumn("dbo.Sales", "TransactionID");
        }
    }
}
