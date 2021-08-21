

using catalogs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Catalogs.Repositories
{
    public class InMenItemsRepository : IInMenItemsRepository  // referencing the IInMenItemsRepository interface.
    {
        // Generate a list of items 
        // using our model Entities to get declared variables.
        private readonly List<Item> Items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Portion", Price = 9, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Lekki", Price = 45, CreatedDate = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Sangotedo", Price = 19, CreatedDate = DateTimeOffset.UtcNow }

        };
        // create a basic interface for return the list items.  interface dont have code inside them just pattern of returns or functions.
        public IEnumerable<Item> GetItems()
        {
            return Items;
        }
        public Item GetItem(Guid Id)
        {
            return Items.Where(Item => Item.Id == Id).SingleOrDefault();
        }

    }
}