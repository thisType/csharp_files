
using Assessment3.Controllers;

Console.WriteLine("Welcome");


Controller controller = new Controller();
     while (true)
     {


    controller.ListUsers();


    Console.WriteLine("1.List users \n 2. Exit.");

      string selection = Console.ReadLine();

      if(selection != null && selection == "2") {

        Console.WriteLine("Exiting");
        break;
    
    
    }



}
