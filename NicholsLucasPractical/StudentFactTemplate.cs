using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

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

        public const string Collection = "ACT16";

        public const string MeasureType = "COUNT";

        public int ACT16FundCategory { get; set; }

    }
}
