namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMovieTableStructure1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "ReleaseDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
        }
    }
}
