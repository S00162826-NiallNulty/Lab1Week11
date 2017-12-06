namespace Lab1Week11.Migrations.ClubContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatesChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ClubEvent", "CreationDate", c => c.DateTime());
            AlterColumn("dbo.ClubEvent", "StartDateTime", c => c.DateTime());
            AlterColumn("dbo.ClubEvent", "EndDateTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClubEvent", "EndDateTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ClubEvent", "StartDateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.ClubEvent", "CreationDate");
        }
    }
}
