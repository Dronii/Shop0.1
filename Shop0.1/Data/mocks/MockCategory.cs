using Shop0._1.Data.interfaces;
using Shop0._1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop0._1.Data.mocks
{
    public class MockCategory : IItemsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoryName = "categoryName1" , desc = "desc1"},
                    new Category{categoryName = "categoryName2" , desc = "desc2"}
                };
            }
        }
    }
}
