namespace cizgiromandukkani.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class musteri : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.musteris",
                c => new
                    {
                        musteriID = c.Int(nullable: false, identity: true),
                        musteriAdi = c.String(),
                        musteriSoyadi = c.String(),
                    })
                .PrimaryKey(t => t.musteriID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.musteris");
        }
    }
}
