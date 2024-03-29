using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000 *
        


            //Write a method that will print to the console numbers 3 through 999 by 3 each time *

            //Write a method to accept two integers as parameterss and check whether they are equal or not *

            //Write a method to check whether a given number is even or odd *

            //Write a method to check whether a given number is positive or negative *

            //Write a method to read the age of a candidate and determine whether they can vote. *
            //Hint: Use Parse or the safer TryParse() for an extra challenge
            //Parse()
            //TryParse()
        
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10 *
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            CountBig();
            SkipByThree();
           Console.WriteLine(IsEqual(4, 8));
           Console.WriteLine(IsEven(5));
            Console.WriteLine(IsPos(4));
            Console.WriteLine(VoterAge(15));
           
           
            Console.WriteLine(Num(7));
            Loop(5);
        }
        public static void SkipByThree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void CountBig()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static bool IsEqual(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            {
                return false;
            }
           
        }

        public static bool IsEven(int a)
        {
            if (a % 2 == 0) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public static bool IsPos(int a)
        {
            if(a >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
        public static bool VoterAge(int a)
        {
            if(a >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }

        
        }

        public static bool Num(int a)
        {
            if(a <= 10 && a >= -10) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public static void Loop(int a)
        {
            for(int i = 0; i <=12; i++)
            {
                Console.WriteLine(i * a);
            }
        }

    }
}
