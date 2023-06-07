using System;

class Yusuf
{
    static void Main()
    {

        const int MAX = 10;
        int totalcredit = 0;
        int y = 0;
        double Schedulegpa = 0;
        double gpa;
        string[] ScheduleGrades = new string[MAX];

        while (true)
        {
            Console.Write("Enter your grade from 0 to 100 (enter -1 to end the loop): "); int studentgrade = Convert.ToInt32(Console.ReadLine());

            if (studentgrade == -1)
                break;
            
            Console.Write("Enter your credit hours: "); int hours = Convert.ToInt32(Console.ReadLine());

            totalcredit += hours;
            if (studentgrade <= 100 && studentgrade >= 90)
            {
                ScheduleGrades[y] = "A"; Schedulegpa += 4.00;
            }
            else if (studentgrade <= 89 && studentgrade >= 82)
            {
                ScheduleGrades[y] = "B+"; Schedulegpa += 3.50;
            }
            else if (studentgrade <= 81 && studentgrade >= 74)
            {
                ScheduleGrades[y] = "B"; Schedulegpa += 3.00;
            }
            else if (studentgrade <= 73 && studentgrade >= 66)
            {
                ScheduleGrades[y] = "C+"; Schedulegpa += 2.50;
            }
            else if (studentgrade <= 65 && studentgrade >= 58)
            {
                ScheduleGrades[y] = "C"; Schedulegpa += 2.00;
            }
            else if (studentgrade <= 57 && studentgrade >= 50)
            {
                ScheduleGrades[y] = "D"; Schedulegpa += 1.50;
            }
            else if (studentgrade < 50)
            {
                ScheduleGrades[y] = "Fail";
            }
            y++;
        }

        Console.Write("Your final grades are: ");
        for (int z = 0; z < y; z++)
        {
            Console.Write(ScheduleGrades[z]);
            if (z < y - 1) Console.Write(", ");
        }
        Console.WriteLine("\nYour total credit hours: {0}", totalcredit);

        gpa = Schedulegpa / y; Console.WriteLine("Your total GPA is: {0:0.00}", gpa);
        if (gpa <= 4.00 && gpa >= 3.67) Console.WriteLine("Your final grade is: Excellent");
        else if (gpa <= 3.66 && gpa >= 3.00) Console.WriteLine("Your final grade is: Very Good");
        else if (gpa <= 2.99 && gpa >= 2.33) Console.WriteLine("Your final grade is: Good");
        else if (gpa <= 2.32 && gpa >= 2.00) Console.WriteLine("Your final grade is: Fair");
        else if (gpa < 2.00) Console.WriteLine("Your final grade is: Fail");
    }
}
