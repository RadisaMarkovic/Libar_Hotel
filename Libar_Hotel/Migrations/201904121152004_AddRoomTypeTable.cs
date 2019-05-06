namespace Libar_Hotel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRoomTypeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RoomTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RoomTypes");
        }
    }
}
