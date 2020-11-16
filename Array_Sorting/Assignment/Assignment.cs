using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessGame
{
    public class Assignment
    {
        public static void Work()
        {
            //TODO: Write your code here
            //Display the Array 
            var input = GenerateArray();

            DisplayInts(input);

            //Implementation

            //TODO: Count total number of times a user selected number from 1 - 10 occurs in the array
            
        }


        #region Hidden
        static void DisplayInts(int[] values)
        {
            int num0 = 0, num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0, num10 = 0;
            var strValues = values.Select(v => v.ToString());
            var stringlist = String.Join(", ", strValues);
            var sum = stringlist;
            Console.WriteLine($"Numbers: [ {stringlist} ]");
            foreach(var number in values)
            {
                if(number == 0)
                {
                    num0++;
                }
                if (number == 1)
                {
                    num1++;
                }
                 if (number == 2)
                {
                    num2++;
                }
                 if (number == 3)
                {
                    num3++;
                }
                 if (number == 4)
                {
                    num4++;
                }
                 if (number == 5)
                {
                    num5++;
                }
                 if (number == 6)
                {
                    num6++;
                }
               if (number == 7)
                {
                    num7++;
                }
                if (number == 8)
                {
                    num8++;
                }
                else if (number == 9)
                {
                    num9++;
                }
                 if (number == 10)
                {
                    num10++;
                }
            }
            Console.WriteLine($"Number 0 are {num0} ");
            Console.WriteLine($"Number 1 are {num1} ");
            Console.WriteLine($"Number 2 are {num2} ");
            Console.WriteLine($"Number 3 are {num3} ");
            Console.WriteLine($"Number 4 are {num4} ");
            Console.WriteLine($"Number 5 are {num5} ");
            Console.WriteLine($"Number 6 are {num6} ");
            Console.WriteLine($"Number 7 are {num7} ");
            Console.WriteLine($"Number 8 are {num8} ");
            Console.WriteLine($"Number 9 are {num9} ");
            Console.WriteLine($"Number 10 are {num10} ");
            

            sum.GetEnumerator();
            Console.ReadLine();
        }
        static int[] GenerateArray()
        {
            int Min = -1;
            int Max = 11;
            Random randNum = new Random();
            int[] values = Enumerable
                .Repeat(0, 50)
                .Select(i => randNum.Next(Min, Max))
                .ToArray();

            return values;
        }
       
        #endregion
    }
}
