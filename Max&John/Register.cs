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


        public void registerUser()
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


            string final_path = file_path + "\\" + filename;
            int id = GetNewId();
            string prepared = id + "," + username + "," + password + "\n";
            File.AppendAllText(final_path, prepared);


        }
        public int GetNewId()
        {
            string final_path = file_path + "\\" + filename;

            if (File.Exists(final_path))
            {
                var lines = File.ReadAllLines(final_path);

                var line = lines[lines.Length - 1];

                string lastuser_id = line.Split(',')[0];
                int id = Convert.ToInt32(lastuser_id);
                return ++id;

            }
            else
            {

                return 1;
            }

        }
    }
}
