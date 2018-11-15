using System;
using System.Collections.Generic;
using Checkout.Orders.Domain.Entities;

namespace Checkout.Orders.Domain.Messages.Blog
{
    public class UpdateBlogMessage : IMessage
    {
        public int Id { get; set; }        
        public string Url { get; set; }
       
    }
}