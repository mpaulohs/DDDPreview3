using System;

namespace Checkout.Orders.Domain.Messages.Blog
{
    public class GetBlogMessage : IMessage
    {
        public int Id { get; set; }
    }
}