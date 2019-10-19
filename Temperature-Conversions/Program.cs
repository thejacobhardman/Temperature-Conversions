using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            int mode = 0;
            double result, input;

            do
            {
                bool userConfirm = false;

                Console.WriteLine("Welcome to Temperature Conversions! \nPlease make a selection.");
                Console.WriteLine("1. Fahrenheit to Celsius \n2. Celsius to Fahrenheit \n3. Exit");

                while (userConfirm == false)
                {
                    Console.Write("Enter Choice: ");
                    mode = Convert.ToInt32(Console.ReadLine());
                    if (mode > 0 && mode < 4)
                    {
                        userConfirm = true;
                    } else
                    {
                        Console.WriteLine("Please enter a valid selection.");
                    }
                }

                if (mode == 1)
                {
                    Console.WriteLine();
                    Console.Write("Enter Fahrenheit Temperature: ");

                    input = Convert.ToDouble(Console.ReadLine());
                    result = CalculateTemp(mode, input);

                    Console.WriteLine(input + " Fahrenheit is " + result + " Celsius");
                    Console.WriteLine();
                } else if (mode == 2)
                {
                    Console.WriteLine();
                    Console.Write("Enter Celsius Temperature: ");

                    input = Convert.ToDouble(Console.ReadLine());
                    result = CalculateTemp(mode, input);

                    Console.WriteLine(input + " Celsius is " + result + " Fahrenheit");
                    Console.WriteLine();
                }

            } while (mode != 3);

            Console.WriteLine("Press any key to close the program.");
            Console.ReadKey();
        }

        static double CalculateTemp(int mode, double input)
        {
            double temp = 0;

            switch (mode)
            {
                case 1:
                    temp = 5.0 / 9.0 * (input - 32.0);
                    break;
                case 2:
                    temp = 9.0 / 5.0 * (input + 32.0);
                    break;
            }

            temp = Math.Round(temp, 1);

            return temp;
        }
    }
}
