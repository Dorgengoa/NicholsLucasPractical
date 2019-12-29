namespace NicholsLucasPractical.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NicholsLucasPractical.StudentFactTempmlateContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "NicholsLucasPractical.StudentFactTempmlateContext";
        }

        protected override void Seed(NicholsLucasPractical.StudentFactTempmlateContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
