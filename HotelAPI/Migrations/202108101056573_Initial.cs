namespace HotelAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Imię = c.String(nullable: false),
                        Nazwizko = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        DataUrodzenia = c.DateTime(),
                        KodPocztowy = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KodRezerwacji = c.String(nullable: false, maxLength: 10),
                        DatyUtworzenia = c.DateTime(nullable: false),
                        Cena = c.Double(nullable: false),
                        DataZameldowania = c.DateTime(nullable: false),
                        DataWymeldowania = c.DateTime(nullable: false),
                        Waluta = c.Int(nullable: false),
                        Prowizja = c.String(),
                        Źródło = c.String(),
                        GoścID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ReservationGuests",
                c => new
                    {
                        Reservation_ID = c.Int(nullable: false),
                        Guest_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reservation_ID, t.Guest_ID })
                .ForeignKey("dbo.Reservations", t => t.Reservation_ID, cascadeDelete: true)
                .ForeignKey("dbo.Guests", t => t.Guest_ID, cascadeDelete: true)
                .Index(t => t.Reservation_ID)
                .Index(t => t.Guest_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReservationGuests", "Guest_ID", "dbo.Guests");
            DropForeignKey("dbo.ReservationGuests", "Reservation_ID", "dbo.Reservations");
            DropIndex("dbo.ReservationGuests", new[] { "Guest_ID" });
            DropIndex("dbo.ReservationGuests", new[] { "Reservation_ID" });
            DropTable("dbo.ReservationGuests");
            DropTable("dbo.Reservations");
            DropTable("dbo.Guests");
        }
    }
}
