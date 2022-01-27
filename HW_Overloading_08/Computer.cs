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
        private string[] allOpenFiles = null;
        private bool isTurnOn;

        public Computer(string[] allOpenFiles)
        {
            this.allOpenFiles = allOpenFiles;
            this.isTurnOn = true;
        }
        public void TurnOff()
        {
            for (int i = 0; i < allOpenFiles.Length; i++)
            {
                this.allOpenFiles[i] = null;
            }
            this.isTurnOn = false;
            WriteLine("The computer is turned off");
        }
        public void TurnOff(bool force)
        {
            bool isEmpty = allOpenFiles.All(x => !x.Equals(null));
            if (force || (!force && (allOpenFiles.Length == 0 || allOpenFiles == null || isEmpty)))
            {
                TurnOff();
                return;
            }
            WriteLine("The computer is not turned off");
        }
        public void TurnOn()
        {
            this.isTurnOn = true;
            WriteLine("The computer is not turned on");
        }
    }
}
