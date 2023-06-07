using System;
public class Yusuf
{
    public static void Main()
    {
        int number1, number2, number3;
        Console.Write("\n\n");
        Console.Write("Find the largest of three numbers:\n");
        Console.Write("------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input the 1st number :");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the  2nd number :");
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the 3rd  number :");
        number3 = Convert.ToInt32(Console.ReadLine());

        if (number1 > number2)
        {
            if (number1 > number3)
            {
                Console.Write($"The 1st Number is the greatest among three: {number1} \n\n");
            }
            else
            {
                Console.Write($"The 3rd Number is the greatest among three. {number3} \n\n");
            }
        }
        else if (number2 > number3)
            Console.Write($"The 2nd Number is the greatest among three: {number2} \n\n");
        else
            Console.Write($"The 3rd Number is the greatest among three: {number3} \n\n");
    }
}
