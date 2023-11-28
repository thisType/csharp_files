using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_John
{
    internal class SelectionOrder
    {

        int  user_id = 0;
        string file_path = Directory.GetCurrentDirectory();
        string file_book = "book.txt";
        string file_orders = "orders.txt";


        public SelectionOrder(int id) { 

            this.user_id = id;
        }



        public void OrderBook()
        {
            while (true)
            {
                 var lines = ListBooks();

                Console.WriteLine("Select Book");

                  string selection = Console.ReadLine();
                 
                  int selection_int = Convert.ToInt32(selection);

                if (selection_int > 0 && selection_int <= lines.Length
                    ) {

                    string selected_line = lines[selection_int - 1];

                    var selected_line_array = selected_line.Split(",");

                    int book_id = Convert.ToInt32(selected_line_array[0]);

                    MakeOrder(book_id);
                    break;

                
                
                } else
                {
                    Console.WriteLine("Wrong Selection");
                }






            }




        }   
        
        public void MakeOrder(int book_id)
        {

            string final_order_path = file_path + "\\" + file_orders;
            Console.WriteLine("1.Buy Book\n2.Ignore\n");

            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    File.AppendAllText(final_order_path, this.user_id + " "+ book_id + "\n");
                    Console.WriteLine("Payment Successful");
                    break;
                    case "2":
                    Console.WriteLine("Ignored payments!");
                    break;

            }



        }

        public String [] ListBooks()
        {
            string final_book_path = file_path + "\\" + file_book;

            var lines = File.ReadAllLines(final_book_path);
            int i = 1;
            foreach (var line in lines)
            {
                var lines_split = line.Split(",");
                  Console.WriteLine($"{i}.  {lines_split[1]} {lines_split[2]} ");
                  ++i;

            }
            return lines.ToArray();



        }










    }
}
