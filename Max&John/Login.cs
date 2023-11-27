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


                bool user_exist = checkUserExist();
                if(user_exist)
                {
                    Console.WriteLine($"Welcome {username}");
                    break;

                }
                else
                {
                    Console.WriteLine("retry entering the values again");                }



            }


        }

        public bool checkUserExist()
        {    // file path
            string final_path = file_path + filaname;

            var lines  =   File.ReadAllLines(final_path);

            bool user_exist = false;
            
            foreach (var line in lines)
            {     
                // split line
                  var  split_line = line.Split(' ');

                if (split_line[0]== username && split_line[1] == password)
                {
                    user_exist = true;
                    break;
                   
                }
               }
            return user_exist;

        }

        



    }
}
