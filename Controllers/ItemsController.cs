using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using catalogs.Entities;
using Catalogs.Repositories;
using System;

namespace catalogs.controllers
{
    [ApiController]
    [Route("Items")]
    public class ItemsController : ControllerBase
    {
        private readonly InMenItemsRepository Repository;

        public ItemsController()   // a contructor to initialize and get the list items from the InMenItemsRepository class in our Repositories.
        {
            Repository = new InMenItemsRepository();
        }
        // Get /items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var Items = Repository.GetItems();
            return Items;

        }

        // Get /items/id
        [HttpGet("{Id}")]
        //ActionResult help to return different types. To actually work without Action result
        // Use Public IEnumerables<Item> GetItem(Guid Id)
        //For this get id of items, we will have an issue as a new instance is created for the get id and will not recognize the previously generated Guid for Id field
        // So we just let it show us the not found in the IF statement.
        public ActionResult<Item> GetItem(Guid Id)
        {
            var Item = Repository.GetItem(Id);
            if (Item is null)
            {
                return NotFound();
            }

            return Item;
        }
    }
}
