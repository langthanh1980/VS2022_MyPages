using MyPages.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyPages.Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
    }
}
