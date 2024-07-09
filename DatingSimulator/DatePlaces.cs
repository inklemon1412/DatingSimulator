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
        private readonly object userName;

        public void DatePlaceMenu(object userName, Person dateable)
        {
            Console.WriteLine($"Welcome to the super duper awesome choose your own date place menu, {userName}!");


            Console.WriteLine($" Here you can choose where to go with {dateable.Name}. \r\nBut be careful! \r\n Take the wrong person to the wrong place, \r\n and you might just loose the game ;) (and be sad and lonely for the rest of your life) ");
            Console.WriteLine("Where would you like to go?");
            Console.WriteLine("1) The park");
            Console.WriteLine("2) The festival being held in your town");
            Console.WriteLine("3) The beach");
            Console.WriteLine("4) Your house");
            Console.WriteLine("5) ");

            Console.WriteLine($"Your current dating points are: {dateable.Points}");
            var dateChoice = Console.ReadLine();
            switch (dateChoice)
            {
                case "1":
                    goToPark(dateable);
                    break;
                case "2":
                    goToFestival(dateable);
                    break;
                case "3":
                    goToBeach(dateable);
                    break;
                case "4":
                    goToHouse(dateable);
                    break;
                    
            } return;
            
        }
        public void goToPark(Person dateable)
        {
            bool _onDate = true;
           
                Console.WriteLine($"You have decided to take {dateable.Name} to the park ");

                if (dateable.PersonalityType == "Shy")
                {
                    dateable.getPoints();
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
                
            while (_onDate)
                { 
                    Console.WriteLine($"Here you can choose a variety of things you'd like to do with your date");
                Console.WriteLine("1) to hold hands");
                Console.WriteLine($"2) Chat with {dateable.Name}");
                Console.WriteLine("6) to end the date");
                Console.WriteLine($"Your current dating points are: {dateable.Points}");
                string datingChoice = Console.ReadLine();
               switch (datingChoice)
                {
                    case "1":
                        if (dateable.Points != 20)
                        {
                            Console.WriteLine($"{dateable.Name} seems a bit confused. Maybe try building up your relationship first");
                            

                        }
                        else
                        {
                            Console.WriteLine($"Blushing a bit, {dateable.Name} takes your hand");
                            dateable.getPoints();
                           
                        }
                        break;
                    case "6":
                        if (dateable.Points == 50)
                        {
                            Console.WriteLine($"What a successful date! {dateable.Name} seemed to have a lot of fun with you!");
                        }
                        else
                        {
                            Console.WriteLine($"The date went okay. Better luck next time with {dateable.Name}");
                        }
                            DatePlaceMenu(userName, dateable);
                        break;


                }

             

            }

        }
        public void goToFestival(Person dateable)
        {
            bool _onDate = true;
            Console.WriteLine($"You decided to take {dateable.Name} to the local festival");

            if (dateable.PersonalityType == "Shy")
            {
                dateable.loosePoints();
                Console.WriteLine($"It would seem that {dateable.Name} is a bit unhappy with the choice of place. Too many people around ");
            }
            if (dateable.PersonalityType == "Bold")
            {
                dateable.getPoints();
                Console.WriteLine($"{dateable.Name} gives you a smile. It is clear that they are enjoying this!");
            }
            if (dateable.PersonalityType == "Flirty")
            {
                dateable.getPoints();
                Console.WriteLine($"It would seem that this was a good place to take {dateable.Name} to!");

            }
            while (_onDate)
            {
                Console.WriteLine($"Here you can choose a variety of things you'd like to do with your date");
                Console.WriteLine("1) to hold hands");

            }
        }


        public void goToBeach(Person dateable)
        {

        }

        public void goToHouse(Person dateable)
        {

        }
  
       
    }
}

