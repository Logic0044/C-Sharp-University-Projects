namespace Yousef

{

    class Program

    {

        static void Main(string[] args)

        {
            int grades = 0;
            int credit = 0;
            int[] total = new int[11];

            for (int i = 0; i <= 10; i++)
            {
                total[i] = 0;
            }
            while (grades != -1 && credit != -1)
            {
                Console.WriteLine("Enter grade number(-1 to end): ");
                grades = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter credit point: ");
                credit = Convert.ToInt32(Console.ReadLine());

                if(grades == -1)
                {
                    Console.WriteLine("end");
                    break;
                }
            }
        }
    }
}
