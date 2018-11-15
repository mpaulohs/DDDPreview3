using Demo.Domain.Application.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Demo.Domain.Application.Commands
{
    [DataContract]
    public class CreateBookCommand : IRequest<Response>
    {
        [DataMember]
        public string Title { get; set; }
        

        public CreateBookCommand() { }

        public CreateBookCommand(string title)
        {
            Title = title;
        }
    }
}
