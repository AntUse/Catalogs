using catalogs.Entities;
using Microsoft.EntityFrameworkCore;
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

        public async  Task CreatedItemAsync(Item item)
        {
            var result =  appdbcontext.ItemsTable.AddAsync(item); // adds the created item to the ITemstable in SQLSERVER
            await appdbcontext.SaveChangesAsync();
            
            
            
        }


        public async Task DeleteItemAsync(Guid id)
        {
            var result = await appdbcontext.ItemsTable.FirstOrDefaultAsync(existingItems => existingItems.Id == id);

            if (result !=null )
            {
               appdbcontext.ItemsTable.Remove(result );
               await  appdbcontext.SaveChangesAsync();
            }
            
        }

        public async Task<Item> GetItemAsync(Guid Id)
        {
           return await appdbcontext .ItemsTable.AsNoTracking().FirstOrDefaultAsync(existingItem => existingItem.Id == Id);
           // return await appdbcontext.ItemsTable.FirstOrDefaultAsync(existingItem => existingItem.Id == Id);


        }

        public async Task<IEnumerable<Item>> GetItemsAsync()
        {
            return await appdbcontext.ItemsTable.ToListAsync();
           // return await appdbcontext.ItemsTable.AsNoTracking().ToListAsync();
        }

        public  async Task UpdateItemAsync(Item item)
        {
            
            
            appdbcontext.ItemsTable.Update(item  );
             await   appdbcontext.SaveChangesAsync();
                

            }
    }
}
