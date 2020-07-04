namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyMovieModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "DateAdded");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "CreatedDate");
        }
    }
}
