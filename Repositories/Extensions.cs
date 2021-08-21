using catalogs.Entities;
using Catalogs.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogs.Repositories
{
    // this extension is created to avoid us retyping the DTOs on every route method in ItemsController class
    // always use a static class for extensions
    public static class Extensions
    {
        //create a method to use as a default
        public static ItemDTOs ASDTOs(this Item Item)
        {
            return new ItemDTOs
            {
                Id = Item.Id,
                Name = Item.Name ,
                    Price = Item.Price ,
                    CreatedDate=Item.CreatedDate 

            };
        }
    }
}
