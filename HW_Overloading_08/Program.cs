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
            c1.TurnOff(); 
            c1.TurnOn();
            c1.TurnOff(false);
            c1.TurnOn();
            c1.TurnOff(true);            
        }
    }
}
