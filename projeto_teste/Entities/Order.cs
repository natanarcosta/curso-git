using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using projeto_teste.Entities.Enums;

namespace projeto_teste.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;
        }
    }
}
