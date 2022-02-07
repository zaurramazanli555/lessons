namespace AppPayment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addstageclas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.DocumentPayments", "Stage_Id", c => c.Int());
            CreateIndex("dbo.DocumentPayments", "Stage_Id");
            AddForeignKey("dbo.DocumentPayments", "Stage_Id", "dbo.Stages", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DocumentPayments", "Stage_Id", "dbo.Stages");
            DropIndex("dbo.DocumentPayments", new[] { "Stage_Id" });
            DropColumn("dbo.DocumentPayments", "Stage_Id");
            DropTable("dbo.Stages");
        }
    }
}
