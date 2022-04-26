using System;
using System.Collections.Generic;
using System.Text;
using MyPages.Domain.Entities.Common;

namespace MyPages.Domain.Entities
{
    public class Category: AuditableEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Event> Events { get; set; }
        //con duogn xua em di
    }
}
