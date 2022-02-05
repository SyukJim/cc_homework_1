using System;

namespace cc_bad_code
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            String s;
            char m = 'z';
            double priceM = 0.0;
            string nameM = "meal";

            char d = 'z';
            double priceD = 0.0;
            string drinkN = "drink";

            Console.WriteLine("Choices for Main Meal: ");
            Console.WriteLine();
            Console.WriteLine("1 - Beef Burger (B)");
            Console.WriteLine("2 - Chicken Burger (C)");
            Console.WriteLine("3 - Fish n Chips (F)");
            Console.WriteLine();

            Console.WriteLine("Please select your choice (Enter B, C or F)");
            s = Console.ReadLine();
            m = char.Parse(s);
            Console.WriteLine();

            if (m == 'B')
            {

                priceM = 8.5;
                nameM = "Beef Burger";

                

            }
            else if (m == 'C')
            {

                priceM = 7.0;
                nameM = "Chicken Burger";

                

            }
            else
            {

                priceM = 9.5;
                nameM = "Fish n Chips";

                

            }

            Console.WriteLine("Choices for drink: ");
            Console.WriteLine();
            Console.WriteLine("1 - Soft drink (S)");
            Console.WriteLine("2 - Milo (M)");
            Console.WriteLine("3 - Tea (T)");
            Console.WriteLine();

            Console.Write("Please select your choice (Enter S, M or T): ");
            s = Console.ReadLine();
            d = char.Parse(s);
            Console.WriteLine();

            if (d == 'S')
            {

                priceD = 1.0;
                drinkN = "Soft drink";

                

            }
            else if (d == 'M')
            {

                priceD = 1.2;
                drinkN = "Milo";

                

            }
            else
            {

                priceD = 0.9;
                drinkN = "Tea";

                

            }

            Console.WriteLine();

            Console.WriteLine("The cost of your order is $ {0:f2}.", (priceM + priceD));
            Console.WriteLine("Your order is {0} and {1}.", nameM, drinkN);

        }
    }
}
