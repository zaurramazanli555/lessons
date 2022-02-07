namespace AppPayment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Vendoraddcolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vendors", "TestName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vendors", "TestName");
        }
    }
}
