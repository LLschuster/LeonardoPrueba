namespace LeonardoPerezPrueba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class poblarSexo : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO dbo.sexoes (Nsexo)" +
                       " VALUES ('Masculino')");
            Sql("INSERT INTO dbo.sexoes (Nsexo)" +
               " VALUES ('Femenino')");
        }
        
        public override void Down()
        {
        }
    }
}
