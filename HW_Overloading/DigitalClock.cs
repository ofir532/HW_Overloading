using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace HW_Overloading_07
{
    internal class DigitalClock
    {
        #region fields
        private int hours;
        private int minutes;
        private int seconds;
        private int days;
        private double tempC;
        #endregion

        #region constructors
        private DigitalClock(int hours)
        {
            if (hours > 23 || hours < 0)
                throw new ArgumentException("Hours must be in range 0 - 23");
            this.hours = hours;
        }
        public DigitalClock(int hours, int minutes) : this(hours)
        {
            if (minutes > 59 || minutes < 0)
                throw new ArgumentException("Minutes must be in range 0 - 59");
            this.minutes = minutes;
        }
        public DigitalClock(int hours, int minutes, int seconds) : this(hours, minutes)
        {
            if (seconds > 59 || seconds < 0)
                throw new ArgumentException("Seconds must be in range 0 - 59");
            this.seconds = seconds;
        }
        private DigitalClock(int hours, int minutes, int seconds, int days) : this(hours, minutes, seconds)
        {
            if (days > 7 || days < 1)
                throw new ArgumentException("Day must be in range 1 - 7");
            this.days = days;
        }
        public DigitalClock(int hours, int minutes, int seconds, int days, double tempC) : this(hours, minutes, seconds, days)
        {
            if (tempC < -273.15)
                throw new ArgumentException("The temperature can not be lower than 273.15(Absolute zero).");
            this.tempC = tempC;
        }
        #endregion

        #region Functions
        public void PrintHourAndMinute()
        {
            WriteLine(StrHours() + ":" + StrMinutes());
        }
        public void PrintHourMinuteAndSeconds()
        {
            WriteLine(StrHours() + ":" + StrMinutes() + ":" + StrSeconds());
        }
        public void PrintHourMinutSecondDayAndTemp()
        {
            if (days == 0)
                throw new ArgumentException("Day must be in range 1 - 7");
            WriteLine(StrDays() + ": " + StrHours() + ":" + StrMinutes() + ":" + StrSeconds() + ". " + StrTempC());
        }
        public void PtintDetails(bool hours = false, bool minutes = false, bool seconds = false, bool days = false, bool tempC = false)
        {
            string text = $"The details of your instance are:\n";
            if (days)
                text += $"Day: {StrDays()}.\n";
            if (hours)
                text += $"Hours: {StrHours()}.\n";
            if (minutes)
                text += $"Minutes: {StrMinutes()}.\n";
            if (seconds)
                text += $"Seconds: {StrSeconds()}.\n";
            if (tempC)
                text += StrTempC()+"\n";
            WriteLine(text);
        }

        #endregion

        #region Additional Functions 
        private string StrHours()
        {
            string strHours = hours.ToString();
            if (hours < 10)
                strHours = "0" + strHours;
            return strHours;
        }
        private string StrMinutes()
        {
            string strMinutes = minutes.ToString();
            if (minutes < 10)
                strMinutes = "0" + strMinutes;
            return strMinutes;
        }
        private string StrSeconds()
        {
            string strSeconds = seconds.ToString();
            if (seconds < 10)
                strSeconds = "0" + strSeconds;
            return strSeconds;
        }
        private string StrDays()
        {
            string strDays;
            switch (days)
            {
                case 1:
                    strDays = "Sunday";
                    break;
                case 2:
                    strDays = "Monday";
                    break;
                case 3:
                    strDays = "Tuesday";
                    break;
                case 4:
                    strDays = "Wednesday";
                    break;
                case 5:
                    strDays = "Thursday";
                    break;
                case 6:
                    strDays = "Friday";
                    break;
                case 7:
                    strDays = "Saturday";
                    break;
                default:
                    strDays = null;
                    break;
            }
            return strDays;
        }
        private string StrTempC()
        {
            string strTempC = "The temperature is: " + tempC.ToString() + "°C.";
            return strTempC;
        }
        #endregion
    }
}
