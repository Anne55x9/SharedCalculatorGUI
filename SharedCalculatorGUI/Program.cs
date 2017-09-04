using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalculatorGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var cal = new SharedCalculator.Lommeregner();


            //use for the string operation choice
            int operation = 0;
            //stock the result of the operation
            double result = 0;

            //Ask user first number
            Console.WriteLine("Type you first number :");
            string stringFirstNumber = Console.ReadLine();
            double firstNumber = Convert.ToDouble(stringFirstNumber);

            //Ask user second number
            Console.WriteLine("Type you second number :");
            string stringSecondNumber = Console.ReadLine();
            double secondNumber = Convert.ToDouble(stringSecondNumber);

            //Ask user operation to use
            Console.WriteLine("Enter the operation + (addition), - (subtraction), * (multiplication), / (division), ^ (exposant) or % (reste) :");
            string stringOperation = Console.ReadLine();

            // Convert string choice to integral
            if (stringOperation == "+" || stringOperation == "addition")
            {
                operation = 1;
            }
            else if (stringOperation == "-" || stringOperation == "subtraction")
            {
                operation = 2;
            }
            else if (stringOperation == "*" || stringOperation == "multiplication")
            {
                operation = 3;
            }
            else if (stringOperation == "/" || stringOperation == "division")
            {
                operation = 4;
            }
        

            switch (operation)
            {
                case 1:
                    result = cal.addition(firstNumber, secondNumber);
                    break;

                case 2:
                    result = cal.subtraction(firstNumber, secondNumber);
                    break;

                case 3:
                    result = cal.multiplication(firstNumber, secondNumber);
                    break;

                case 4:
                    result = cal.division(firstNumber, secondNumber);
                    break;
            }

           
            Console.WriteLine("\nResult of " + firstNumber + " " + stringOperation + " " + secondNumber + " = " + result + ".");

            
            Console.ReadKey();


        }
    }
}
