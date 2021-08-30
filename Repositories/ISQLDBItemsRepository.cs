using catalogs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogs.Repositories
{
   public  interface ISQLDBItemsRepository
    {
        Item GetItem(Guid Id);
        IEnumerable<Item> GetItems();

        void CreatedItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(Guid id);
    }
}
