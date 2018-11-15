using System;

namespace Checkout.Orders.Domain.Messages.Blog
{
    public class DeleteBlogMessage : IMessage
    {
        public int Id { get; set; }
    }
}