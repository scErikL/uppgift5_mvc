namespace MVCAssignment5.Migrations
{
    using MVCAssignment5.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVCAssignment5.DataAccess.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MVCAssignment5.DataAccess.StoreContext context)
        {
            context.Items.AddOrUpdate(
                 new StockItem { ArticleNumber = 1, Description = "wobbler", Name = "HiLo", Price = 50.50, Quantity = 20, ShelfPosition = "1A" },
                 new StockItem { ArticleNumber = 1, Description = "spinner", Name = "Droppen copper", Price = 40.50, Quantity = 20, ShelfPosition = "1A" },
                 new StockItem { ArticleNumber = 1, Description = "flyfishing rod", Name = "Strömsländan", Price = 1500, Quantity = 2, ShelfPosition = "2A" }
             );
        }
    }
}
