namespace FallSemesterMealPlanBudgeter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //meal plan types
            bool roar = false;
            bool roarPlus = false;

            //est variables
            double balance = 0;
            string userInput = "";

            //gets and trims current date
            string currentDate = DateTime.Now.ToString();
            currentDate = currentDate.Substring(0, currentDate.Length - 11).Trim();
            Console.WriteLine("The date is: " + currentDate);


            //  ---PART ONE---
                //collects data from users and ensures its the proper type and formatted correctly

            while (true)
            {
                Console.WriteLine("What is your current meal plan balance?");
                userInput = Console.ReadLine();

                try
                {
                    balance = double.Parse(userInput);
                    if (balance < 0 || balance > 2500)
                    {
                        Console.WriteLine("Inputted balance is not within range. Balance must be between 0-2500");
                    } else
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine(userInput + " is not a valid data type.");
                }
            }
            

            Console.WriteLine("Do you have ROAR or ROAR PLUS as your meal plan type?");
            string mealPlan = Console.ReadLine().ToUpper().Trim();

            while (!roar && !roarPlus)
            {
                if (mealPlan == "ROAR")
                {
                    roar = true;
                    mealPlan = "roar";
                }
                
                if (mealPlan == "ROARPLUS")
                {
                    roarPlus = true;
                    mealPlan = "roar plus";
                }

                    Console.WriteLine("Meal plan type not recognized, try again please.");
                    Console.WriteLine("\tROAR or ROAR PLUS");
                    mealPlan = Console.ReadLine().ToUpper().Trim();
            }
            

            Console.WriteLine("Today, {0}, you have a balance of {1} for your {2} meal plan.", currentDate, balance, mealPlan);


            //  ---PART TWO---
        }
    }
}