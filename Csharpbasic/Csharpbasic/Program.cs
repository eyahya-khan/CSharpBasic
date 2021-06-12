using System;//means that we can use 'classes' from the 'System' namespace.

namespace helloWorld // namespace organise code & is a container for class & other namespace
{
    class Program //class is a container for data & method
    {
        static void Main(string[] args)//all code under Main method will execute only.
        {
            //Console is a class of the System namespace
            //WriteLine() method that is used to output/print text
            //If you omit the using System line, you would have to write System.Console.WriteLine() to print/output text.
            //WriteLine() prints the output on a new line each time, while Write() prints on the same line.

            /*  Console.ReadLine() to get user input.
                ReadLine() always take string, if you want to take int must write
                wrong:int age = Console.ReadLine();
                correct:int age = Convert.ToInt32(Console.ReadLine());
            */

            //Char values are surrounded by single quotes
            //String values are surrounded by double quotes

            /*Type casting is when you assign a value of one data type to another type
            Implicit Casting (automatically) - converting a smaller type to a larger type size
                char -> int -> long -> float -> double

                Explicit Casting (manually) - converting a larger type to a smaller size type
                double -> float -> long -> int -> char 
            */
            /*String interpolation ($) was introduced in C# version 6.
                example:
                string firstName = "John";
                string lastName = "Doe";
                string name = $"My full name is: {firstName} {lastName}";
                Console.WriteLine(name); 
             */

            //break is used to jump out/stop condition
            //continue is used to skip current iteration of condition and continue with next iteration

            //useful array methods, such as Min, Max, and Sum, can be found in the System.Linq namespace
            //example: using System.Linq

            /*OOP is faster and easier to execute
                OOP provides a clear structure for the programs
                OOP helps to keep the C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain, modify and debug
                OOP makes it possible to create full reusable applications with less code and shorter development time
            
            A class is a template for objects, and an object is an instance of a class.
            When the individual objects are created, they inherit all the variables and methods from the class.   
            */

            /* An object is created from a class.
             example: Car myObj = new Car();

             Access variable/fields using dot(.)
             Console.WriteLine(myObj.color);

             Multiple object is created from one class    
                 Car myObj1 = new Car();
                 Car myObj2 = new Car();
             */
            /*
             constructor:

             */
            /*
            public void fullThrottle(){}  //public methods can only be accessed by objects.
            static void fullThrottle(){}  //static method can be accessed without creating an object of the class

            class Car 
                {
                  public string model; //public means this field can be used from other class
                  string color; //default is private and accessible only for that class not from other class.
                  public int year;
                  public void fullThrottle()
                  {
                    Console.WriteLine("The car is going as fast as it can!"); 
                  }
                }
            */
            /*
              .Encapsulation, is to make sure that "sensitive" data is hidden from users. 
              .private variables can only be accessed within the same class (an outside class has no access to it). However, sometimes we need to access them - and it can be done with properties.
              .A property is like a combination of a variable and a method, and it has two methods: a get and a set method
              .'get' for raed only where 'set' for write only.
            example: 
                https://www.w3schools.com/cs/cs_properties.php
             */

            /*
             Inheritance:
             .Car(child) class inherits field & method from Vehicle(parent) class
             .must use : before parent
             .If you don't want other classes to inherit from a class, use the 'sealed' keyword.
             */

            /*
             polymorphism:
             #adding the 'virtual' keyword to the method inside the base class, and by using the 'override' keyword for each derived class methods

            abstract:
            .Data abstraction is the process of hiding certain details and showing only essential information to the user.
            .Abstraction can be achieved with either abstract classes or interfaces.
            .The 'abstract' keyword is used for classes and methods
            .Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).
            .Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
            .To achieve security - hide certain details and only show the important details of an object.

            Interface:
             */
            /*
             enum (enumaration):
            .enum is a special "class" that represents a group of constants (unchangeable/read-only variables)
            .To create an enum, use the enum keyword (instead of class or interface), and separate the enum items with a comma
            .Use enums when you have values that you know aren't going to change, like month days, days, colors, deck of cards, etc.
            .enum first value is 0. The second has the value 1, and so on.One can assign value and then auto update the next value.
            .use in 'switch' case
             */
            /*
             file:
             .File class from the System.IO namespace, allows us to work with files
             
             exception:
             .try ... catch ... finally
             .catch (Exception e)
                {
                  Console.WriteLine(e.Message);
                }
             .Message is default message
             */



            /*
             //Switch case
              Console.WriteLine("Enter a day (1-7): ");
               int day = Convert.ToInt32(Console.ReadLine());
               //Console.WriteLine("Your age is: " + age);

              //int day = 4;
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
                      Console.WriteLine("It's not a number from 1-7");
                      break;
              }
              */
            /*
             //for loop with break/continue
            for (int i = 0; i < 10; i++) 
                {
                  if (i == 4) 
                  {
                    break;
                  }
                  Console.WriteLine(i);
                }

            for (int i = 0; i < 10; i++) 
                {
                  if (i == 4) 
                  {
                    continue;
                  }
                  Console.WriteLine(i);
                }

             */


            /*
             //while loop
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }
            */


            //array
            // Sort a string
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
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


        }
    }
}
