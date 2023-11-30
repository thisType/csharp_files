using Max_John.Controllers;
using Max_John.Services;
using Model;
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
       


        public SelectionOrder(int id) { 

            this.user_id = id;
        }



        public void OrderBook()
        {
            while (true)
            {
                 var bookModels = ListBooks();

                Console.WriteLine("Select Book");

                  string selection = Console.ReadLine();
                 
                  int selection_int = Convert.ToInt32(selection);

                if (selection_int > 0 && selection_int <= bookModels.Length) {

                    BookModel bookModel = bookModels[selection_int - 1];


                    int book_id = Convert.ToInt32(bookModel.id);

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

            Console.WriteLine("1.Buy Book\n2.Ignore\n");

            string selection = Console.ReadLine();

            switch (selection)
            {
                case "1":
                    Controller controller = new Controller();
                    controller.MakeOrder(this.user_id,book_id);
                    Console.WriteLine("Payment Successful");
                    break;
                    case "2":
                    Console.WriteLine("Ignored payments!");
                    break;

            }



        }

        public BookModel [] ListBooks()

        {
            Controller controller = new Controller();

             BookModel[] models = controller.ListBooks();
            int i = 1;
            foreach (BookModel model in models)
            {
                  Console.WriteLine($"{i}.  {model.name} {model.description} ");
                  ++i;

            }
            return models;



        }










    }
}
