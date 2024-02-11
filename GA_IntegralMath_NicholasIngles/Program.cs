// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exploring C# Integral Types and Math Operations");
        // Additional implementation will follow

        int myInt = 2147483647; // Int32: -2,147,483,648 to 2,147,483,647, most common used for general and basic counting
        long myLong = 9223372036854775807; // Int64: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807, big big numbers
        byte myByte = 255; // Byte: 0 to 255, used for small and manipulatable data
        short myShort = 32767; // Int16: -32,768 and 32,767, middle-sized for when int is too much

        int sum = myInt + 100; // Addition: Combines two numbers into a larger sum.
        int difference = myInt - 50; // Subtraction: Removes a quantity from another.
        int product = myShort * 2; // Multiplication: Scales a number by another number.
        int quotient = myInt / 2; // Division: Splits a number into equal parts.
        int remainder = myByte % 10; // Modulus: Finds the remainder after division.

        int result1 = 5 + 3;
        int result2 = 10 - 4;
        int result3 = 7 * 2;
        int result4 = 20 / 4;
        int result5 = 9 % 2;
        int result6 = 15 + 6;
        int result7 = 12 - 7;
        int result8 = 4 * 3;
        int result9 = 30 / 5;
        int result10 = 16 % 3;
        int result11 = 8 + 10;
        int result12 = 20 - 8;
        int result13 = 6 * 7;
        int result14 = 45 / 9;
        int result15 = 25 % 4;

        Console.WriteLine("\n5 + 3 = " + result1);
        Console.WriteLine("10 - 4 = " + result2);
        Console.WriteLine("7 * 2 = " + result3);
        Console.WriteLine("20 / 4 = " + result4);
        Console.WriteLine("9% % 2 = " + result5);
        Console.WriteLine("15 + 6 = " + result6);
        Console.WriteLine("12 - 7 = " + result7);
        Console.WriteLine("4 * 3 = " + result8);
        Console.WriteLine("30 / 5 = " + result9);
        Console.WriteLine("16 % 6 = " + result10);
        Console.WriteLine("8 + 10 = " + result11);
        Console.WriteLine("20 - 8 = " + result12);
        Console.WriteLine("6 * 7 = " + result13);
        Console.WriteLine("45 / 9 = " + result14);
            Console.WriteLine("25 % 4 = " + result15);


        int x = 42;
        int y = 7;
        int z = 100;

        int complex1 = (x + 3) / 8;
        int complex2 = (y + 24) - (13 + 51);
        int complex3 = 30 + ((z * 60) / 10);
        int complex4 = ((x + y) * z) / y;

        Console.WriteLine("\n(x + 3) / 8 = " + complex1);
        Console.Write("x = ");
        string answer1 = Console.ReadLine();

        Console.WriteLine("\nYour answer: " + answer1);
        Console.WriteLine("Correct answer: " + x);

        Console.WriteLine("\n(y + 24) - (13 + 51) = " + complex2);
        Console.Write("y = ");
        string answer2 = Console.ReadLine();

        Console.WriteLine("\nYour answer: " + answer2);
        Console.WriteLine("Correct answer: " + y);

        Console.WriteLine("\n30 + ((z * 60) / 10) = " + complex3);
        Console.Write("z = ");
        string answer3 = Console.ReadLine();

        Console.WriteLine("\nYour answer: " + answer3);
        Console.WriteLine("Correct answer: " + z);

        Console.Write("\n((x + y) * z) / y = ");
        string answer4 = Console.ReadLine();

        Console.WriteLine("\nYour answer: " + answer4);
        Console.WriteLine("Correct answer: " + complex4);

    }
}