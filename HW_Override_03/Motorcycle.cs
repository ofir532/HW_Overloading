using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace HW_Override_03
{
    internal class Motorcycle : Vehicle
    {

        public override void AddWheel()
        {
            if (wheels < 2)
                wheels = 2;
            WriteLine("The Vehicle has " + wheels + " wheels");
        }
        public new void OpenOrClosrRoof()
        {
            isTheSunRoofOpen = true;
            WriteLine("On a motorcycle, the sun roof is always open");
        }

    }
}
