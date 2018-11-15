using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReverseEngineeringDatabase.Features.Book
{

    public class BookCreateCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }        
    }
}
