using System.ComponentModel.DataAnnotations;

namespace Checkout.Orders.API.Contract.Requests
{
    public class CreateBlogRequest
    {
        [Required]
        public string Url { get; set; }
    }
}