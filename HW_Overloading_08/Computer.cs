using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW_Overloading_08
{
    internal class Computer
    {
        public string[] allOpenFiles = null;
        public bool isTurnOn;

        public Computer(string[] allOpenFiles)
        {
            this.allOpenFiles = allOpenFiles;
            this.isTurnOn = true;
        }
        public void TurnOff()
        {
            this.allOpenFiles = null;
            this.isTurnOn = false;
            WriteLine("The computer is turned off");
        }
        public void TurnOff(bool force)
        {
            if (force || (!force && allOpenFiles == null))
            {
                TurnOff();
                return;
            }
            WriteLine("The computer is not turned off");
        }
        public void TurnOn()
        {
            this.isTurnOn = true;
            WriteLine("The computer is turned on");
        }
    }
}
