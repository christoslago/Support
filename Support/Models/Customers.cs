using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Support.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Isp { get; set; }
        public string ProblemDescription { get; set; }
        public string LoopType { get; set; }
        public string Comments { get; set; }


    }
    public class CustomersDBContext : DbContext
    {
        public DbSet<Customers> Customers { get; set; }
    }
}