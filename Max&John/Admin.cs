using Max_John.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_John
{
    internal class Admin
    {
        // admin details
        const string email_admin = "maxjohn@teach2give.com";
        const string password_admin = "teach2give";
        

        public void LoginAdmin()
        {
            Console.WriteLine("Admin Login");

            while (true)
            {
                Console.WriteLine("email: ");
                string email = Console.ReadLine();

                Console.WriteLine("password: ");
                string password = Console.ReadLine();

                if(email == email_admin && password == password_admin) {
                    Console.WriteLine("Welcome Admin");
                    break;
                
                } else
                {
                    Console.WriteLine("Wrong email or password!! Try agian");
                }



            }
            Proceed();


}
                 

                  public void Proceed()
        {

                         while (true)
                     {


                         Console.WriteLine("1. Add Book\n2. Logout ");
                         string choice = Console.ReadLine();

                           switch (choice)
                          {
                           case "1":
                           AddBook();
                           break;
                           case "2":
                        Console.WriteLine("Bye!");
                        return;
                            break;
                           default:
                           Console.WriteLine("Invalid Choice!");
                            break;
                }




            }
                    

        }



                public void AddBook() {
        

                   Console.WriteLine("Book Name: ");
                     string book_name = Console.ReadLine();

                   Console.WriteLine("Book Description: ");
                    string book_description = Console.ReadLine();

                    Controller controller = new Controller();

                      controller.AddBook(book_name, book_description);



        }

        
    }
}
