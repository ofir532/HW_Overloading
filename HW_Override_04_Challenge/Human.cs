using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW_Override_04_Challenge
{
    internal class Human
    {
        public string firstName;
        public string lastName;
        public long id;

        public Human(string firstName, string lastName, long id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }

        public virtual bool humanEqualValidation(string firstName, string lastName, long id)
        {
            bool isEqual = false;
            if (this.id == id)
                isEqual = true;
            return isEqual;
        }
        public virtual bool humanEqualValidation(Human human)
        {
            bool isEqual = false;
            if (this.id == human.id)
                isEqual = true;
            return isEqual;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName} {id} ";
        }

    }
}
