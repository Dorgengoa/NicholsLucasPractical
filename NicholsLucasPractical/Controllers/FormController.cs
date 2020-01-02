using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data.Entity;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NicholsLucasPractical.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FormController : ControllerBase
    {
        [HttpPost]
        public void Post(StudentFactTemplate template)
        {
            using (var db = new StudentFactTemplateContext())
            {
                //create fact template from model
                var studentFactTemplate = new StudentFactTemplate {
                    ID = 1, SubmittingAUN = template.SubmittingAUN, 
                    SchoolYearDate = template.SchoolYearDate, PASecureID = template.PASecureID, 
                    ReportingDate = template.ReportingDate, Collection = template.Collection, MeasureType = template.MeasureType,
                    ACT16FundCategory = template.ACT16FundCategory };

                //add to database
                db.StudentFactTemplates.Add(studentFactTemplate);
                db.SaveChanges();

                //var query = from x in db.StudentFactTemplates
                //            orderby x.ACT16FundCategory
                //            select x;
                //List<int> test = new List<int>();
                //foreach (var item in query)
                //{
                //    test.Add(item.SubmittingAUN);
                //}
                //int y = test[1];

            }
        }
    }
}
