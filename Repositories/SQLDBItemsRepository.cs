using catalogs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogs.Repositories
{
    public class SQLDBItemsRepository : ISQLDBItemsRepository

    {
        private readonly AppDbContext appdbcontext;
        public SQLDBItemsRepository (AppDbContext appDbcontext)
        {
            this.appdbcontext = appDbcontext;
        }

        public void  CreatedItem(Item item)
        {
            throw new NotImplementedException();
            
        }

        public void DeleteItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Item GetItem(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems()
        {
            return appdbcontext.ItemsTable.ToList();
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
