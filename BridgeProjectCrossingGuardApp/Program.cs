using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProjectCrossingGuardApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare Variables
            String[] names = new string[15];
            String[] selectedNames = new string[5];

            bool runCondition = true;

            int nameCount = 15;

            string nameEntered = "empty";



            // Display welcome message

            Console.WriteLine("Welcome to the Crossing Guard Generator");
            Console.WriteLine();
            // Input - Get Last Names trap for duplicates/ display #of entries left


            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Please enter a last name");
                Console.WriteLine("you have "+nameCount+" entries left");
                nameEntered = Console.ReadLine();
               

                if (names.Contains(nameEntered))
                {
                    Console.WriteLine("You have entered a DUPLICATE PLEASE ENTER another name");
                    Console.WriteLine("you have " + nameCount + " entries left");
                    nameEntered = Console.ReadLine();
                }
                else
                {
                    names[i] = nameEntered;
                    nameCount--;
                }

            }


            //display list of names enetered

            Console.WriteLine("The Names Entered are: ");


            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //random select 5 names from names array

            Random random = new Random();

            Console.WriteLine("Thank you very much for volunteering. Each of you will get a chance to participate in the Crossing Guard program. The following five volunteers have been chosen for next weeks Crossing Guard positions: ");

            for (int i = 0; i < selectedNames.Length; i++)
            {

                int randomGenerated = random.Next(selectedNames.Length);
                //int randomGeneratedNotDuplicate;
                selectedNames[i] = names[randomGenerated];

                if (selectedNames.Contains(randomGenerated))
                {
                    selectedNames[i] = names[randomGenerated];
                }
                Console.WriteLine(selectedNames[i]);
            }

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);





        }
    }
}
