using Checkout.Orders.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Checkout.Orders.Domain.Entities.PostAggregate
{
    public class Tag
    {
        public string TagId { get; set; }

        public List<PostTag> PostTags { get; set; }
    }
}
