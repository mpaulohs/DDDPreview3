using Demo.Domain.SeedWork;

namespace Demo.Domain.AggregatesModel.BookAggregate
{
    public class Book : Entity, IAggregateRoot
    {
        public string Title { get; set; }

        public Book() { }
        public Book(string title)
        {
            Title = title;
        }

    }
}
