using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_John
{
    internal class Register
    {
        const string filename = "password.txt";
        string file_path = Directory.GetCurrentDirectory();
        string username = string.Empty;
        string password = string.Empty;


        public  void registerUser()
        {    // gets the username
            Console.WriteLine("username:");
            username = Console.ReadLine();

            // get the password
            Console.WriteLine("password:");
            password = Console.ReadLine();

            this.writeToFile();

            Console.WriteLine("Register Successful");

}       

        public void writeToFile()
        {

            string prepared = username + " " + password + "\n";
            string final_path = file_path + filename;

            File.AppendAllText(final_path, prepared);


        }


    }
}
