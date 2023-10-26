namespace FallSemesterMealPlanBudgeter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //meal plan types
            bool roar = false;
            bool roarPlus = false;

            //get user input
            string currentDate = DateTime.Now.ToString();

            Console.WriteLine("What is your current meal plan balance?");
            double balance = double.Parse(Console.ReadLine());

            Console.WriteLine("Do you have ROAR or ROAR PLUS as your meal plan type?");
            string mealPlan = Console.ReadLine().ToUpper().Trim();

            while (!roar && !roarPlus)
            {
                if (mealPlan == "ROAR")
                {
                    roar = true;
                    mealPlan = "roar";
                }
                else if (mealPlan == "ROARPLUS")
                {
                    roarPlus = true;
                    mealPlan = "roar plus";
                }
                else
                {
                    Console.WriteLine("Meal plan type not recognized, try again please.");
                    Console.WriteLine("\tROAR or ROAR PLUS");
                    mealPlan = Console.ReadLine().ToUpper().Trim();
                }
            }
            

            Console.WriteLine("Today, {0}, you have a balance of {1} for your {2} meal plan.", currentDate, balance, mealPlan);
        }
    }
}