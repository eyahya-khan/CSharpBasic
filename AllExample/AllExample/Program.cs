using System;
using System.Linq;

namespace AllExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //basic example
            //Console.WriteLine("Hello World!");

            //######### VARIABLE #########
            //create string variable
            /*string name = "John";
            Console.WriteLine(name);*/

            //create int variable
            /*int myNum = 15;
            Console.WriteLine(myNum);*/

            //create variable assinging value later
            /*int myNum;
            myNum = 15;
            Console.WriteLine(myNum);*/

            //overwrite value
            /*int myNum = 15;
            myNum = 20;
            Console.WriteLine(myNum);*/

            //combine text & variable
            /*string name = "John";
             Console.WriteLine("Hello " + name);*/

            //add variable with another variable
            /*string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);*/

            //declare many variable
            /*int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);*/

            //######### DATA TYPE #########
            /* int myNum = 5;               // integer (whole number)
             double myDoubleNum = 5.99D;  // floating point number
             char myLetter = 'D';         // character
             bool myBool = true;          // boolean
             string myText = "Hello";
             long myNumLong = 15000000000L;  //long type
             Console.WriteLine(myNum);// string
             Console.WriteLine(myDoubleNum);
             Console.WriteLine(myLetter);
             Console.WriteLine(myBool);
             Console.WriteLine(myText);
             Console.WriteLine(myNumLong);*/

            //######### TYPE CASTING #########
            /* int myInt = 10;
             double myDouble = 5.25;
             bool myBool = true;
             Console.WriteLine(Convert.ToString(myInt));    // Convert int to string
             Console.WriteLine(Convert.ToDouble(myInt));    // Convert int to double
             Console.WriteLine(Convert.ToInt32(myDouble));  // Convert double to int
             Console.WriteLine(Convert.ToString(myBool));   // Convert bool to string
            */

            //######### USER INPUT #########
            // Type your username and press enter
            /*Console.WriteLine("Enter username:");*/
            // Create a string variable and get user input from the keyboard and store it in the variable
            /*string userName = Console.ReadLine();*/
            // Print the value of the variable (userName), which will display the input value
            /*Console.WriteLine("Username is: " + userName);*/

            //user input number
            /*Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);*/

            //######### MATH #########
            /*Console.WriteLine(Math.Max(5, 10));
            Console.WriteLine(Math.Min(5, 10));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine(Math.Round(9.99));*/

            //######### STRING #########
            //string length
            /*string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the txt string is: " + txt.Length);*/
            //convert UPPERCASE and lowercase
            /*string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"
            */
            //normal concatenation
            /*string firstName = "John ";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);*/

            //using Concat() method
            /*string firstName = "John ";
            string lastName = "Doe";
            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);*/

            //interpolation
            /*string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);*/

            //access character in a string by index number
            /*string myString = "Hello";
            Console.WriteLine(myString[0]);*/

            //access character position in a string by indexof() method
            /*string myString = "Hello";
            Console.WriteLine(myString.IndexOf("e"));*/

            //substring and indexof() display specific part of string
            // Full name
            /*string name = "John Doe";*/
            // Location of the letter D
            /*int charPos = name.IndexOf("h");*/
            // Get last name
            /*string lastName = name.Substring(charPos);*/
            // Print the result
            /*Console.WriteLine(lastName);*/

            //quote of string
            /*string txt = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt);*/

            //######### if ... else if ... else #########
            /*int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }*/

            //######### SWITCH CASE #########
            /*int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }*/


            //######### LOOP #########
            //while loop
            /*int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }*/

            //do while loop
            /*int i = 0;
             do
             {
                 Console.WriteLine(i);
                 i++;
             }
             while (i < 5);*/

            //for loop
            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }*/

            //foreach loop
            /*string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }*/

            //break
            /*for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }*/

            //continue
            /*for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }*/

            //######### ARRAYS #########
            //create array
            /*string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);*/

            //change array element
            /*string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);*/

            //array length
            /*string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars.Length);*/

            //for loop in array
            /*string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }*/

            //foreach loop in array
            /*string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }*/

            //sorting array
            // Sort a string
            /*string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }
            */

            //System.Linq
            /*int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // largest value
            Console.WriteLine(myNumbers.Min());  // smallest value
            Console.WriteLine(myNumbers.Sum());  // sum of myNumbers
            */

        }
    }
}
