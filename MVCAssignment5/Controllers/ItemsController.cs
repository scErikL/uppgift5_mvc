using MVCAssignment5.Models;
using MVCAssignment5.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignment5.Controllers
{
    public class ItemsController : Controller
    {
        ItemRepository repo = new ItemRepository();

        // GET: Items
        public ActionResult Index()
        {
            return View(repo.GetAllItems());
        }

        public ActionResult Details(int id)
        {
            return View(repo.GetItemByArticleNumber(id));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StockItem item)
        {
            if (ModelState.IsValid)
            {
                repo.CreateItem(item);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            return View(repo.GetItemByArticleNumber(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StockItem item)
        {
            if (ModelState.IsValid)
            {
                repo.EditItem(item);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(repo.GetItemByArticleNumber(id));
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (ModelState.IsValid)
            {
                repo.RemoveItemById(id);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}