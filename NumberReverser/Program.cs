using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberReverser
{
    class Program
    {
        public static void printDirections()
        {
            Console.WriteLine("Welcome to the Four Digit Number Reversing Machine (FDNRM)!");
            Console.WriteLine("");
            Console.WriteLine("In a moment you will be prompted for a four digit number.");
            Console.WriteLine("");
            Console.WriteLine("This program will quickly take your four digit number, reverse it, then display the number you entered as well as the reverse.");
            Console.WriteLine("");
        }
        public static int getInt()
        {
            int n1 = 0;
            String input = "";
            Console.WriteLine("Please enter an integer: ");
            input = Console.ReadLine();
            n1 = Convert.ToInt32(input);
            return n1;
        }
        public static int revNum(int uNum)
        {
            int resultOfReversingNum = 0;
            int digit1 = 0;
            int digit2 = 0;
            int digit3 = 0;
            int digit4 = 0;

            digit4 = uNum % 10;
            uNum = uNum / 10;
            digit3 = uNum % 10;
            uNum = uNum / 10;
            digit2 = uNum % 10;
            uNum = uNum / 10;
            digit1 = uNum % 10;
            uNum = uNum / 10;
            digit4 = digit4 * 1000;
            digit3 = digit3 * 100;
            digit2 = digit2 * 10;

            resultOfReversingNum = digit1 + digit2 + digit3 + digit4;

            return resultOfReversingNum;

        }
        public static void printResults(int uNum, int rNum)
        {
            Console.WriteLine("");
            Console.WriteLine("The number you entered was : " + uNum);
            Console.WriteLine("Your number reversed is : " + rNum);
            Console.WriteLine("");
            Console.WriteLine("Thank you for using the Four Digit Number Reversing Machine (FDNRM)!");
            Console.WriteLine("");
        }
        public static void fourDigitNumReverse()
        {
            int userNum = 0;
            int reversedNum = 0;

            printDirections();

            Console.WriteLine("Please remember to enter only a four digit number with no other symbols or characters!");
            Console.WriteLine("");

            userNum = getInt();

            while ( (userNum < 1000) || (userNum > 9999))
                {
                Console.WriteLine("");
                Console.WriteLine("The number you entered is invalid. Remember, the number must be 4 digits. Please try again.");
                Console.WriteLine("");
                userNum = getInt();
                }

            reversedNum = revNum(userNum);

            printResults(userNum, reversedNum);
        }

        static void Main(string[] args)
        {
            fourDigitNumReverse();
        }
    }
}
