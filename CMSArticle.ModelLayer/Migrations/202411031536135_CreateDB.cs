namespace CMSArticle.ModelLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Family = c.String(),
                        PhoneNumber = c.String(),
                        Password = c.String(),
                        RegisterDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        AdminId = c.Int(nullable: false),
                        Title = c.String(),
                        Content = c.String(),
                        ImageName = c.String(),
                        Like = c.Int(nullable: false),
                        Visit = c.Int(nullable: false),
                        RegisterDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Category_CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.ArticleId)
                .ForeignKey("dbo.Admins", t => t.AdminId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId)
                .Index(t => t.AdminId)
                .Index(t => t.Category_CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Content = c.String(),
                        RegisterDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Article_ArticleId = c.Int(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Articles", t => t.Article_ArticleId)
                .Index(t => t.Article_ArticleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "Article_ArticleId", "dbo.Articles");
            DropForeignKey("dbo.Articles", "Category_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Articles", "AdminId", "dbo.Admins");
            DropIndex("dbo.Comments", new[] { "Article_ArticleId" });
            DropIndex("dbo.Articles", new[] { "Category_CategoryId" });
            DropIndex("dbo.Articles", new[] { "AdminId" });
            DropTable("dbo.Comments");
            DropTable("dbo.Categories");
            DropTable("dbo.Articles");
            DropTable("dbo.Admins");
        }
    }
}
