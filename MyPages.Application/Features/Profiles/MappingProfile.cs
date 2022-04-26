using AutoMapper;
using MyPages.Application.Features.Events;
using MyPages.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPages.Application.Features.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
        }
    }
}
