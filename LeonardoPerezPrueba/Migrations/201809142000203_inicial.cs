namespace LeonardoPerezPrueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.personas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        edad = c.Int(nullable: false),
                        sexoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.sexoes", t => t.sexoId, cascadeDelete: true)
                .Index(t => t.sexoId);
            
            CreateTable(
                "dbo.sexoes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nsexo = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.personas", "sexoId", "dbo.sexoes");
            DropIndex("dbo.personas", new[] { "sexoId" });
            DropTable("dbo.sexoes");
            DropTable("dbo.personas");
        }
    }
}
