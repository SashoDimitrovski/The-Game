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
                    
                    if (!(email[i].Length > 0 ))
                    {
                        Console.WriteLine("You didn't enter your email!");
                        continue;
                    }
                   if(!(email[i] == "bob22@mail.com"))
                    {
                        Console.WriteLine("Please write your correct email!");
                        continue; 
                    }
                   if(!(email[i] == "saso.dimitrovski@yahoo.com"))
                    {
                        Console.WriteLine("Please write your correct email!");
                        continue;
                    }
                   if(!(email[i].Contains("@")))
                    {
                        Console.WriteLine("Your email must contain @!");
                        continue;
                    }
                    if (!(email[i].Contains(".com")))
                    {
                        Console.WriteLine("Your email must contain .com!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Enter your password");
                    }

                    
                    
                }
                Console.ReadLine();
            }
            
            
        }
    }
}
