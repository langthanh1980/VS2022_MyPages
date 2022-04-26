using MyPages.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using AutoMapper.Mappers;
using MediatR;

namespace MyPages.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        
    }
}
