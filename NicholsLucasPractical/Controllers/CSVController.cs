using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using CsvHelper;
using System.IO;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NicholsLucasPractical.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CSVController : ControllerBase
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult ExportAction()
        {

            using (var db = new StudentFactTempmlateContext())
            {
                 var query = from x in db.StudentFactTemplates
                            select x;

                List<StudentFactTemplate> templateList = new List<StudentFactTemplate>();
                foreach (var item in query)
                {
                    templateList.Add(item);
                }


                MemoryStream memoryStream = new MemoryStream();
                StreamWriter streamWriter = new StreamWriter(memoryStream, System.Text.Encoding.UTF8, 1024, true);

                using (CsvWriter csvWriter = new CsvWriter(streamWriter))
                {
                    csvWriter.Configuration.RegisterClassMap<StudentFactTemplateMap>();
                    csvWriter.WriteRecords(templateList);
                    streamWriter.Flush();
                    memoryStream.Position = 0;

                    return File(memoryStream.ToArray(), "text/csv","studentFactTemplates.csv");
                }

            }
            
        }
    }
}
