using DatingSimulator;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DatingSimulator
{
    
    internal class DatePlaces
    {
        Park park= new Park();
        Festival festival= new Festival();
        Beach beach = new Beach();
        House house = new House();
        
        
        private readonly object userName;

        public void DatePlaceMenu(string? userName, Person dateable, Actions actions, Profile profile)
        {
           
            Console.WriteLine($"Welcome to the super duper awesome choose your own date place menu, {userName}!");


            Console.WriteLine($" Here you can choose where to go with {dateable.Name}. \r\nBut be careful! \r\n Take the wrong person to the wrong place, \r\n and you might just loose the game ;) (and be sad and lonely for the rest of your life) ");
            Console.WriteLine("Where would you like to go?");
            Console.WriteLine("1) The park");
            Console.WriteLine("2) The festival being held in your town");
            Console.WriteLine("3) The beach");
            Console.WriteLine("4) Your house");

            if (actions.EnergyPoints < 20)
            {
                Console.WriteLine("5) Go home and rest ");
            }

            Console.WriteLine($"Your current dating points are: {dateable.Points}");
            Console.WriteLine($"Current energy: {actions.EnergyPoints}. Hint: actions taken during dates will cost you 10 energy. Refill energy by either:");
            Console.WriteLine("Going home to sleep once it reaches a low level, or buy food to raise it up");
            var dateChoice = Console.ReadLine();
            switch (dateChoice)
            {
                case "1":
                   park.GoTo(dateable, actions, profile);
                    break;
                case "2":
                    festival.GoTo(dateable, actions, profile);
                    break;
                case "3":
                    beach.GoTo(dateable, actions, profile);
                    break;
                case "4":
                    house.GoTo(dateable, actions, profile);
                    break;
                case "5":
                    actions.GoSleep();
                    break;
                    
            } return;
            
        }

    
    }
}


