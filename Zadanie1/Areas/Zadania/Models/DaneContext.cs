using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Zadanie1.Areas.Zadania.Models
{
    public class DaneContext : DbContext
    {
        public DbSet<Dane> Dane { get; set; }
    }
}