using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Themepark
{
    internal class Visitor
    {
        private string VisitorName;
        private int VisitorAge;
        private double VisitorHeight;
        private int VisitorMoney;

     
        public Visitor(string visitorName, int visitorAge, double visitorHeight, int visitorMoney)
        {
            VisitorName = visitorName;
            VisitorAge = visitorAge;
            VisitorHeight = visitorHeight;
            VisitorMoney = visitorMoney;

        }



        public bool IsVisitorOldEnough(ThemeParkRide rideName)
        {
            if (VisitorAge >= rideName.AgeRestrictions)
            {
                Console.WriteLine($"Hej {VisitorName}! You may ride {rideName.Name}!");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, you are not old enough!");
                return false;
            }
        }

        public bool IsVisitorTallEnough(ThemeParkRide rideName)
        {
            if (VisitorHeight >= rideName.HightRestrictions)
            {
                Console.WriteLine($"Hej {VisitorName}! You may ride {rideName.Name}!");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, you are not old enough!");
                return false;
            }
        }

       

        

        public string GetVisitorName()
        {
            return VisitorName;
        }
        public int GetVisitorAge()
        {
            return VisitorAge;
        }
        public double GetVisitorHeight()
        {
            return VisitorHeight;
        }
        public int GetVisitorMoney()
        {
            return VisitorMoney;
        }

        
    }
}
