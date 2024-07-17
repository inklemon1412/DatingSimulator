using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingSimulator
{
    class Beach : ILocations
    {
        public void GoTo(Person dateable, User user)
        {
            
            Console.WriteLine($"You decided to take {dateable.Name} to the beach");
            if (dateable.PersonalityType == "Shy")
            {
                dateable.getPoints();
                Console.WriteLine($"{dateable.Name} thinks this is a nice spot! ");
            }
            if (dateable.PersonalityType == "Bold")
            {
                dateable.getPoints();
                Console.WriteLine($"Could've been a better spot for{dateable.Name}, but they don't seem too unhappy with your choice");
            }
            if (dateable.PersonalityType == "Flirty")
            {
                dateable.extraPoints();
                Console.WriteLine($"{dateable.Name} has already changed into a sultry swimsuit. Gulp");

            }
            bool _onDate = true;
            while ( _onDate )
            {

            }
        }
    }
}
