namespace Yousef

{

    class Program

    {

        static void Main(string[] args)

        {
            int cc;double grd;double ga = 0;string fgrd;

            Console.WriteLine("Enter the credit hours:");
            cc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the numeric grade:");
            grd = Convert.ToDouble(Console.ReadLine());

            if (grd >= 95)
            {
                ga = 4;

                fgrd = "A";
            }
            else if (grd >= 85)
            {
                ga = 3.33;

                fgrd = "B+";
            }
            else if (grd >= 80)
            {

                ga = 3;

                fgrd = "B";

            }
            else if (grd >= 75)
            {
                ga = 2.67;

                fgrd = "B-";
            }
            else if (grd >= 70)
            {
                ga = 2.33;

                fgrd = "C+";

            }
            else if (grd >= 65)
            {
                ga = 2;

                fgrd = "C";
            }
            else if (grd >= 60)
            {
                ga = 1.67;

                fgrd = "C-";
            }
            else if (grd >= 55)
            {
                ga = 1.33;

                fgrd = "D+";
            }
            else if (grd >= 50)
            {
                ga = 1;

                fgrd = "D";
            }
            else
            {
                ga = 0;

                fgrd = "F";
            }

            Console.WriteLine($"Your GPA is: {ga}, your final grade is: {fgrd}");
        }

    }

}
