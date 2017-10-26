using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_10._24._17
{
    class Program
    {
        static void Main(string[] args)
        {
            bool next = true;
            while (next == true)
            {
                Console.WriteLine("What is your first name? ");
                string firstName = Console.ReadLine();
                Console.WriteLine(firstName + "- What a nice name! Enter an integer between 1-100: ");
                string input = Console.ReadLine();
                int myInt = 0;


                if (!int.TryParse(input, out myInt))
                {
                    Console.WriteLine(" Invalid Entry: You must enter an integer. Let's try again.  ");
                    continue;
                }
                else if (myInt <= 0 || myInt > 100)
                {
                    Console.WriteLine("Invalid Entry: Your entry is outside of the range 1 - 100. Try again. ");
                    continue;
                }

                else if (true && myInt % 2 != 0)//is the integer an odd number?
                {
                    Console.WriteLine(firstName + " The number you entered is odd " + myInt);
                }
                else if (myInt % 2 != 0 && myInt > 60)
                {
                    Console.WriteLine(firstName + " The number you entered is odd " + myInt);
                }

                else if (myInt % 2 == 0 && myInt <= 25)
                {
                    Console.WriteLine(firstName + " The number you entered is even and less than 25 ");
                }

                else if (myInt > 26 && myInt < 60)
                {
                    Console.WriteLine(firstName + " Even ");
                }

                else if (myInt > 60)
                {
                    Console.WriteLine(firstName + " The number is even " + myInt);
                    next = Option();
                }
                

            }
        }    

           /* private static bool Option()
            {
                bool repeat;
                Console.WriteLine("Would you like to exit the program? (yes or no :");
                string yesno = Console.ReadLine();
                yesno = yesno.ToLower();
                

                if (yesno == "yes")
                {
                    repeat = false;
                }
                else if (yesno == "no")
                {
                    repeat = true;
                }
                else
                {
                    Console.WriteLine("This isn't rocket science. You have to answer yes or no. Try again");
                    repeat = Option();    
                }
            
            }*/     
        
    }
}
