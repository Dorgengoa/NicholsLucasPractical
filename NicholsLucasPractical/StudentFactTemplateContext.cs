using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NicholsLucasPractical
{
    public class StudentFactTemplateContext : DbContext //db class using entity framework
    {
        public DbSet<StudentFactTemplate> StudentFactTemplates { get; set; }
    }
}
