namespace presentacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracion2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Advices", "User_Id", "dbo.Users");
            DropIndex("dbo.Advices", new[] { "User_Id" });
            AlterColumn("dbo.Advices", "Texto", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Advices", "Autor", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Advices", "User_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Experts", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Experts", "LastName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Experts", "City", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Experts", "Degree", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Experts", "ImageUrl", c => c.String(maxLength: 100));
            CreateIndex("dbo.Advices", "User_Id");
            AddForeignKey("dbo.Advices", "User_Id", "dbo.Users", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Advices", "User_Id", "dbo.Users");
            DropIndex("dbo.Advices", new[] { "User_Id" });
            AlterColumn("dbo.Experts", "ImageUrl", c => c.String());
            AlterColumn("dbo.Experts", "Degree", c => c.String());
            AlterColumn("dbo.Experts", "City", c => c.String());
            AlterColumn("dbo.Experts", "LastName", c => c.String());
            AlterColumn("dbo.Experts", "Name", c => c.String());
            AlterColumn("dbo.Advices", "User_Id", c => c.Int());
            AlterColumn("dbo.Advices", "Autor", c => c.String());
            AlterColumn("dbo.Advices", "Texto", c => c.String());
            CreateIndex("dbo.Advices", "User_Id");
            AddForeignKey("dbo.Advices", "User_Id", "dbo.Users", "Id");
        }
    }
}
