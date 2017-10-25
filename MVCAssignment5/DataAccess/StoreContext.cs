using MVCAssignment5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAssignment5.DataAccess
{
    public class StoreContext : DbContext
    {
        public StoreContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<StockItem> Items { get; set; }
    }
}