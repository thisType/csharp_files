using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_John.Services.Iservice
{
    internal interface IOrder
    {

        public Task OrderBook(OrderModel model);
    }
}
