namespace ProductsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class annotations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        email = c.String(nullable: false, maxLength: 30),
                        comment = c.String(nullable: false, maxLength: 240),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductName = c.String(maxLength: 10),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
            DropTable("dbo.Feedbacks");
        }
    }
}
