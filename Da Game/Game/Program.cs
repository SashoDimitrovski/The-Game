using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string[] email = new string[2];
                email[0] = "bob22@mail.com";
                email[1] = "saso.dimitrovski@yahoo.com";
                string[] password = new string[2];
                password[0] = "bobbest";
                password[1] = "saso123";
                Console.WriteLine("Enter your E-mail:");
                string emailInput = Console.ReadLine();
                for (int i = 0; i < email.Length; i++)
                {
                    
                    if (email[i].Length > 0 && email[i] == "bob22@mail.com" || email[i] == "saso.dimitrovski@yahoo.com" && email[i].Contains("@") && email[i].Contains("."))
                    {
                        Console.WriteLine("Enter your password:");
                        string passwordInput = Console.ReadLine();
                        for (int j = 0; j < passwordInput.Length; j++)
                        {
                            if (password[i] == "bobbest" || password[i] == "saso123")
                            {
                                Console.WriteLine("Welcome " + email[i]);
                            }
                            
                        }
                        
                        Console.WriteLine("Press Enter to start with character creation...");
                    }
                    else
                    {
                        Console.WriteLine("Please try again!");
                    }
                    Console.ReadLine();
                }
            }
            
            
        }
    }
}
