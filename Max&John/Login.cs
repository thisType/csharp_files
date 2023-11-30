using Max_John.Controllers;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_John
{
    internal class Login
    {
        string username = string.Empty;
        string password = string.Empty;

        public void loginUser()
        {
           

           

            while(true)
            {

                // gets the username
                Console.WriteLine("username:");
                username = Console.ReadLine();

                // get the password
                Console.WriteLine("password:");
                password = Console.ReadLine();

                int id = checkUserExist();

                if (id >=1)
                {
                    Console.WriteLine($"Welcome {username}");

                    SelectionOrder order = new(id);
                    order.OrderBook();
                     
                    break;

                }
                else
                {
                    Console.WriteLine("retry entering the values again");                }



            }


        }

        public int checkUserExist()
        { 

            int user_id = -1;

            Controller controller = new Controller();
            UserModel[] users = controller.GetUsers();

            
            foreach (var user in users)
            {     
                if(user.name == username && user.password == this.password)
                {
                    user_id = user.id; break;

                }


               }
            return user_id;

        }

        



    }
}
