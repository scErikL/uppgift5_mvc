using MVCAssignment5.DataAccess;
using MVCAssignment5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAssignment5.Repositories
{
    public class ItemRepository
    {
        StoreContext context = new StoreContext();

        public IEnumerable<StockItem> GetAllItems()
        {
            return context.Items;
        }

        public void CreateItem(StockItem item)
        {
            context.Items.Add(item);
            context.SaveChanges();
        }

        public void EditItem(StockItem item)
        {
            context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void RemoveItemById(int id)
        {
            StockItem item = context.Items.FirstOrDefault(stockItem => stockItem.ArticleNumber == id);
            if (item != null)
            {
                context.Items.Remove(item);
                context.SaveChanges();
            }
        }

        public StockItem GetItemByArticleNumber(int articleNr)
        {
            return context.Items.FirstOrDefault(item => item.ArticleNumber == articleNr);
        }

        //TODO...
         public IEnumerable<StockItem> SearchItems(string search)
        {
            return context.Items.Where(item=>item.Name.Contains(search) || item.Price.ToString().Contains(search));
        }

             }
}