using AutoMapper;
using Checkout.Orders.Domain.Entities.BlogAggregate;
using Checkout.Orders.Domain.Messages.Blog;

namespace Checkout.Orders.Domain.Handlers.Blog
{
    public class CreateBlog : MessageHandler<CreateBlogMessage, IBlog>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public CreateBlog(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }
        
        //public override IBlog Handle(CreateBlogMessage message)
        //{
        //    var b = new Blog();


        //    return null;
        //}
    }
}