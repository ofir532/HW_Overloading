using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace HW_Override_04_Challenge
{
    internal class HumanType : Human
    {
        public HumanType(string firstName, string lastName, long id) : base(firstName, lastName, id)
        {
            //this.firstName = firstName;
            //this.lastName = lastName;
            //this.id = id;
        }

        public override bool humanEqualValidation(string firstName, string lastName, long id)
        {
            bool isEqual = false;
            if (this.firstName == firstName && this.lastName == lastName)
                isEqual = true;
            return isEqual;
        }
        public override bool humanEqualValidation(Human human)
        {
            bool isEqual = false;
            if (this.firstName == human.firstName && this.lastName == human.lastName)
                isEqual = true;
            return isEqual;
        }

    }
}
