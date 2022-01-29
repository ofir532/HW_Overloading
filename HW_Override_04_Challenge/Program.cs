using System;
using static System.Console;

namespace HW_Override_04_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human("Ofir", "Dahan", 123456789);
            Human h2 = new Human("Haim", "Cohen", 123456789);
            Human h3 = new Human("Haim", "Cohen", 564654898);
            Human ht1 = new HumanType("Ofir", "Dahan", 123456789);
            Human ht2 = new HumanType("Haim", "Cohen", 123456789);
            Human ht3 = new HumanType("Haim", "Cohen", 564654898);
            #region option 1
            WriteLine(" h1");
            WriteLine(h1 + "compare to: " + h1  + h1.humanEqualValidation(h1.firstName, h1.lastName, h1.id));
            WriteLine(h1 + "compare to: " + h2  + h1.humanEqualValidation(h2.firstName, h2.lastName, h2.id));
            WriteLine(h1 + "compare to: " + h3  + h1.humanEqualValidation(h1.firstName, h3.lastName, h3.id));
            WriteLine(h1 + "compare to: " + ht1 + h1.humanEqualValidation(ht1.firstName, ht1.lastName, ht1.id));
            WriteLine(h1 + "compare to: " + ht2 + h1.humanEqualValidation(ht2.firstName, ht2.lastName, ht2.id));
            WriteLine(h1 + "compare to: " + ht3 + h1.humanEqualValidation(ht3.firstName, ht3.lastName, ht3.id));

            WriteLine("----\n h2 ");
            WriteLine(h2 + "compare to: " + h1  + h2.humanEqualValidation(h1.firstName, h1.lastName, h1.id));
            WriteLine(h2 + "compare to: " + h2  + h2.humanEqualValidation(h2.firstName, h2.lastName, h2.id));
            WriteLine(h2 + "compare to: " + h3  + h2.humanEqualValidation(h3.firstName, h3.lastName, h3.id));
            WriteLine(h2 + "compare to: " + ht1 + h2.humanEqualValidation(ht1.firstName, ht1.lastName, ht1.id));
            WriteLine(h2 + "compare to: " + ht2 + h2.humanEqualValidation(ht2.firstName, ht2.lastName, ht2.id));
            WriteLine(h2 + "compare to: " + ht3 + h2.humanEqualValidation(ht3.firstName, ht3.lastName, ht3.id));

            WriteLine("----\n h3 ");
            WriteLine(h3 + "compare to: " + h1  + h3.humanEqualValidation(h1.firstName, h1.lastName, h1.id));
            WriteLine(h3 + "compare to: " + h2  + h3.humanEqualValidation(h2.firstName, h2.lastName, h2.id));
            WriteLine(h3 + "compare to: " + h3  + h3.humanEqualValidation(h3.firstName, h3.lastName, h3.id));
            WriteLine(h3 + "compare to: " + ht1 + h3.humanEqualValidation(ht1.firstName, ht1.lastName, ht1.id));
            WriteLine(h3 + "compare to: " + ht2 + h3.humanEqualValidation(ht2.firstName, ht2.lastName, ht2.id));
            WriteLine(h3 + "compare to: " + ht3 + h3.humanEqualValidation(ht3.firstName, ht3.lastName, ht3.id));

            WriteLine("----\n ht1 ");
            WriteLine(ht1 + "compare to: " + h1 + ht1.humanEqualValidation(h1.firstName, h1.lastName, h1.id));
            WriteLine(ht1 + "compare to: " + h2 + ht1.humanEqualValidation(h2.firstName, h2.lastName, h2.id));
            WriteLine(ht1 + "compare to: " + h3 + ht1.humanEqualValidation(h3.firstName, h3.lastName, h3.id));
            WriteLine(ht1 + "compare to: " + ht1 + ht1.humanEqualValidation(ht1.firstName, ht1.lastName, ht1.id));
            WriteLine(ht1 + "compare to: " + ht2 + ht1.humanEqualValidation(ht2.firstName, ht2.lastName, ht2.id));
            WriteLine(ht1 + "compare to: " + ht3 + ht1.humanEqualValidation(ht3.firstName, ht3.lastName, ht3.id));

            WriteLine("----\n ht2 ");
            WriteLine(ht2 + "compare to: " + h1  + ht2.humanEqualValidation(h1.firstName, h1.lastName, h1.id));
            WriteLine(ht2 + "compare to: " + h2  + ht2.humanEqualValidation(h2.firstName, h2.lastName, h2.id));
            WriteLine(ht2 + "compare to: " + h3  + ht2.humanEqualValidation(h3.firstName, h3.lastName, h3.id));
            WriteLine(ht2 + "compare to: " + ht1 + ht2.humanEqualValidation(ht1.firstName, ht1.lastName, ht1.id));
            WriteLine(ht2 + "compare to: " + ht2 + ht2.humanEqualValidation(ht2.firstName, ht2.lastName, ht2.id));
            WriteLine(ht2 + "compare to: " + ht3 + ht2.humanEqualValidation(ht3.firstName, ht3.lastName, ht3.id));

            WriteLine("----\n ht3 ");
            WriteLine(ht3 + "compare to: " + h1  + ht3.humanEqualValidation(h1.firstName, h1.lastName, h1.id));
            WriteLine(ht3 + "compare to: " + h2  + ht3.humanEqualValidation(h2.firstName, h2.lastName, h2.id));
            WriteLine(ht3 + "compare to: " + h3  + ht3.humanEqualValidation(h3.firstName, h3.lastName, h3.id));
            WriteLine(ht3 + "compare to: " + ht1 + ht3.humanEqualValidation(ht1.firstName, ht1.lastName, ht1.id));
            WriteLine(ht3 + "compare to: " + ht2 + ht3.humanEqualValidation(ht2.firstName, ht2.lastName, ht2.id));
            WriteLine(ht3 + "compare to: " + ht3 + ht3.humanEqualValidation(ht3.firstName, ht3.lastName, ht3.id));
            #endregion

            #region option 2
            WriteLine(" h1");
            WriteLine(h1 + "compare to: " + h1  + h1.humanEqualValidation(h1));
            WriteLine(h1 + "compare to: " + h2  + h1.humanEqualValidation(h2));
            WriteLine(h1 + "compare to: " + h3  + h1.humanEqualValidation(h3));
            WriteLine(h1 + "compare to: " + ht1 + h1.humanEqualValidation(ht1));
            WriteLine(h1 + "compare to: " + ht2 + h1.humanEqualValidation(ht2));
            WriteLine(h1 + "compare to: " + ht3 + h1.humanEqualValidation(ht3));

            WriteLine("----\n h2 ");
            WriteLine(h2 + "compare to: " + h1  + h2.humanEqualValidation(h1));
            WriteLine(h2 + "compare to: " + h2  + h2.humanEqualValidation(h2));
            WriteLine(h2 + "compare to: " + h3  + h2.humanEqualValidation(h3));
            WriteLine(h2 + "compare to: " + ht1 + h2.humanEqualValidation(ht1));
            WriteLine(h2 + "compare to: " + ht2 + h2.humanEqualValidation(ht2));
            WriteLine(h2 + "compare to: " + ht3 + h2.humanEqualValidation(ht3));

            WriteLine("----\n h3 ");
            WriteLine(h3 + "compare to: " + h1  + h3.humanEqualValidation(h1));
            WriteLine(h3 + "compare to: " + h2  + h3.humanEqualValidation(h2));
            WriteLine(h3 + "compare to: " + h3  + h3.humanEqualValidation(h3));
            WriteLine(h3 + "compare to: " + ht1 + h3.humanEqualValidation(ht1));
            WriteLine(h3 + "compare to: " + ht2 + h3.humanEqualValidation(ht2));
            WriteLine(h3 + "compare to: " + ht3 + h3.humanEqualValidation(ht3));

            WriteLine("----\n ht1 ");
            WriteLine(ht1 + "compare to: " + h1 + ht1.humanEqualValidation(h1));
            WriteLine(ht1 + "compare to: " + h2 + ht1.humanEqualValidation(h2));
            WriteLine(ht1 + "compare to: " + h3 + ht1.humanEqualValidation(h3));
            WriteLine(ht1 + "compare to: " + ht1 +ht1.humanEqualValidation(ht1));
            WriteLine(ht1 + "compare to: " + ht2 +ht1.humanEqualValidation(ht2));
            WriteLine(ht1 + "compare to: " + ht3 +ht1.humanEqualValidation(ht3));

            WriteLine("----\n ht2 ");
            WriteLine(ht2 + "compare to: " + h1  +ht2.humanEqualValidation(h1));
            WriteLine(ht2 + "compare to: " + h2  +ht2.humanEqualValidation(h2));
            WriteLine(ht2 + "compare to: " + h3  +ht2.humanEqualValidation(h3));
            WriteLine(ht2 + "compare to: " + ht1 +ht2.humanEqualValidation(ht1));
            WriteLine(ht2 + "compare to: " + ht2 +ht2.humanEqualValidation(ht2));
            WriteLine(ht2 + "compare to: " + ht3 +ht2.humanEqualValidation(ht3));

            WriteLine("----\n ht3 ");
            WriteLine(ht3 + "compare to: " + h1  +ht3.humanEqualValidation(h1));
            WriteLine(ht3 + "compare to: " + h2  +ht3.humanEqualValidation(h2));
            WriteLine(ht3 + "compare to: " + h3  +ht3.humanEqualValidation(h3));
            WriteLine(ht3 + "compare to: " + ht1 +ht3.humanEqualValidation(ht1));
            WriteLine(ht3 + "compare to: " + ht2 +ht3.humanEqualValidation(ht2));
            WriteLine(ht3 + "compare to: " + ht3 + ht3.humanEqualValidation(ht3));


            #endregion
        }
    }
}
