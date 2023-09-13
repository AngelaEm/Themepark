﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Themepark
{
    public class Park
    {
        // Visitors

        Visitor person1 = new Visitor("Angela", 46, 1.71, 1500);
        Visitor person2 = new Visitor("Andreas", 47, 1.84, 2000);
        Visitor person3 = new Visitor("Leo", 12, 1.71, 500);
        Visitor person4 = new Visitor("Tim", 6, 1.30, 700);
        Visitor person5 = new Visitor("Mio", 4, 1.11, 1000);
        Visitor person6 = new Visitor("Nea", 16, 1.75, 700);


        List<Visitor> listWithVisitors = new List<Visitor>();

        // ThemeParkRides
        ThemeParkRide balder = new ThemeParkRide("Balder", 2.5, 1.40, false, 16);
        ThemeParkRide flumride = new ThemeParkRide("Flumride", 3.5, 1.20, true, 4);
        ThemeParkRide lisebergshjulet = new ThemeParkRide("Lisebergshjulet", 8.5, 1.25, false, 8);
        ThemeParkRide gasten = new ThemeParkRide("Hotell Gasten", 5.5, 1.50, false, 9);
        ThemeParkRide valkyria = new ThemeParkRide("Valkyria", 1.5, 1.45, false, 10);
        ThemeParkRide colorado = new ThemeParkRide("Colorado", 3.5, 1.20, true, 4);

        List<ThemeParkRide> listWithTeamParkRides = new List<ThemeParkRide>();
        

        // Zones
        Zones north = new Zones("north");
        Zones south = new Zones("south");

        List<Zones> listWithZones = new List<Zones>();

        // Staff

        Staff staff1 = new Staff("Robert", "Cleaner");
        Staff staff2 = new Staff("Robin", "Ride operator");
        Staff staff3 = new Staff("Vincent", "Food staff");


        List<Staff> listWithStaff = new List<Staff>();

        // Wheel of fortune

        WheelOfFortune chocolate = new WheelOfFortune("Chocolate", "different choclate", 0.1, 25);
        WheelOfFortune toys = new WheelOfFortune("Toywheel", "different toys", 0.05, 10);

        List<WheelOfFortune> listWithWheelOfFortune = new List<WheelOfFortune>();

        public void InitializeVisitors()
        {
            listWithVisitors.Add(person1);
            listWithVisitors.Add(person2);
            listWithVisitors.Add(person3);
            listWithVisitors.Add(person4);
            listWithVisitors.Add(person5);
            listWithVisitors.Add(person6);

        }
        public void InitializeThemeParkRides()
        {
            listWithTeamParkRides.Add(balder);
            listWithTeamParkRides.Add(gasten);
            listWithTeamParkRides.Add(valkyria);
            listWithTeamParkRides.Add(flumride);
            listWithTeamParkRides.Add(lisebergshjulet);
            listWithTeamParkRides.Add(colorado);
        }

        public void InitializeZones()
        {
            // Add rides to zones
            north.rides.Add(balder);
            north.rides.Add(gasten);
            north.rides.Add(valkyria);

            south.rides.Add(flumride);
            south.rides.Add(lisebergshjulet);
            south.rides.Add(colorado);
        }

        public void InitializeStaff()
        {
            listWithStaff.Add(staff1);
            listWithStaff.Add(staff2);
            listWithStaff.Add(staff3);
        }

        public void InitializeWheelOfFortune()
        {
            listWithWheelOfFortune.Add(toys);
            listWithWheelOfFortune.Add(chocolate);
        }

        

        public void PrintInformation()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine("Welcome to Angela's Park. Here, you can ride exciting attractions, play games and");
            Console.WriteLine("enjoy delicious food.");
            Console.WriteLine("Welcome!");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.ReadKey();
        }

        public void PrintListWithRides()
        {
            foreach (var themeParkRide in listWithTeamParkRides)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n***************************\n");
                Console.WriteLine($"Name: {themeParkRide.Name}");
                Console.WriteLine($"Duration: {themeParkRide.Duration}");
                Console.WriteLine($"Hight restriction: {themeParkRide.HightRestrictions}");
                Console.WriteLine($"Waterride: {themeParkRide.IsWaterRide}");
                Console.WriteLine($"Age restriktion: {themeParkRide.AgeRestrictions}");
            }
        }

        public void PrintVisitors()
        {
            Console.Clear();
            Console.WriteLine("Visitors in Park:");

            foreach (var visitor in listWithVisitors)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n*****************\n");
                Console.WriteLine("Name:" + visitor.GetVisitorName());
                Console.WriteLine("Age:" + visitor.GetVisitorAge());
                Console.WriteLine("Height:" + visitor.GetVisitorHeight());
                Console.WriteLine("Money:" + visitor.GetVisitorMoney());
            }
            
        }

        public void PrintZones()
        {
            foreach(Zones zone in listWithZones)
            {
                Console.WriteLine(zone);
            }
        }

        public void printStaff()
        {
            foreach (Staff staff in listWithStaff)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n*****************\n");
                Console.WriteLine($"Name: {staff.StaffName}");
                Console.WriteLine($"Role: {staff.StaffRole}");
            }
            Console.WriteLine();
        }

        public void PrintWheelOfFortune()
        {
            foreach (var wheelOfFortune in listWithWheelOfFortune)
            {
                Console.WriteLine("\n*************************************************");
                Console.WriteLine($"Name: {wheelOfFortune.WheelName}");
                Console.WriteLine($"What you can win: {wheelOfFortune.WhatYouCanWin}");
                Console.WriteLine($"Chances of winning: {wheelOfFortune.Winprobability}");
                Console.WriteLine($"Price only: {wheelOfFortune.TicketPrice}");
                Console.WriteLine("*************************************************");
            }
            Console.ReadKey();
        }

        public void VisitorsAndRides()
        {
            Console.Clear();
            Console.WriteLine("Hello visitor! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("How tall are you?");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            
            
           
            foreach (var ride in listWithTeamParkRides)
            {
                if (age >= ride.AgeRestrictions && height >= ride.HightRestrictions)
                {
                    Console.WriteLine($"{name}, you may ride {ride.Name}!");
                    Console.WriteLine("\n***********************************\n");
                    
                   
                }
                else
                {
                    Console.WriteLine($"{name}, you may not ride: {ride.Name}");
                    Console.WriteLine("\n***********************************\n");
                    
                }
            }
           
            Console.ReadKey();
        }

        public void InteractWithStaff()
        {
            Console.Clear();
            Console.WriteLine("Hello visitor!");
            Console.WriteLine("Do you want to talk to a cleaner, press 1.");
            Console.WriteLine("Do you want to talk to food staff, press 2.");
            Console.WriteLine("Do you want to talk to ride operator, press 3.");
            Console.WriteLine();

            int userChoice = Convert.ToInt32( Console.ReadLine() );

            switch (userChoice)
            {
                case 1:

                    Console.WriteLine("\n*************************************************************************************");
                    Console.WriteLine($"Hello! I am {staff1.StaffName} and work as a {staff1.StaffRole}. How can I help you?");
                    Console.WriteLine("*************************************************************************************");

                    break;

            
                case 2:

                    Console.WriteLine("\n*************************************************************************************");
                    Console.WriteLine($"Hello! I am {staff3.StaffName} and work as a {staff3.StaffRole}. How can I help you?");
                    Console.WriteLine("*************************************************************************************");

                    break;

                case 3:

                    Console.WriteLine("\n*************************************************************************************");
                    Console.WriteLine($"Hello! I am {staff2.StaffName} and work as a {staff2.StaffRole}. How can I help you?");
                    Console.WriteLine("************************************************************************************");

                    break;

                default:

                    Console.WriteLine("Invalid number, please try again. 1-3.");

                    break;
            }
            Console.ReadKey();

        }

        public bool IsWinningCocolate(int guess)
        {
            
            Random random = new Random();
            int luckyNumber = random.Next(1,11);

            if (guess == luckyNumber)
            {
                Console.WriteLine("Congratulations, you won chocolate!");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, you did not win this time. Try again later!");
                return false;
            }
        }
    }
}
