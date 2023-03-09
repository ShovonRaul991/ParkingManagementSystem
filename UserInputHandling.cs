using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagementSystem
{
    class UserInputHandling
    {
        public static int UserInput(string input)
        {
            bool invalidInput = true;
            int enteredNumber = 0;

            while (invalidInput)
            {
                try
                {
                    Console.Write("Enter the number of {0} ", input);
                    enteredNumber = Convert.ToInt32(Console.ReadLine());
                    if (enteredNumber < 0)
                    {
                        Console.WriteLine("Entered input is wrong: ");
                        continue;
                    }
                    invalidInput = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The error message is: " + ex.Message);
                }

            }
            return enteredNumber;

        }

    }
}
