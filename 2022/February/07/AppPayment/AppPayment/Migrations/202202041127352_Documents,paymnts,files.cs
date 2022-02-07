namespace AppPayment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Documentspaymntsfiles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DocumentPayments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DocumentNumber = c.String(),
                        DocumentName = c.String(),
                        InvoiceNumber = c.String(),
                        InvoiceDate = c.DateTime(nullable: false),
                        Deadline = c.DateTime(nullable: false),
                        Note = c.String(),
                        Qeyd = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CurrrencyCode = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentTypeId = c.Int(nullable: false),
                        EditDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Company_Id = c.Int(),
                        CreateUser_Id = c.Int(),
                        Department_Id = c.Int(),
                        Destinition_Id = c.Int(),
                        DocumentStatus_Id = c.Int(),
                        PaymentStatus_Id = c.Int(),
                        Vendor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .ForeignKey("dbo.Users", t => t.CreateUser_Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id)
                .ForeignKey("dbo.Destinitions", t => t.Destinition_Id)
                .ForeignKey("dbo.DocumentStatus", t => t.DocumentStatus_Id)
                .ForeignKey("dbo.PaymentStatus", t => t.PaymentStatus_Id)
                .ForeignKey("dbo.Vendors", t => t.Vendor_Id)
                .Index(t => t.Company_Id)
                .Index(t => t.CreateUser_Id)
                .Index(t => t.Department_Id)
                .Index(t => t.Destinition_Id)
                .Index(t => t.DocumentStatus_Id)
                .Index(t => t.PaymentStatus_Id)
                .Index(t => t.Vendor_Id);
            
            CreateTable(
                "dbo.FileClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        URL = c.String(),
                        DocumentPayment_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DocumentPayments", t => t.DocumentPayment_Id)
                .Index(t => t.DocumentPayment_Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        PaidDate = c.DateTime(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentType = c.String(),
                        ReferenceNo = c.String(),
                        DocumentPayment_Id = c.Int(),
                        UserId_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DocumentPayments", t => t.DocumentPayment_Id)
                .ForeignKey("dbo.Users", t => t.UserId_Id)
                .Index(t => t.DocumentPayment_Id)
                .Index(t => t.UserId_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "UserId_Id", "dbo.Users");
            DropForeignKey("dbo.Payments", "DocumentPayment_Id", "dbo.DocumentPayments");
            DropForeignKey("dbo.FileClasses", "DocumentPayment_Id", "dbo.DocumentPayments");
            DropForeignKey("dbo.DocumentPayments", "Vendor_Id", "dbo.Vendors");
            DropForeignKey("dbo.DocumentPayments", "PaymentStatus_Id", "dbo.PaymentStatus");
            DropForeignKey("dbo.DocumentPayments", "DocumentStatus_Id", "dbo.DocumentStatus");
            DropForeignKey("dbo.DocumentPayments", "Destinition_Id", "dbo.Destinitions");
            DropForeignKey("dbo.DocumentPayments", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.DocumentPayments", "CreateUser_Id", "dbo.Users");
            DropForeignKey("dbo.DocumentPayments", "Company_Id", "dbo.Companies");
            DropIndex("dbo.Payments", new[] { "UserId_Id" });
            DropIndex("dbo.Payments", new[] { "DocumentPayment_Id" });
            DropIndex("dbo.FileClasses", new[] { "DocumentPayment_Id" });
            DropIndex("dbo.DocumentPayments", new[] { "Vendor_Id" });
            DropIndex("dbo.DocumentPayments", new[] { "PaymentStatus_Id" });
            DropIndex("dbo.DocumentPayments", new[] { "DocumentStatus_Id" });
            DropIndex("dbo.DocumentPayments", new[] { "Destinition_Id" });
            DropIndex("dbo.DocumentPayments", new[] { "Department_Id" });
            DropIndex("dbo.DocumentPayments", new[] { "CreateUser_Id" });
            DropIndex("dbo.DocumentPayments", new[] { "Company_Id" });
            DropTable("dbo.Payments");
            DropTable("dbo.FileClasses");
            DropTable("dbo.DocumentPayments");
        }
    }
}
