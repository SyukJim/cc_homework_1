using System;

namespace cc_clean_code
{
    class Program
    {
        static void Main(string[] args)
        {

            String s;
            char meal = 'm';
            double mealPrice = 0.0;
            string mealName = "meal name";

            char drink = 'd';
            double drinkPrice = 0.0;
            string drinkName = "drink name";

            char userInput;
            bool stillOrdering = true;

            while (stillOrdering == true)
            {

                Console.WriteLine("Main Meal Choices: \n");
                Console.WriteLine("1 - Beef Burger $8.50 (B)\n2 - Chicken Burger $7.00 (C)\n3 - Fish n Chips $9.50 (F)\n");

                Console.WriteLine("Drink Choices: \n");
                Console.WriteLine("1 - Soft drink $1.00 (S)\n2 - Milo $1.20 (M)\n3 - Tea $0.90 (T)\n");

                Console.WriteLine("Please select your meal (Enter B, C or F)");
                s = Console.ReadLine();
                meal = char.Parse(s);
                meal = char.ToUpper(meal);

                Console.WriteLine("Please select your drink (Enter S, M or T)");
                s = Console.ReadLine();
                drink = char.Parse(s);
                drink = char.ToUpper(drink);

                switch (meal)
                {
                    case 'B':
                        mealPrice = 8.5;
                        mealName = "Beef Burger";
                        break;

                    case 'C':
                        mealPrice = 7.0;
                        mealName = "Chicken Burger";
                        break;

                    case 'F':
                        mealPrice = 9.5;
                        mealName = "Fish n Chips";
                        break;

                }

                /*Console.WriteLine("Drink Choices: \n");
                Console.WriteLine("1 - Soft drink $1.00 (S)\n2 - Milo $1.20 (M)\n3 - Tea $0.90 (T)\n");

                Console.WriteLine("Please select your choice (Enter S, M or T)");
                s = Console.ReadLine();
                drink = char.Parse(s);
                drink = char.ToUpper(drink);*/

                switch (drink)
                {
                    case 'S':
                        drinkPrice = 1.0;
                        drinkName = "Soft drink";
                        break;

                    case 'M':
                        drinkPrice = 1.2;
                        drinkName = "Milo";
                        break;

                    case 'T':
                        drinkPrice = 0.9;
                        drinkName = "Tea";
                        break;

                }

                Console.WriteLine("The cost of your order is ${0:f2}.\nYour order is {1} and {2}.", (mealPrice + drinkPrice), mealName, drinkName);
                //Console.WriteLine("Your order is {0} and {1}.", mealName, drinkName);

                Console.WriteLine("Would you to like to order again? Y|N");
                s = Console.ReadLine();
                userInput = char.Parse(s);
                userInput = char.ToUpper(userInput);

                if (userInput == 'Y')
                    stillOrdering = true;
                else if(userInput == 'N')
                    stillOrdering = false;

            }

            Console.WriteLine("Thanks for your order.");

            

        }
    }
}
