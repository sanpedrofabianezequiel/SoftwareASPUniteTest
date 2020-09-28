namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Operas",
                c => new
                    {
                        OperaId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 20),
                        Year = c.Int(nullable: false),
                        Composer = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.OperaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Operas");
        }
    }
}
