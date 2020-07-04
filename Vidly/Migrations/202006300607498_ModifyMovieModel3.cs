namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyMovieModel3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "CreatedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "CreatedDate", c => c.DateTime(nullable: false));
        }
    }
}
