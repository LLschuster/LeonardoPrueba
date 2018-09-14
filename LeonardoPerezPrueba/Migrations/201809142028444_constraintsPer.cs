namespace LeonardoPerezPrueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class constraintsPer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.personas", "nombre", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.personas", "nombre", c => c.String());
        }
    }
}
