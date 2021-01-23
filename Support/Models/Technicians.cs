using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Support.Models
{
    public class Technicians
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int YearsService { get; set; }
        public string Address { get; set; }

    }
    public class TechniciansDBContext : DbContext
    {
        public DbSet<Technicians> Technicians { get; set; }
    }
}