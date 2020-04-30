namespace presentacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracion21 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Advices", "User_Id", "dbo.Users");
            DropIndex("dbo.Advices", new[] { "User_Id" });
            AlterColumn("dbo.Advices", "Texto", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Advices", "Autor", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Advices", "User_Id", c => c.Int());
            CreateIndex("dbo.Advices", "User_Id");
            AddForeignKey("dbo.Advices", "User_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Advices", "User_Id", "dbo.Users");
            DropIndex("dbo.Advices", new[] { "User_Id" });
            AlterColumn("dbo.Advices", "User_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Advices", "Autor", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Advices", "Texto", c => c.String(nullable: false, maxLength: 20));
            CreateIndex("dbo.Advices", "User_Id");
            AddForeignKey("dbo.Advices", "User_Id", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
