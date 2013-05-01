using System;

class checkPalindrom
{
    static void Main()
    {
        int number, numberSafe;
        string numberTwo="",s;
        Console.Write("Enter number to check:");
        number = int.Parse(Console.ReadLine());
        numberSafe = number;
        while (number != 0)
        {
           s= Convert.ToString(number % 10);
           numberTwo = numberTwo + s;
           number /= 10;
        }
        if (int.Parse(numberTwo) == numberSafe) Console.WriteLine("True");
        else Console.WriteLine("False");
    }
}
