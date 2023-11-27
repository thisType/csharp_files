
using Max_John;

Console.WriteLine("1.Register\n 2.Login \n 3.Exit\n");

bool exit_program = false;
 string user_input = String.Empty;

Register register = new Register();
Login login = new Login();  
   
    Console.WriteLine("input:");


      user_input = Console.ReadLine();
   // check user input
    switch (user_input)
    {
        case "1":

            register.registerUser();
            exit_program = true;
            break;
        case "2":
            login.loginUser();
            exit_program = true;
            break;
          case "3":
            exit_program = true;
            break;
}
