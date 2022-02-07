namespace AppPayment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChagdClasses : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DocumentPayments", "DifDeadAndInvDate", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DocumentPayments", "DifDeadAndInvDate");
        }
    }
}
