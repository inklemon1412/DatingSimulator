using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingSimulator
{
    class Park : ILocations
    {
       
        
       
        public void GoTo(Person dateable, User user)
        {
            

            Console.WriteLine($"You have decided to take {dateable.Name} to the park ");

            if (dateable.PersonalityType == "Shy")
            {
                dateable.extraPoints();
                Console.WriteLine($"{dateable.Name} seems to be happy here");
            }
            if (dateable.PersonalityType == "Bold")
            {
                dateable.loosePoints();
                Console.WriteLine($"{dateable.Name} seems to be bored. Maybe this wasn't the best option?");
            }
            if (dateable.PersonalityType == "Flirty")
            {
                dateable.loosePoints();
                Console.WriteLine($"It is clear that {dateable.Name} hoped for something else, but maybe you can make it up for them?");

            }
            bool _onDate = true;
            while (_onDate)
            {
                Console.WriteLine($"Here you can choose a variety of things you'd like to do with your date");
                Console.WriteLine("1) to hold hands");
                Console.WriteLine($"2) Chat with {dateable.Name}");
                Console.WriteLine("3) To see current activities available");
                Console.WriteLine("6) to end the date");
                Console.WriteLine($"Your current dating points are: {dateable.Points}");
                Console.WriteLine($"Energytracker: {user.EnergyPoints}");
                string datingChoice = Console.ReadLine();
                switch (datingChoice)
                {
                    case "1":
                        dateable.holdHands();
                        break;
                        case "2":
                        Console.WriteLine($"You and {dateable.Name} have a little, casual chat. They smile at you, leaning closer towards you with interest glinting in their eyes");
                        if (dateable.ShowsAge == false)
                        {
                            Console.WriteLine("Seeing as your date hasn't disclosed their age to you yet, you feel like this is the perfect time to ask");
                            Console.WriteLine($"{dateable.Name} has disclosed their age for you: {dateable.Age}");
                        }
                       
                        break;
                    case "3":
                        SeeParkActivities(dateable, dateable.Points, user, user.EnergyPoints);
                        break;
                    case "6":
                        dateable.dateEnd();

                        return;

                   
                }
            }
        } 
        public void SeeParkActivities(Person dateable, int points, User user, int EnergyPoints)
        {
            user.energyActions();
            Console.WriteLine("These are the things you can do at the park:");
            Console.WriteLine("1) Buy some ice cream for you and your date");
            Console.WriteLine("2) Ride on the swan boat with your date");
            Console.WriteLine("3) Sit by a bench and look at the lake ");
            Console.WriteLine(points);
            Console.WriteLine(EnergyPoints);
            

            var parkChoices = Console.ReadLine();
            switch (parkChoices)
            {
                case "1":
                    user.energyBuy();
                    Console.WriteLine($"You've decided to buy some ice cream for you and {dateable.Name}");
                    if (dateable.PersonalityType == "Bold" || dateable.PersonalityType == "Flirty")
                    {
                        dateable.getPoints();
                        Console.WriteLine($"{dateable.Name} chooses the strawberry flavour with a smile");
                        
                    }
                    else { 
                     dateable.getPoints();
                        Console.WriteLine($"{dateable.Name} chooses the vanilla flavour with a shy nod directed at you");
                    }
                    if (dateable.Points == 30)
                    {
                        Console.WriteLine($"You offer to pay for your date, but{dateable.Name} waves away your attempts. This is their treat!");
                    }
                    break;
                    case "2":
                    dateable.extraPoints();
                    Console.WriteLine($"The gentle ride across the lake has left both you and your date in a good mood!");
                    break;
                    case "3":
                    Console.WriteLine("You lead your date to a bench sitting near the lake");
                    if (dateable.PersonalityType == "Flirty")
                    {
                        dateable.getPoints();
                        Console.WriteLine($"{dateable.Name} leans their head on your shoulder");
                    }
                    if (dateable.PersonalityType == "Shy")
                    {
                        dateable.extraPoints();
                        Console.WriteLine("Your date seems to appreciate the quiet");
                    }
                    if (dateable.PersonalityType == "Bold")
                    {
                        dateable.loosePoints();
                        Console.WriteLine("Uh oh! Seems as if your date is a bit bored");

                    }
                    break;
            }
        }
    }
}
 