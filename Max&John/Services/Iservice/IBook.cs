using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_John.Services.Iservice
{
    internal interface IBook

    {
        public  Task<bool> AddNewBook(BookModel book);
        public Task<BookModel[]> ListBook();

        public Task<bool> MakeOrder(OrderModel order);
    }
}
