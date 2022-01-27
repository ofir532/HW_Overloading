using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW_Overloading_08
{
    internal class SmartComp : Computer
    {
        private string[] filesInCache;

        public SmartComp(string[] allOpenFiles) : base(allOpenFiles)
        {
        }
    }
}
