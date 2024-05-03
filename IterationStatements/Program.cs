namespace IterationStatements
{
    public class Program
    {


        static void Main(string[] args)
        {
            PrintThousand();
        }
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Threes() 
        {
            for (int k = 3; k <= 999; k += 3) 
            {
                Console.WriteLine(k);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool IsEqual(int a, int b) 
        {
            if (a == b)
            {
                return true;
            }
            else 
            {
                return false;
            }

        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int number) 
        {
            if (number % 2 == 0) 
            {
                Console.WriteLine($"yo that's even");
            }
            else 
            {
                Console.WriteLine($"definitely odd");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static bool IsPositive(int num1) 
        {
            if (num1 > 0) 
            {
                return true;
            }

            return false;
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        public static bool OfVotingAge(int age) 
        {
            if (age >= 18)
            {
                Console.WriteLine($"Yes they are of voting age");
                return true;
            }
            else 
            {
                Console.WriteLine("$Too young to vote by {18 - age} years");
                return false;
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool IsTenRange(int num) 
        {
            if (num <= 10 && num >= -10) 
            {
                return true;
            }
            return false;
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable(int number) 
        {
            for (int i = 1; i < 12; i++) 
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}
