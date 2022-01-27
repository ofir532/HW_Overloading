using System;
using static System.Console;


namespace HW_Overloading_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DigitalClock dc1 = new DigitalClock(hours: 12, minutes: 30);
            DigitalClock dc2 = new DigitalClock(hours: 5, minutes: 30);
            DigitalClock dc3 = new DigitalClock(hours: 23, minutes: 7);
            DigitalClock dc4 = new DigitalClock(hours: 8, minutes: 9);
            DigitalClock dc5 = new DigitalClock(hours: 22, minutes: 4, seconds: 44);
            DigitalClock dc6 = new DigitalClock(hours: 7, minutes: 28, seconds: 7);
            //DigitalClock dc7 = new DigitalClock(hours: 23, minutes: 50, seconds: 66);
            //DigitalClock dc8 = new DigitalClock(hours: 50, minutes: 120, seconds: 7);
            DigitalClock dc9 = new DigitalClock(hours: 21, minutes: 30, seconds: 0, days: 5, tempC: 32.5);

            dc1.PrintHourAndMinute();
            dc2.PrintHourAndMinute();
            dc3.PrintHourAndMinute();
            dc4.PrintHourAndMinute();
            dc5.PrintHourAndMinute();
            dc6.PrintHourAndMinute();
            dc2.PrintHourMinuteAndSeconds();
            dc5.PrintHourMinuteAndSeconds();
            dc6.PrintHourMinuteAndSeconds();
            //dc7.PrintHourMinuteAndSeconds();
            //dc8.PrintHourMinuteAndSeconds();
            dc9.PrintHourMinutSecondDayAndTemp();
            Console.WriteLine("--------------------------\n--------------------------");
            dc9.PtintDetails(hours: true, minutes: true);
            dc9.PtintDetails(hours: false, minutes: true);
            dc9.PtintDetails(hours: true, minutes: true,days: true, tempC: true, seconds: true);
            dc9.PtintDetails(true,false,true,true);
            dc9.PtintDetails();

        }
    }
}
