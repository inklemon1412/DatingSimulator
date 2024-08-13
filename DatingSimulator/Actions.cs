using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingSimulator
{
    internal class Actions
    {
        public int EnergyPoints = 100;
        int energyBySleep = 100;
        int actionCost = 10;
        int raiseEnergy = 5;

        public void dateEnd(Person dateable, int Points)
        {
            if (Points == 40)
            {
                Console.WriteLine($"{dateable.Name} seemed to have a really good time with you! Definitely consider taking them on another one!");
            }
            if (Points == 60)
            {
                Console.WriteLine($"Wow! Talk about a dreamdate! This one went really well, and it would seem {dateable.Name} is really into you ;)");
            }
            if (Points < -20)
            {
                Console.WriteLine("Oof, talk about a disaster. Either this person isn't for you, or you should consider upping that rizz a bit better.");
            }
            else
            {
                Console.WriteLine("The date could've gone better, but it also could've gone a lot worse. \r\n Try something a bit different next time, and who knows what'll happen!");
            }
            Console.WriteLine("Heading home...");
            Thread.Sleep(600);
            Console.WriteLine("Heading home...");
            GoSleep();
        }

           public void GoSleep()
            {
                Console.WriteLine("Feeling tired after your date, you've decided to go home and sleep");
                Thread.Sleep(500);
                Console.WriteLine("Sleeping...");
                Thread.Sleep(500);
                Console.WriteLine("ZZZZ");
                Thread.Sleep(500);
                EnergyPoints += energyBySleep;
                Console.WriteLine("You awake feeling well rested.");
                Console.WriteLine("1) Go on next date (or start the game over again)");

                var menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        Console.WriteLine("You decide to call up your date once more, wanting another round with them. Or maybe to break up - It's up to you");
                        DatePlaces datePlaces;
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
