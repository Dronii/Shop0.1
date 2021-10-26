using Shop0._1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop0._1.Data.interfaces
{
    public interface IAllItems
    {
        IEnumerable<Item> Items { get; }
        IEnumerable<Item> getFavItems { get; set; }
        Item getObjectItem(int carId);
    }
}
