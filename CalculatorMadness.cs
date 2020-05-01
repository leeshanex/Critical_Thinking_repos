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
        public void AddTwoNumbers(int numberOne, int numberTwo)
        {
            Console.WriteLine("Please enter the first number:");
            numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            numberTwo = int.Parse(Console.ReadLine());
            int result = numberOne + numberTwo;
            Console.WriteLine("The result of this addition is:" + result);
        }
        public void RunCalculations()
        {
            AddTwoNumbers(5,7);
        }

    }
}
