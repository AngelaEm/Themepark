namespace Themepark
{
    internal class Program
    {
        static Park park = new Park();
        
        
        static void Main(string[] args)
        {                  
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n*****************************\n");
            Console.WriteLine("Welcome to Angelas Thempark!");
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("\nPress enter to see menu.");
            Console.WriteLine("\n*****************************\n");          
            
            Console.ReadKey();

            Menu();
        }

        public static void Menu()
        {
            bool continueRunning = true;

            Console.Clear();

            while (continueRunning)
            {
                string[] menuOptions = new string[] { "1.\tWelcome", "2.\tInformation about Park", "3.\tGo on a ride", "4.\tInteract with staff", "5.\tWheel of fortune", "6.\tFood", "7.\tGood Bye" };

                Console.WriteLine("--------Menu--------\n");
                foreach (string option in menuOptions)
                {
                    Console.WriteLine(option);
                }

                try
                {
                    Console.Write("\nMenuOption:\t");

                    int menuOption = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine();

                    switch (menuOption)
                    {
                        case 1:

                            park.PrintInformation();

                            break;

                        case 2:

                            MenuWithInformationAboutPark();

                            break;

                        case 3:

                            park.VisitorsAndRides();

                            break;

                        case 4:

                            park.InteractWithStaff();

                            break;

                        case 5:

                            Console.Clear();

                            // Information about wheels
                            Console.WriteLine("Here is information about our Wheels of fortune!");
                            park.PrintWheelOfFortune();

                            // Spin ToyWheel
                            Console.WriteLine("\nChoose a number between 1-20 and spin the toywheel.");
                            int firstUserNumber = Convert.ToInt32(Console.ReadLine());
                            park.IsWinningToys(firstUserNumber);

                            Console.WriteLine("---------------------------------------------------\n");

                            // Spin ChokolateWheel
                            Console.WriteLine("\nChoose a number between 1-10 and spin the chocolatewheel.");
                            int secondUserNumber = Convert.ToInt32(Console.ReadLine());
                            park.IsWinningCocolate(secondUserNumber);
     
                            Console.ReadKey();

                            break;

                        case 6:

                            // Food

                            break;

                        case 7:

                            continueRunning = false;
                            Console.WriteLine("Good bye! Hope you had a great day. Welcome back!");
                            Console.ReadKey();

                            break;

                        default:
                            Console.WriteLine("Please chose number from 1-7");
                            break;
                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("Invalid input"); ;
                }
                Console.Clear();
            }
        }


        public static void MenuWithInformationAboutPark()
        {
            Console.Clear();
            string[] visitorMenuOptions = new string[] { "1.\tInformation about zones", "2.\tInformation about rides", "3.\tInformation about staff", "4.\tInformation about visitors", "5.\tBack to menu" };

            Console.WriteLine("--------Menu--------\n");
            foreach (string option in visitorMenuOptions)
            {
                Console.WriteLine(option);
            }
            try
            {
                Console.Write("\nMenuOption:\t");

                int menuOption = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine();

                switch (menuOption)
                {
                    case 1:

                        Console.Clear();
                        park.PrintZones();
                        park.PrintZoneList();

                        break;

                    case 2:

                        park.PrintListWithRides();

                        break;

                    case 3:

                        park.printStaff();

                        break;

                    case 4:

                        park.PrintVisitors();


                        break;

                    case 5:

                        Console.WriteLine("Press enter to get back to menu.");

                        break;

                    default:
                        Console.WriteLine("Please chose number from 1-6");
                        break;
                }

                Console.ReadKey();
            }

            catch (Exception)
            {

                Console.WriteLine("Invalid input");
            }
        }
    }
}