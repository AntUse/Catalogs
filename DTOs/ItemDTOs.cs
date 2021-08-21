using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalogs.DTOs
{
    public record ItemDTOs
    {
        
        // this class is created to avoid showing our entities direct names in the swagger page.
            public Guid Id { get; init; }

            public String Name { get; init; }
            public decimal Price { get; init; }

            public DateTimeOffset CreatedDate { get; init; }
    }
    
}
