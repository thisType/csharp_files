using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_John
{
    internal class Login
    {
        // variable intialization
        const string filaname = "password.txt";
        string file_path = Directory.GetCurrentDirectory();
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
        {    // file path
            string final_path = file_path +"\\"+ filaname;

            var lines  =   File.ReadAllLines(final_path);

            int user_id = -1;
            
            foreach (var line in lines)
            {     
                // split line
                  var  split_line = line.Split(',');

                if (split_line[1]== username && split_line[2] == password)
                {
                    user_id = Convert.ToInt32(split_line[0]);
                    break;
                   
                }
               }
            return user_id;

        }

        



    }
}
