using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critcal_Thinking_Excercises
{
    class ForLoops
    {
        public ForLoops()
        {
            ForLoops5();
        }
        public void ForLoops1()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
               if (i == 0 || i == 1 || i == 2 || i == 3)
                {
                    continue;
                }
           
                for(int j = 9; j >= 0; j--)
                {
                    if (j == 9 || j == 8 || j == 7 || j == 6 || j == 5)
                    {
                        continue;
                    }
                    Console.WriteLine(j);
                }
            }
            Console.ReadLine();
        }
        public void ForLoops4()
        {
            int userInput;
            Console.WriteLine("Please enter a postive integer");
            userInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
         
        }
        // REDO STEPS 5 - 8 with indexes not char
        public void ForLoops5()
        {
            string word;
            word = "Hello World";
            for (int i = 0; i < word.Length; i++ )
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        public void ForLoopsStep6()
        {
            string word;
            word = "Hello World";
            foreach (char c in word)
            {
                Console.WriteLine(c + ",");
            }

            Console.ReadLine();
        }
        public void ForLoopsStep7()
        {
            string word;
            word = "Hello World";
            foreach (char c in word)
            {
                Console.WriteLine(c + ",");
            }

            Console.ReadLine();

        }


    }
}
