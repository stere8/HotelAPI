namespace HotelAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guests", "Telefon", c => c.String());
            AddColumn("dbo.Guests", "Adres", c => c.String());
            AddColumn("dbo.Guests", "Miasto", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Guests", "Miasto");
            DropColumn("dbo.Guests", "Adres");
            DropColumn("dbo.Guests", "Telefon");
        }
    }
}
