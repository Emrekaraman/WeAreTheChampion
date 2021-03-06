namespace WeAreTheChampion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ColorName = c.String(),
                        Red = c.Byte(nullable: false),
                        Green = c.Byte(nullable: false),
                        Blue = c.Byte(nullable: false),
                        Team_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .Index(t => t.Team_Id);
            
            CreateTable(
                "dbo.Matchs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MatchTime = c.DateTime(),
                        Score1 = c.Int(),
                        Score2 = c.Int(),
                        Durumlar = c.Int(nullable: false),
                        IcSahaId = c.Int(nullable: false),
                        DısSahaId = c.Int(nullable: false),
                        Result = c.Int(nullable: false),
                        Team_Id = c.Int(),
                        Team_Id1 = c.Int(),
                        DısSahalar_Id = c.Int(),
                        IcSahalar_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id)
                .ForeignKey("dbo.Teams", t => t.Team_Id1)
                .ForeignKey("dbo.Teams", t => t.DısSahalar_Id)
                .ForeignKey("dbo.Teams", t => t.IcSahalar_Id)
                .Index(t => t.Team_Id)
                .Index(t => t.Team_Id1)
                .Index(t => t.DısSahalar_Id)
                .Index(t => t.IcSahalar_Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeamName = c.String(nullable: false, maxLength: 100),
                        RenkAdi1 = c.String(),
                        RenkAdi2 = c.String(),
                        RenkAdi3 = c.String(),
                        RenkAdi4 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlayerName = c.String(),
                        TeamId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Veriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Takim1 = c.String(),
                        Takim2 = c.String(),
                        Tarih = c.String(),
                        Skor1 = c.Int(nullable: false),
                        Skor2 = c.Int(nullable: false),
                        Durum = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlayerTeams",
                c => new
                    {
                        Player_Id = c.Int(nullable: false),
                        Team_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Player_Id, t.Team_Id })
                .ForeignKey("dbo.Players", t => t.Player_Id, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.Team_Id, cascadeDelete: true)
                .Index(t => t.Player_Id)
                .Index(t => t.Team_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matchs", "IcSahalar_Id", "dbo.Teams");
            DropForeignKey("dbo.Matchs", "DısSahalar_Id", "dbo.Teams");
            DropForeignKey("dbo.PlayerTeams", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.PlayerTeams", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.Matchs", "Team_Id1", "dbo.Teams");
            DropForeignKey("dbo.Matchs", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.Colors", "Team_Id", "dbo.Teams");
            DropIndex("dbo.PlayerTeams", new[] { "Team_Id" });
            DropIndex("dbo.PlayerTeams", new[] { "Player_Id" });
            DropIndex("dbo.Matchs", new[] { "IcSahalar_Id" });
            DropIndex("dbo.Matchs", new[] { "DısSahalar_Id" });
            DropIndex("dbo.Matchs", new[] { "Team_Id1" });
            DropIndex("dbo.Matchs", new[] { "Team_Id" });
            DropIndex("dbo.Colors", new[] { "Team_Id" });
            DropTable("dbo.PlayerTeams");
            DropTable("dbo.Veriler");
            DropTable("dbo.Players");
            DropTable("dbo.Teams");
            DropTable("dbo.Matchs");
            DropTable("dbo.Colors");
        }
    }
}
