using Max_John.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_John
{
    internal class Register
    {

        string username = string.Empty;
        string password = string.Empty;


        public void registerUser()
        {    // gets the username
            Console.WriteLine("username:");
            username = Console.ReadLine();

            // get the password
            Console.WriteLine("password:");
            password = Console.ReadLine();


            Console.WriteLine("Register Successful");

            Controller controller = new Controller();
            bool success = controller.RegisterUser(username, password);
            if(success)
            {

                Console.WriteLine("Registered Successful");
            } else
            {
                Console.WriteLine("Something went wrong!");
            }


        }




    }
}


