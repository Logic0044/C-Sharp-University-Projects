using System;
public class Yusuf
{
    public static void Main()
    {
        int num;
        Console.Write("\n\n");
        Console.Write("Check whether a number is positive or negative:\n");
        Console.Write("----------------------------------------------");
        Console.Write("\n\n");
        Console.Write("Input an integer : ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num >= 0)

            Console.WriteLine("{0} is a positive number.\n", num);
        else
            Console.WriteLine("{0} is a negative number. \n", num);
    }
}
