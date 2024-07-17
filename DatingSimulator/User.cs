using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingSimulator
{
    internal class User
    {
        //ha en evt sleep tracker her - actions på daten koster energi. Når du er tom får energi kicker en sleep function inn, som gjør at du må ta en pause før du kan gå på neste date.
        // kanskje ha en mulighet til å enten fortsette med samme dateable, eller kunne velge en ny en
        public int EnergyPoints = 100;
        int energyBySleep = 100;
        int actionCost = 10;
        int raiseEnergy = 5;


        internal void GoSleep()
        {
            Console.WriteLine("Feeling tired after your date, you've decided to go home and sleep");
            Thread.Sleep(500);
            Console.WriteLine("Sleeping...");
            Thread.Sleep(500);
            Console.WriteLine("ZZZZ");
            Thread.Sleep(500);
            EnergyPoints += energyBySleep;
            Console.WriteLine("You awake feeling well rested. \r\n Would you like to go on another date, or choose another person?");
            var menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
                case "1":

                break;
            }

            
        }
        public void energyActions()
        {
            EnergyPoints -= actionCost;
        }
        public void energyBuy()
        {
            EnergyPoints += raiseEnergy;
            Console.WriteLine("Energy raised by five points by ingesting consumable");
        }

       
    }
}
