using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using catalogs.Entities;
using Catalogs.Repositories;
using System;
using Catalogs.DTOs;
using System.Linq;

namespace catalogs.controllers
{
    [ApiController]
    [Route("Items")]
    public class ItemsController : ControllerBase
    {
        //private readonly InMenItemsRepository Repository; BEFORE WE CREATED THE DEPENDENCY USING THE INTERFACE.
        private readonly IInMenItemsRepository Repository;

        //BEFORE WE CREATED THE DEPENDENCY USING THE INTERFACE.
        //public ItemsController() // a contructor to initialize and get the list items from the InMenItemsRepository class in our Repositories. 
        // {
        //Repository = new InMenItemsRepository(); 
        // }
        public ItemsController( IInMenItemsRepository Repository)   // a contructor to initialize and get the list items from the IinMenItemsRepository interface which the InMen... class is depending upon.
        {
            this.Repository = Repository;
        }
        // Get /items
        [HttpGet]
        //public IEnumerable<Item> GetItems()
       // {
       //     var Items = Repository.GetItems();
         //   return Items;

        //}
        // USING THE EXTENSIONS CLASS TO RUN THE ItemDTOs class
        public IEnumerable<ItemDTOs> GetItems()
        {
            var Items = Repository.GetItems().Select(Item => Item.ASDTOs());
            return Items;

        }
        // Get /items/id
        [HttpGet("{Id}")]
        //ActionResult help to return different types. To actually work without Action result
        // Use Public IEnumerables<Item> GetItem(Guid Id)
        //For this get id of items, we will have an issue as a new instance is created for the get id and will not recognize the previously generated Guid for Id field
        // So we just let it show us the not found in the IF statement.

        // to fix the instance issue, we create a dependencing using an interface as an abstraction.

       // public ActionResult<Item> GetItem(Guid Id)
        //{
          //  var Item = Repository.GetItem(Id);
            //if (Item is null)
            //{
         //       return NotFound();
         //   }

         //   return Item;
        //}

        public ActionResult<ItemDTOs> GetItem(Guid Id)
        {
            var Item = Repository.GetItem(Id);
            if (Item is null)
            {
                return NotFound();
            }

            return Item.ASDTOs();
        }
    }
}
