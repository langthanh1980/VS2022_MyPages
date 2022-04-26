using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPages.Application.Features.Events
{
    public class GetEventsListQuery : IRequest<List<EventListVm>>
    {

    }
}
