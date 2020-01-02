using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using CsvHelper.Configuration;

namespace NicholsLucasPractical
{
    public class StudentFactTemplate
    {
        [Key]
        public int ID { get; set; }
        public int SubmittingAUN { get; set; }

        public DateTime SchoolYearDate { get; set; }

        public int PASecureID { get; set; }

        public DateTime ReportingDate { get; set; }

        public string Collection { get; set; }

        public string MeasureType { get; set; }

        public int ACT16FundCategory { get; set; }

    }
    public sealed class StudentFactTemplateMap : ClassMap<StudentFactTemplate>
    {
        public StudentFactTemplateMap()
        {
            AutoMap();
            Map(m => m.ID).Ignore();
        }
    }
}
