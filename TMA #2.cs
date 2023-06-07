using System;



class main
{

    static void Main()
    {



        //Write everything in while loop to repeat program again and again until the user

        // enters -1

        while (true)
        {

            Console.Write("Enter the total number of calories (-1 to end): ");

            int totalCalories = Convert.ToInt32(Console.ReadLine());



            if (totalCalories == -1)
            {

                //break the loop when the user enters -1 to close the program.

                break;

            }



            Console.Write("Enter the number of fat grams: ");

            int numberOfFatGrams = Convert.ToInt32(Console.ReadLine());





            // One gram of fat has 9 calories.

            // If you know the number of fat grams in a particular food,

            // you can use the following formula to calculate the number of calories that come from fat in

            // that food:

            // Calories from fat = Fat grams × 9

            int caloriesFromFat = numberOfFatGrams * 9;



            // Make sure the number of calories and fat grams are not less than 0. Also, the number

            // of calories from fat cannot be greater than the total number of calories. If that happens,

            // display an error message indicating that either the calories or fat grams were incorrectly

            // entered.

            if (totalCalories <= 0 || numberOfFatGrams <= 0 || caloriesFromFat >= totalCalories)
            {

                Console.WriteLine("Invalid input either the calories or fat grams were incorrectly entered.");



                //Then skip this iteration to get the value again

                continue;//

            }





            // If you know the food’s total calories, you can use the following formula to calculate the

            // percentage of calories from fat:

            // Percentage of calories from fat = Calories from fat ÷ Total calories

            //Here, above formula will give result in decimal

            //SO, to get actual percentage we have formula = (calories From Fat x 100) ÷ Total calories

            int percentageOfCaloriesFromFat = (caloriesFromFat * 100) / totalCalories;





            // variable determineFatCategory of type string to store the category of fat (high fat or

            // normal fat or low fat)

            string determineFatCategory = "";



            if (percentageOfCaloriesFromFat > 40)
            {

                // If the calories from fat are more than 40% of the total calories of the food, the food

                // is considered high fat.

                determineFatCategory = "high fat";

            }

            else if (percentageOfCaloriesFromFat >= 30)
            {

                // If the calories from fat are between 30% and 40%of the total calories of the food, the

                // food is considered normal fat.

                determineFatCategory = "normal fat";

            }

            else
            {

                // If the calories from fat are less than 30% of the total calories of the food, the food is

                // considered low fat.

                determineFatCategory = "low fat";

            }



            //Now display the result in the given format

            Console.WriteLine("Percentage of calories from fat: " + percentageOfCaloriesFromFat + "% (" + determineFatCategory + ")");



        }

    }

}
