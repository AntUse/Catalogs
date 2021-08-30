using catalogs.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogs.Repositories
{
    //This class is to initialize the Dbcontext class which comes wiht the microsoft.entityframeworkcore namespace
    // we add reference this  to use this  class appdbcontext
    public class AppDbContext :DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext >options) : base (options )
        {

        }
        //create a dataset from items model or entities as specified in our project 
        // use the data set to initiate a new table "itemstable" for our database we want to create
        public DbSet <Item> ItemsTable { get; set; }
       
    }
}
