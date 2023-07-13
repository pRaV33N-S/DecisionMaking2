using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "papaJohn";
            string passWord = "afraidOfMamaJohn";
            int loop = 3;
            do
            {
                Console.WriteLine("Enter the UserName");
                string givenUserName = Console.ReadLine();
                Console.WriteLine("Enter the Password");
                string givenPassword = Console.ReadLine();
                
                if (userName.Equals(givenUserName) && passWord.Equals(givenPassword))
                {
                    Console.WriteLine("Login Successfull");
                    break;
                }
                else if (userName.Equals(givenUserName) && !passWord.Equals(givenPassword))
                {
                    Console.WriteLine("Invalid Password");
                    loop--;
                    Console.WriteLine($"You have {loop} remaining attempts");
                }
                else if (!userName.Equals(givenUserName) && passWord.Equals(givenPassword))
                {
                    Console.WriteLine("Invalid UserName");
                    loop--;
                    Console.WriteLine($"You have {loop} remaining attempts");
                }
                else
                {
                    Console.WriteLine("Invalid UserName and Password");
                    loop--;
                    Console.WriteLine($"You have {loop} remaining attempts");
                }
            } while (loop > 0);
            Console.WriteLine("Login Failed");
        }
    }
}
