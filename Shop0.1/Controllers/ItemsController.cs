using Microsoft.AspNetCore.Mvc;
using Shop0._1.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop0._1.Controllers
{
    public class ItemsController : Controller
    {
        private readonly IAllItems _allItems;
        private readonly IItemsCategory _allCategories;
        
        public ItemsController(IAllItems iAllItems, IItemsCategory iItemsCategory)
        {
            _allItems = iAllItems;
            _allCategories = iItemsCategory;
        }
        public ViewResult List()
        {
            var items = _allItems.Items;
            return View();
        }
    }
}
