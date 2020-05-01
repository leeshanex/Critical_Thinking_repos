using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critcal_Thinking_Excercises
{
    class CalculatorMadness
    {
        //Fun with Methods
        public CalculatorMadness()
        {
           
        }
        //Step 2
        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            Console.WriteLine("Please enter the first number:");
            numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            numberTwo = int.Parse(Console.ReadLine());
            int result = numberOne + numberTwo;
            Console.WriteLine("The result of this addition is:" + result);
            return result;
        }
        public void RunCalculations()
        {
            Console.WriteLine("Enter first number to add:");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number to add:");
            int value2 = int.Parse(Console.ReadLine());
            int output = AddTwoNumbers(value1, value2);
            Console.WriteLine("The result is: " + output);
        }

    }
}
