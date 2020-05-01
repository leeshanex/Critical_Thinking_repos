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
          
        }
        //Step 1
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
        }
        public void ForLoops5()
        {
            string word;
            word = "Hello World";
            for (int i = 0; i < word.Length; i++ )
            {
                Console.WriteLine(i);
            }
        }
        public void ForLoops6()
        {
            string word;
            word = "Hello World";
            for (int i = 0; i < word.Length; i++ )
            {
                Console.WriteLine((word[i]) + ",");
            }
        }
        public void ForLoops7()
        {
            string word;
            word = "Hello World";
            for (int i = 0; i < word.Length; i+=2)
            {
                Console.WriteLine((word[i]) + ",");
            }
        }
        public void ForLoops8()
        {
            string word;
            word = "Hello World";
            for (int i = 0; i < word.Length; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine((word[i]) + ",");
                }
            }
        }

    }
}
