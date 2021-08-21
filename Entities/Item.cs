using System;

namespace catalogs.Entities
{
    //creating a class but using record type instead of a 'class item'
    public record Item
    {
       public Guid Id {get; init;}
      
        public String Name {get; init;}
      public decimal Price {get; init;}
       
        public DateTimeOffset CreatedDate {get; init;}

    }
}