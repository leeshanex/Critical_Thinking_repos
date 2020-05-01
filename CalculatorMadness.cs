﻿using System;
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
            RunCalculations();
        }
        //Step 2
        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;
            Console.WriteLine("The result of this addition is:" + result);
            return result;
        }
        public int SubtractTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne - numberTwo;
            Console.WriteLine("The result of this subtraction is:" + result);
            return result;
        }
        public int MultiplyTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne * numberTwo;
            Console.WriteLine("The product of this multiplication is:" + result);
            return result;
        }
        public int DivideTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne / numberTwo;
            Console.WriteLine("The quotient of this division is:" + result);
            return result;
        }

        public void RunCalculations()
        {
            AddTwoNumbers(8, 40);
            AddTwoNumbers(200, 50);
            Console.WriteLine("Enter first number to add:");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number to add:");
            int value2 = int.Parse(Console.ReadLine());
            int output = AddTwoNumbers(value1, value2);
            Console.WriteLine("The result is: " + output);
        }
        
    }
}
