//class coffee_shop
//{
//    static void Main()
//    {
//        // coffee shop by using do-while loop

//        int TotalCoffeeBill = 0;
//        string userConfirm;
//        do
//        {
//            int userChoice;
//            do
//            {
//                Console.Write("Please select your coffee 1 - Small, 2 - Medium, 3 - Large: ");

//            userChoice = int.Parse(Console.ReadLine());

//                switch (userChoice)
//                {
//                    case 1:
//                        TotalCoffeeBill += 1;
//                        break;
//                    case 2:
//                        TotalCoffeeBill += 2;
//                        break;
//                    case 3:
//                        TotalCoffeeBill += 3;
//                        break;
//                    default:
//                        Console.WriteLine("Invalid choice. Please try again...");
//                        break;
//                }
//            } while (userChoice != 1 && userChoice != 2 && userChoice != 3);

//            do
//            {
//                Console.WriteLine("Coffee Bill Amount: {0}", TotalCoffeeBill);
//                Console.WriteLine("Do you want to continue. Please say Yes or No: ");

//                userConfirm = Console.ReadLine().ToUpper();

//                if (userConfirm != "YES" && userConfirm != "NO")
//                {
//                    Console.WriteLine("Please enter a valid choice {0}. Please try again...", userConfirm);
//                }
//            } while (userConfirm != "YES" && userConfirm != "NO");
//        } while (userConfirm == "YES");
//    }
//}

class Coffee_Shop
{
    static void Main()
    {
        Console.WriteLine("Welcome To C#, Coffee Shop Console Application \n");

        int TotalCoffeeCost = 0;
        int userChoice;
        string decision;
        do {
            do
            {
                Console.Write("Select your coffee 1 - Small, 2 - Medium, 3 - Large: ");
                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        TotalCoffeeCost += 1;
                        break;
                    case 2:
                        TotalCoffeeCost += 2;
                        break;
                    case 3:
                        TotalCoffeeCost += 3;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice. Please try again...");
                        break;
                }
            } while (userChoice != 1 && userChoice != 2 && userChoice != 3);

            do {
                Console.WriteLine("Do you want continue your order: Yes or No: ");
                decision = Console.ReadLine().ToUpper();

                if (decision != "YES" && decision != "NO")
                {
                    Console.WriteLine("Invalid Choice. Please type Yes or No only.");
                }
            } while (decision != "YES" && decision != "NO");
        } while (decision == "YES");
        Console.WriteLine("Coffee Bill Amount: {0}$", TotalCoffeeCost);
        Console.WriteLine("Thanks for Coffee! Visit Again!");
    }
}