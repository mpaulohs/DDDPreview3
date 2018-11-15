using Checkout.Orders.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkout.Orders.Domain.Entities.BlogAggregate
{
    public class BlogImage : Entity
    {
       // public int BlogImageId { get; set; }
        public byte[] Image { get; set; }
        public string Caption { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
