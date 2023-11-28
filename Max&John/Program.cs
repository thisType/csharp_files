
using Max_John;

Console.WriteLine("1.Register\n2.Login\n3.Admin\n4.Exit");

bool exit_program = false;
 string user_input = String.Empty;

Register register = new Register();
Login login = new Login();
Admin admin = new Admin();  
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
                admin.LoginAdmin();
            break;
        case "4":
            exit_program = true;
             break;
         default:
        Console.WriteLine("Invalid Choice!");
        break;


}
