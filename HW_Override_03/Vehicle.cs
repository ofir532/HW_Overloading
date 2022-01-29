using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace HW_Override_03
{
    internal class Vehicle
    {
        public int wheels;
        public string color;
        public bool isTheSunRoofOpen;

        public virtual void AddWheel()
        {
            if (wheels < 4)
                wheels = 4;
            WriteLine("The Vehicle has " + wheels + " wheels");
        }
        public void OpenOrClosrRoof()
        {
            if (isTheSunRoofOpen)
            {
                isTheSunRoofOpen = false;
                WriteLine("The sun roof is closed");
            }

            else
            {
                isTheSunRoofOpen = true;
                WriteLine("The sun roof is opened");
            }
        }

    }



}
