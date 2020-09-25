using System;
using System.Collections.Generic;
using System.Text;

namespace Orderitem.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
