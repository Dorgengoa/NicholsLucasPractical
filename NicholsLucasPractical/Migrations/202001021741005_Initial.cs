namespace NicholsLucasPractical.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentFactTemplates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SubmittingAUN = c.Int(nullable: false),
                        SchoolYearDate = c.DateTime(nullable: false),
                        PASecureID = c.Int(nullable: false),
                        ReportingDate = c.DateTime(nullable: false),
                        Collection = c.String(),
                        MeasureType = c.String(),
                        ACT16FundCategory = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentFactTemplates");
        }
    }
}
