namespace presentacion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _base : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Text = c.String(),
                        Autor = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Expert_Id = c.Int(),
                        Clients_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Experts", t => t.Expert_Id)
                .ForeignKey("dbo.Clients", t => t.Clients_Id)
                .Index(t => t.Expert_Id)
                .Index(t => t.Clients_Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        City = c.String(),
                        Response_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Responses", t => t.Response_Id)
                .Index(t => t.Response_Id);
            
            CreateTable(
                "dbo.Responses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TestQuestion_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TestQuestions", t => t.TestQuestion_Id)
                .Index(t => t.TestQuestion_Id);
            
            CreateTable(
                "dbo.TestQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Question_Id = c.Int(),
                        Test_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questions", t => t.Question_Id)
                .ForeignKey("dbo.Tests", t => t.Test_Id)
                .Index(t => t.Question_Id)
                .Index(t => t.Test_Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Number = c.Int(nullable: false),
                        Expert_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Experts", t => t.Expert_Id)
                .Index(t => t.Expert_Id);
            
            CreateTable(
                "dbo.Experts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        City = c.String(),
                        Degree = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Clients_Id", "dbo.Clients");
            DropForeignKey("dbo.TestQuestions", "Test_Id", "dbo.Tests");
            DropForeignKey("dbo.Users", "Expert_Id", "dbo.Experts");
            DropForeignKey("dbo.Tests", "Expert_Id", "dbo.Experts");
            DropForeignKey("dbo.Responses", "TestQuestion_Id", "dbo.TestQuestions");
            DropForeignKey("dbo.TestQuestions", "Question_Id", "dbo.Questions");
            DropForeignKey("dbo.Clients", "Response_Id", "dbo.Responses");
            DropForeignKey("dbo.Advices", "User_Id", "dbo.Users");
            DropIndex("dbo.Tests", new[] { "Expert_Id" });
            DropIndex("dbo.TestQuestions", new[] { "Test_Id" });
            DropIndex("dbo.TestQuestions", new[] { "Question_Id" });
            DropIndex("dbo.Responses", new[] { "TestQuestion_Id" });
            DropIndex("dbo.Clients", new[] { "Response_Id" });
            DropIndex("dbo.Users", new[] { "Clients_Id" });
            DropIndex("dbo.Users", new[] { "Expert_Id" });
            DropIndex("dbo.Advices", new[] { "User_Id" });
            DropTable("dbo.Experts");
            DropTable("dbo.Tests");
            DropTable("dbo.Questions");
            DropTable("dbo.TestQuestions");
            DropTable("dbo.Responses");
            DropTable("dbo.Clients");
            DropTable("dbo.Users");
            DropTable("dbo.Advices");
        }
    }
}
