using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StockManagementSystemASP.NETMVC.Models
{
    public class StockManagementDbContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
    }
}