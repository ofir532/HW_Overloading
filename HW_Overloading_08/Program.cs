using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace HW_Overloading_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] files1 = { "My pc", "Chrome" };
            Computer c1 = new Computer(files1);
            Computer c2 = new Computer(files1);
            SmartComp sc1 = new SmartComp(files1);
            SmartComp sc2 = new SmartComp(files1);
            SmartComp sc3 = new SmartComp(files1);
            SmartComp sc4 = new SmartComp(files1);
            c1.TurnOff(); 
            c1.TurnOn();
            c1.TurnOff(false);
            c1.TurnOn();
            c1.TurnOff(true);
            c2.TurnOff(false);
            WriteLine("SmartComp:");
            sc1.TurnOff(true, true);
            sc2.TurnOff(false, true);
            sc3.TurnOff(false, false);
            sc4.TurnOff(true, false);
        }
    }
}
