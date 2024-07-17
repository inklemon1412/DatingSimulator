using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingSimulator
{
    class Festival : ILocations
    {
        public void GoTo(Person dateable, User user) 
        {
            
            Console.WriteLine($"You decided to take {dateable.Name} to the local festival");

            if (dateable.PersonalityType == "Shy")
            {
                dateable.loosePoints();
                Console.WriteLine($"It would seem that {dateable.Name} is a bit unhappy with the choice of place. Too many people around ");
            }
            if (dateable.PersonalityType == "Bold")
            {
                dateable.extraPoints();
                Console.WriteLine($"{dateable.Name} gives you a smile. It is clear that they are enjoying this!");
            }
            if (dateable.PersonalityType == "Flirty")
            {
                dateable.getPoints();
                Console.WriteLine($"It would seem that this was a good place to take {dateable.Name} to!");

            }
            bool _onDate = true;
            while (_onDate)
            {
                Console.WriteLine($"Here you can choose a variety of things you'd like to do with your date");
                Console.WriteLine("1) to hold hands");
                Console.WriteLine("2) See what activities the festival offers!");
                Console.WriteLine("3) End date");
                Console.WriteLine($"Your current dating points are: {dateable.Points}");
                string datingChoice = Console.ReadLine();
                switch (datingChoice)
                {
                    case "1":
                        dateable.holdHands(); 
                        break;
                    case "2":
                        SeeFestActivities(dateable, dateable.Points, user, user.EnergyPoints);
                        break;
                        case "3":
                        dateable.dateEnd();

                        return;
                }

            }
           
        } 
        public void SeeFestActivities(Person dateable, int points, User user, int EnergyPoints)
        {
            user.energyActions();
            Console.WriteLine("These are the things you can do at the festival:");
            Console.WriteLine("1) Go to the haunted house.");
            Console.WriteLine("2) Go to the tunnel of love.");
            Console.WriteLine("3) Take the ferriswheel.");
            Console.WriteLine(points);
            Console.WriteLine(EnergyPoints);
           
            var activitiesChoice  = Console.ReadLine();
            switch (activitiesChoice)
            {
                case "1":
                    Console.WriteLine($"Being in a spooky mood, you take {dateable.Name} with you to the haunted house");
                    if (dateable.PersonalityType == "Shy")
                    {
                        dateable.getPoints();
                        Console.WriteLine($"{dateable.Name} squeezes their eyes shut the entire ride, holding your hand tightly");
                    }
                    if (dateable.PersonalityType == "Bold")
                    {
                        dateable.getPoints();
                        Console.WriteLine($"It seems as if {dateable.Name} is having the time of their life!");
                    }
                    if (dateable.PersonalityType == "Flirty")
                    {
                        dateable.loosePoints();
                        Console.WriteLine($"{dateable.Name} seems to be bored. They can't see you very well, after all");
                    }

                    break;
            }

        }
    }
}

