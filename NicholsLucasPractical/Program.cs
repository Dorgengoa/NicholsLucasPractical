using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Data.Entity;

namespace NicholsLucasPractical
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //temp placeholder for user entry with html
            using (var db = new StudentFactTempmlateContext())
            {
                int subAUN = 123456789;
                DateTime schoolYearDate = DateTime.Now;
                int PASecureID = 1000000001;
                DateTime reportingDate = DateTime.Now;
                int ACT16FundCategory = 2;

                var studentFactTemplate = new StudentFactTemplate {ID = 1, SubmittingAUN = subAUN, SchoolYearDate = schoolYearDate, PASecureID = PASecureID, ReportingDate = reportingDate, ACT16FundCategory = ACT16FundCategory };
                db.StudentFactTemplates.Add(studentFactTemplate);
                db.SaveChanges();

                var query = from x in db.StudentFactTemplates
                            orderby x.ACT16FundCategory
                            select x;
                List<int> test = new List<int>();
                foreach (var item in query)
                {
                    test.Add(item.SubmittingAUN);
                }
                int y = test[1];

            }

            CreateHostBuilder(args).Build().Run();
        }

        

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
