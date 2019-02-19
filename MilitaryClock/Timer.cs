namespace MilitaryClock
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// DESCRIPTION: 
    /// </summary>
    public class Timer
    {
        private const int _milliseconds = 1000;

        public string SecondsDisplay { get; set; }
        public string MinutesDisplay { get; set; }
        public string HoursDisplay { get; set; }
        // total seconds is (23 * 60 *60) = 82800 seconds + (59 * 60) 3540 seconds + 59 seconds = 86399
        private int TotalElapseTimeInSeconds { get; set; }
        private int Seconds { get; set; }
        private int Minutes { get; set; }
        private int Hours { get; set; }

        private Stopwatch Watch { get; set; }


        public Timer() {

            Watch = new Stopwatch();
            TotalElapseTimeInSeconds = 0;
            this.Hours = 0;
            this.Minutes = 0;
            this.Seconds = 0;
            this.SecondsDisplay = "00";
            this.MinutesDisplay = "00";
            this.HoursDisplay = "00";
        }


        public void IncrementOneSecond(int inHrs, int inMinutes, int inSeconds) {

            // so technically, 1000 milliseconds = 1 secs so make sure you set it 
            // correctly here before handing it in
            Watch.Start();
            Thread.Sleep(_milliseconds);
            Watch.Stop();

            // this should update all the string properties for the display
            UpdateTimer(inHrs, inMinutes, inSeconds);

        }


        private void UpdateTimer(int inHrs, int inMins, int inSecs)
        {
            // write some pseudocode here
            this.Seconds = inSecs;
            this.Minutes = inMins;
            this.Hours = inHrs;
            this.TotalElapseTimeInSeconds++;
            ConvertIntTimeToStringTime();

        }

        private void ConvertIntTimeToStringTime() {

            this.HoursDisplay = Hours.ToString("D2");
            this.MinutesDisplay = Minutes.ToString("D2");
            this.SecondsDisplay = Seconds.ToString("D2");

        }

    }
}
