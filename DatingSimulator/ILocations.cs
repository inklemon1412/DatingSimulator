using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingSimulator
{
    interface ILocations
    {
        void GoTo(Person dateable, Actions actions, Profile profile);
    }
}
