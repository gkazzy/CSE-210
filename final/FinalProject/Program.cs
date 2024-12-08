public class Program
{
    static void Main(string[] args)
    {
        // Create an instance of ProfileManager, loading existing user data
        ProfileManager profileManager = new ProfileManager();

        // Now you can use profileManager to create, load, update, or save user profiles
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n===========================================");
            Console.WriteLine("      Welcome to the Nutrition Calculator     ");
            Console.WriteLine("===========================================\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create a New Profile");
            Console.WriteLine("  2. Load Existing Profiles");
            Console.WriteLine("  3. Exit");
            Console.Write("\nPlease enter the number of your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    User user = profileManager.CreateUser();
                    if (user != null)
                    {
                        ProfileMenu(user);
                    }
                    break;
                case 2:
                    user = profileManager.LoadProfile();
                    if (user != null)
                    {
                        ProfileMenu(user);
                    }
                    break;
                case 3:
                    profileManager.SaveUsers();
                    return; // Exit the application
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void ProfileMenu(User user)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Profile Management Menu");
            Console.WriteLine("1. Display Profile");
            Console.WriteLine("2. Daily Calorie Intake Calculator");
            Console.WriteLine("3. Calculate Macronutrients");
            Console.WriteLine("4. Quit");
            Console.Write("Please enter the number of your choice: ");
            int profileChoice = Convert.ToInt32(Console.ReadLine());

            switch (profileChoice)
            {
                case 1:
                    user.CalcBMI();
                    user.CalcTDEE();
                    user.CalculateBMR();
                    user.DisplayProfile();
                    Console.WriteLine("Press any key to return to the profile management menu...");
                    Console.ReadKey();
                    break;
                case 2:
                    user.CalcTDEE();
                    user.CalculateBMR();
                    CalorieIntakeMenu(user);
                    break;
                case 3:
                    MacronutrientCalculator.Calculate(user);
                    break;
                case 4:
                    return; // Exit the profile management menu
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.WriteLine("Press any key to return to the profile management menu...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void CalorieIntakeMenu(User user)
    {
        Console.Clear();
        Console.WriteLine("==============================================");
        Console.WriteLine("         Daily Caloric Intake Calculator");
        Console.WriteLine("==============================================\n");
        Console.WriteLine("Please select your goal by entering the corresponding number:");
        Console.WriteLine("1. Maintain current weight");
        Console.WriteLine("2. Lose weight");
        Console.WriteLine("3. Gain weight");
        Console.Write("\nYour choice: ");
        int weightChoice = Convert.ToInt32(Console.ReadLine());
        switch (weightChoice)
        {
            case 1:
                user.MaintinenceCals();
                break;
            case 2:
                user.WeightLossCalc();
                break;
            case 3:
                user.WeightGainCalc();
                break;
            default:
                Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                break;
        }
        Console.WriteLine("Press any key to return to the profile management menu...");
        Console.ReadKey();
    }
}
