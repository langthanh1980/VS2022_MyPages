using System;
using System.Collections.Generic;
using System.Text;
using MyPages.Domain.Entities.Common;
namespace MyPages.Domain.Entities
{
    public class Order : AuditableEntity
    {
        public Guid OrderId { get; set; }
        public Guid UserIf { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderPlaced { get; set; }
        public bool OrderPaid { get; set; }
        public bool OrderShipped { get; set; }
        public bool OrderCancel { get; set; }
        public bool OrderSaved { get; set; }
    }
}
