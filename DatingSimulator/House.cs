using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingSimulator
{
    class House : ILocations
    {
        public void GoTo(Person dateable, User user)
        {
            
            if (dateable.Points == 100)
            {
                Console.WriteLine($"Feeling you were close enough, you wanted to take {dateable.Name} to your home.");
            }
            else
            {
                Console.WriteLine($"You are not close enough to {dateable.Name} to take them to your house yet. Awkward!");
            }
            bool _onDate = true;
        }
    }
}
