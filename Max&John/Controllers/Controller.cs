using Max_John.Services;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_John.Controllers
{
    internal class Controller
    {
                  

        public bool RegisterUser(string username, string password)
        {
            UserModel user =new UserModel();
            user.name = username;
            user.password = password;
             RegisterLogin regLog = new RegisterLogin();
             Task<bool>  success = regLog.TryRegister(user);
            return success.Result;




        }

        public UserModel[] GetUsers()
        {
            Task<UserModel[]> users = new RegisterLogin().RegisteredUsers();

            return users.Result;


        }

        public BookModel[] ListBooks()
        {

            BookOrder bookOrder = new BookOrder();
            Task<BookModel[]> booksTask  = bookOrder.ListBook();


            return booksTask.Result;




        }

        public bool AddBook(string bookName, string description)
        {
                  BookOrder order = new BookOrder();
                  BookModel book = new BookModel(); 
                 book.name = bookName;
                book.description = description;
              
                Task<bool>  success = order.AddNewBook(book);
            return success.Result;

        }


        public void MakeOrder(int user_id,int book_id)
        {
            BookOrder orderS = new BookOrder();
            OrderModel order = new OrderModel();
            order.user_id = user_id;
            order.book_id = book_id;

          Task<bool> success  = orderS.MakeOrder(order);
           
   


        }


    }
}
