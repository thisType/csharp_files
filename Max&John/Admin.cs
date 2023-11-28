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
        const string filename_book = "book.txt";
        string file_path = Directory.GetCurrentDirectory();


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
        
                   string final_path = file_path + "\\" + filename_book;

                   Console.WriteLine("Book Name: ");
                     string book_name = Console.ReadLine();

                   Console.WriteLine("Book Description: ");
                    string book_description = Console.ReadLine();
                   
                   int book_id = GetNewId();
                    
                     string prepare = book_id +","+book_name+","+book_description +"\n";

                   File.AppendAllText(final_path, prepare);



        }

        public int GetNewId()
        {
            string final_path = file_path + "\\" + filename_book;

            if (File.Exists(final_path))
            {
                var lines = File.ReadAllLines(final_path);

                var line = lines[lines.Length - 1];

                string lastbook_id = line.Split(',')[0];
                int id = Convert.ToInt32(lastbook_id);
                return ++id;

            }
            else
            {

                return 1;
            }




        }
    }
}
