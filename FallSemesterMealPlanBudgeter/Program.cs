namespace FallSemesterMealPlanBudgeter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //meal plan types
            bool roar = false;
            bool roarPlus = false;
            double roarSwipeIncrement = 3.5;
            double roarBalanceIncrement = 156.25;
            double roarPlusSwipeIncrement = 6.5;
            double roarPlusBalanceIncrement = 143.75;


            //est variables
            double balance = 0;
            string userInput = "";
            int mealSwipes = 0;
            double balanceIncrement = 0;
            double swipeIncrement = 0;
            int indexNum = 0;

            //gets and trims current date
            string currentDate = DateTime.Now.ToString();
            currentDate = currentDate.Substring(0, currentDate.Length - 16).Trim();
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
                    mealSwipes = 50;
                    balance = 2500;
                    swipeIncrement = roarSwipeIncrement;
                    balanceIncrement = roarBalanceIncrement;
                    break;
                }
                
                if (mealPlan == "ROAR PLUS")
                {
                    roarPlus = true;
                    mealPlan = "roar plus";
                    mealSwipes = 100;
                    balance = 2300;
                    swipeIncrement = roarPlusSwipeIncrement;
                    balanceIncrement = roarPlusBalanceIncrement;
                    break;
                }

                    Console.WriteLine("Meal plan type not recognized, try again please.");
                    Console.WriteLine("\tROAR or ROAR PLUS");
                    mealPlan = Console.ReadLine().ToUpper().Trim();
            }
            
            //gives info to user
            Console.WriteLine("Today, {0}, you have a balance of {1} for your {2} meal plan.", currentDate, balance, mealPlan);
            Console.WriteLine("To begin with, you have {0} meal swipes and ${1}.", mealSwipes, balance);

            //date arrays
            //mayyyy have to remove the zeros on single digit dates
            string[] dates = new string[17];
                dates[0] = "08/20";
                dates[1] = "08/27";
                dates[2] = "09/3";
                dates[3] = "09/10";
                dates[4] = "09/17";
                dates[5] = "09/24";
                dates[6] = "10/01";
                dates[7] = "10/08";
                dates[8] = "10/15";
                dates[9] = "10/22";
                dates[10] = "10/29";
                dates[11] = "11/05";
                dates[12] = "11/12";
                dates[13] = "11/19";
                dates[14] = "11/26";
                dates[15] = "12/03";
                dates[16] = "12/10";

            //CALCULATIONS

            //figure out the month and day range
            int currentMonth = int.Parse(currentDate.Substring(0, currentDate.Length - 3));
            int currentDay = int.Parse(currentDate.Substring(currentDate.Length-2, 2));

            for (int i = 0; i < dates.Length; i++)
            {
                int monthNum = int.Parse(dates[i].Substring(0, dates[i].Length - 3));

                if (monthNum == currentMonth)
                {
                    int dayNum = int.Parse(dates[i].Substring(dates[i].Length-2, 2));

                    if (dayNum <= currentDay + 6 && dayNum >= currentDay - 6)
                    {
                        indexNum = i;
                        break;
                    }
                }
            }

            Console.WriteLine("You are on week " + indexNum);
            

            //reccomended range: substract the increments multiplied by the array location

            //check to see if the inputted balance is in the righrt range

        }
    }
}