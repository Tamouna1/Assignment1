using System;
using System.Transactions;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //N1

            Console.WriteLine("Name: ");
            String name = Console.ReadLine();

            Console.WriteLine("Surname: ");
            String surname = Console.ReadLine();

            Console.WriteLine("Your name is: " + name + " " + surname);

            //N2

            Console.WriteLine("Number 1 : ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number 2 : ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int sum = number1 + number2;
            int subtraction = number1 - number2;
            int division = number1 / number2;
            int multiply = number1 * number2;
            int remainder = number1 % number2;
            Console.WriteLine("Sum is: " + sum + "\n" + "Substraction: " + subtraction + "\n" + "Division : " + division + "\n" +
                "Multiply : " + multiply + "\n" + "Remainer : " + remainder);

            //3
            Console.WriteLine("Enter x : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int x2 = y;
            int y2 = x;
            


            Console.WriteLine( "x is: " + x2);
            Console.WriteLine("y is: " + y2);


            //4
            Console.WriteLine("Enter number 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 4: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((a + b + c + d) / 4);

            //5
            Console.WriteLine("Enter Kelvin : ");
            double kelvin = Convert.ToInt32(Console.ReadLine());
            double toCelcius = kelvin - 273.15;

            Console.WriteLine("Celsius is: " + toCelcius);

            //6
            Console.WriteLine("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
             if(num > 0)
            {
                Console.WriteLine("Number is Positive");
            }
            else
            {
                Console.WriteLine("Number is Negative");
            }

            //7

            Console.WriteLine("Enter number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 - num2 > 0 && num1 - num3 > 0)
            {
                Console.WriteLine("Max is: " + num1);

            }
            if (num2 - num1 > 0 && num2 - num3 > 0)
            {
                Console.WriteLine("Max is: " + num2);

            }
            if (num3 - num2 > 0 && num1 - num1 > 0)
            {
                Console.WriteLine("Max is: " + num3);

            }
            if (num1 - num2 < 0 && num1 - num3 < 0)
            {
                Console.WriteLine("Min is: " + num1);

            }
            if (num2 - num1 < 0 && num2 - num3 < 0)
            {
                Console.WriteLine("Min is: " + num2);

            }
            if (num3 - num2 < 0 && num3 - num1 < 0)
            {
                Console.WriteLine("Min is: " + num3);

            }

            //8

            Console.WriteLine("Enter number 1:");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2:");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            if(firstNum == secondNum)
            {
                Console.WriteLine("Result :" + firstNum * 3 , secondNum * 3) ;
            }else
            {
                Console.WriteLine("Numbers are not equal");
            }

            //9

            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 7 == 0)
            {
                Console.WriteLine("Correct Number");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            //10

            Console.WriteLine("Enter number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber.ToString().Contains(5.ToString()))
            {
                Console.WriteLine("Contains 5");
            }
            else
            {
                Console.WriteLine("Does not contain 5");
            }


            //11

            Console.WriteLine("Enter Number : ");
            int numbers = Convert.ToInt32(Console.ReadLine());
            string[] numberArray = new string[numbers.ToString().Length];
            int counter = 0;

            for (int i = 0; i < numbers.ToString().Length; i++)
            {
                numberArray[i] = numbers.ToString().Substring(counter, 1); 
                counter++;
            }

            Console.WriteLine(string.Join(" ", numberArray));







        }
    }
}