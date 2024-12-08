using System;
    public static class MacronutrientCalculator
    {
        public static void Calculate(User user)
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("        Macronutrient Calculator");
            Console.WriteLine("==============================================\n");

            user.CalculateBMR();
            user.CalcTDEE();

            Console.WriteLine($"Your Total Daily Energy Expenditure (TDEE) is: {user.TDEE} calories");

            Console.Write("Please enter the percentage of your diet that you want to come from protein: ");
            double proteinPercentage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the percentage of your diet that you want to come from carbs: ");
            double carbsPercentage = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter the percentage of your diet that you want to come from fat: ");
            double fatPercentage = Convert.ToDouble(Console.ReadLine());

            if (proteinPercentage + carbsPercentage + fatPercentage != 100) // bad input, it must equal 100.
            {
                Console.WriteLine("Error: The total percentage of protein, carbs, and fat must equal 100.");
            }
            else
            {
                double proteinCalories = (proteinPercentage / 100) * user.TDEE;
                double carbsCalories = (carbsPercentage / 100) * user.TDEE;
                double fatCalories = (fatPercentage / 100) * user.TDEE;

                double proteinGrams = proteinCalories / 4;
                double carbsGrams = carbsCalories / 4;
                double fatGrams = fatCalories / 9;

                Console.WriteLine($"\nBased on a TDEE of {user.TDEE} calories:");
                Console.WriteLine($"- Protein: {proteinGrams:F2} grams ({proteinCalories:F2} calories)");
                Console.WriteLine($"- Carbs: {carbsGrams:F2} grams ({carbsCalories:F2} calories)");
                Console.WriteLine($"- Fat: {fatGrams:F2} grams ({fatCalories:F2} calories)");
            }
            Console.WriteLine("Press any key to return to the profile management menu...");
            Console.ReadKey();
        }
    }
