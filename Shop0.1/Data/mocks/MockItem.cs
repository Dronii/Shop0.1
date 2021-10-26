using Shop0._1.Data.interfaces;
using Shop0._1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop0._1.Data.mocks
{
    public class MockItem : IAllItems
    {
        private readonly IItemsCategory _itemsCategory = new MockCategory();
        public IEnumerable<Item> Items 
        {
            get
            {
                return new List<Item>
                {
                    new Item {name = "NAME",
                        shortDesc = "shortDesc",
                        longDesc = "longDesc",
                        img = "img",
                        price = 0, isFavorit = true ,
                        available = true,
                        Category= _itemsCategory.AllCategories.First()},
                     new Item {name = "NAME1",
                        shortDesc = "shortDesc1",
                        longDesc = "longDesc1",
                        img = "img1",
                        price = 0, isFavorit = true ,
                        available = true,
                        Category= _itemsCategory.AllCategories.First()},
                      new Item {name = "NAME2",
                        shortDesc = "shortDesc2",
                        longDesc = "longDesc2",
                        img = "https://fistingshop.com/image/cache/catalog/allfist/4/age-catalog-allfist-big-ben-blue-500x500.png.webp",
                        price = 0, isFavorit = true ,
                        available = true,
                        Category= _itemsCategory.AllCategories.Last()},
                       new Item {name = "NAME3",
                        shortDesc = "shortDesc3",
                        longDesc = "longDesc3",
                        img = "img3",
                        price = 0, isFavorit = true ,
                        available = true,
                        Category= _itemsCategory.AllCategories.Last()}
                };
            }
        }
        public IEnumerable<Item> getFavItems { get; set; }

        public Item getObjectItem(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
