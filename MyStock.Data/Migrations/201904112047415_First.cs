namespace MyStock.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BrandTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        CreatedDateOffsetUtc = c.DateTimeOffset(precision: 7),
                        CreatedBy = c.String(),
                        UpdatedDateOffsetUtc = c.DateTimeOffset(precision: 7),
                        UpdatedBy = c.String(),
                        IsDeletable = c.Boolean(nullable: false),
                        DeletionDateOffsetUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        Count = c.Int(nullable: false),
                        BuyingPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Kdv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IDBrand = c.Int(nullable: false),
                        IDOrder = c.Int(nullable: false),
                        CreatedDateOffsetUtc = c.DateTimeOffset(precision: 7),
                        CreatedBy = c.String(),
                        UpdatedDateOffsetUtc = c.DateTimeOffset(precision: 7),
                        UpdatedBy = c.String(),
                        IsDeletable = c.Boolean(nullable: false),
                        DeletionDateOffsetUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BrandTable", t => t.IDBrand)
                .ForeignKey("dbo.OrderTable", t => t.IDOrder)
                .Index(t => t.IDBrand)
                .Index(t => t.IDOrder);
            
            CreateTable(
                "dbo.OrderTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Count = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IDCustomer = c.Int(nullable: false),
                        IDEmployee = c.Int(nullable: false),
                        CreatedDateOffsetUtc = c.DateTimeOffset(precision: 7),
                        CreatedBy = c.String(),
                        UpdatedDateOffsetUtc = c.DateTimeOffset(precision: 7),
                        UpdatedBy = c.String(),
                        IsDeletable = c.Boolean(nullable: false),
                        DeletionDateOffsetUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CustomerTable", t => t.IDCustomer)
                .Index(t => t.IDCustomer);
            
            CreateTable(
                "dbo.CustomerTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 10),
                        Address = c.String(nullable: false, maxLength: 250),
                        Dept = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDateOffsetUtc = c.DateTimeOffset(precision: 7),
                        CreatedBy = c.String(),
                        UpdatedDateOffsetUtc = c.DateTimeOffset(precision: 7),
                        UpdatedBy = c.String(),
                        IsDeletable = c.Boolean(nullable: false),
                        DeletionDateOffsetUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.EmployeeTable",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false, maxLength: 10),
                        Address = c.String(nullable: false, maxLength: 250),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Photo = c.String(),
                        CreatedDateOffsetUtc = c.DateTimeOffset(precision: 7),
                        CreatedBy = c.String(),
                        UpdatedDateOffsetUtc = c.DateTimeOffset(precision: 7),
                        UpdatedBy = c.String(),
                        IsDeletable = c.Boolean(nullable: false),
                        DeletionDateOffsetUtc = c.DateTimeOffset(precision: 7),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.OrderTable", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTable", "IDOrder", "dbo.OrderTable");
            DropForeignKey("dbo.EmployeeTable", "ID", "dbo.OrderTable");
            DropForeignKey("dbo.OrderTable", "IDCustomer", "dbo.CustomerTable");
            DropForeignKey("dbo.ProductTable", "IDBrand", "dbo.BrandTable");
            DropIndex("dbo.EmployeeTable", new[] { "ID" });
            DropIndex("dbo.OrderTable", new[] { "IDCustomer" });
            DropIndex("dbo.ProductTable", new[] { "IDOrder" });
            DropIndex("dbo.ProductTable", new[] { "IDBrand" });
            DropTable("dbo.EmployeeTable");
            DropTable("dbo.CustomerTable");
            DropTable("dbo.OrderTable");
            DropTable("dbo.ProductTable");
            DropTable("dbo.BrandTable");
        }
    }
}
