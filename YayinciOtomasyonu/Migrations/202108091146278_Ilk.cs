namespace YayinciOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kitaplar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Yazarlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.YazarKitaps",
                c => new
                    {
                        Yazar_Id = c.Int(nullable: false),
                        Kitap_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Yazar_Id, t.Kitap_Id })
                .ForeignKey("dbo.Yazarlar", t => t.Yazar_Id, cascadeDelete: true)
                .ForeignKey("dbo.Kitaplar", t => t.Kitap_Id, cascadeDelete: true)
                .Index(t => t.Yazar_Id)
                .Index(t => t.Kitap_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.YazarKitaps", "Kitap_Id", "dbo.Kitaplar");
            DropForeignKey("dbo.YazarKitaps", "Yazar_Id", "dbo.Yazarlar");
            DropIndex("dbo.YazarKitaps", new[] { "Kitap_Id" });
            DropIndex("dbo.YazarKitaps", new[] { "Yazar_Id" });
            DropTable("dbo.YazarKitaps");
            DropTable("dbo.Yazarlar");
            DropTable("dbo.Kitaplar");
        }
    }
}
