using System;
using static System.Console;

namespace HW_Override_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle onlyBase = new Vehicle();
            Vehicle baseWithCar = new Car();
            Vehicle baseWithMotor = new Motorcycle();
            Car onlyCar = new Car();
            Motorcycle onlyMotor = new Motorcycle();
            onlyBase.AddWheel();
            baseWithCar.AddWheel();
            baseWithMotor.AddWheel();
            onlyCar.AddWheel();
            onlyMotor.AddWheel();
            WriteLine("----------------------------");
            onlyBase.OpenOrClosrRoof();
            baseWithCar.OpenOrClosrRoof();
            baseWithMotor.OpenOrClosrRoof();
            onlyCar.OpenOrClosrRoof();
            onlyMotor.OpenOrClosrRoof();
        }
    }
}
