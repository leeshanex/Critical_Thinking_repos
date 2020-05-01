using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critcal_Thinking_Excercises
{
    class WhileLoop
    {
        public WhileLoop()
        {
            WhileLoops2();
        }
        //Step 1
        public void WhileLoops1()
        {
            int counter = 5;
            while (counter < 25)
            {
                counter++;
            }
            // loop will run 5 times because we are incrementing by 5's
            // this loop 
        }
        //step 2
        public void WhileLoops2()
        {
            
            int userInput;
            Console.WriteLine("Please enter a positive integer below 25");
            userInput = Convert.ToInt32(Console.ReadLine());
            int counter = userInput;
            bool validInput = false;
            while (!validInput && counter < 25)
            {
                    if (counter > 0)
                    {
                        counter++;
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input, please try again");
                    }

            }
        }
        public void WhileLoops3()
        {

        }
    }
}
