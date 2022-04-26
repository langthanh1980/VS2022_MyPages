using System;
using System.Collections.Generic;
using System.Text;
using MyPages.Domain.Entities.Common;
namespace MyPages.Domain.Entities
{
    public class Event : AuditableEntity
    {
        public Guid EventId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Hoster { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
