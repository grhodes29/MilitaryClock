namespace MilitaryClock
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {

            //Write a console application that:

            //Accurately counts from midnight to midnight using a standard 24hr military format.
            //The clock should be accurate in the way it counts: No skipping numbers; Not displaying 60; etc. 

            //Finished Product should:

            //Not display old times   -- Console.Clear(); ????
            //Allow 1 second to pass between each display // Timer class maybe so we can track 1 second increments
            //Should not use DateTime in any way!!! System.DateTime
            //The clock should start at 00:00:00 when the application starts. 

           
            Timer _t = new Timer();
            
            // seconds which will be 00,01,02 ... 59 and then back to 00

            // minutes
            // each time we complete a loop of the second we want to increment the minutes
            // 01,02 ... 59
            // minutes and seconds are very much alike

            // hours are slightly different
            /// 01,02 .. 23 only
            /// 

            // stop value with be 23:59:59


            // could do this whole thing as three loops ???

            // hours
            for (int _hours = 0; _hours < 24; _hours++)
            {
                // minutes
                for (int _minutes = 0; _minutes < 60; _minutes++)
                {
                    // seconds
                    for (int _seconds = 0; _seconds < 60; _seconds++)
                    {
                        // this where we will sleep for the one second
                        _t.IncrementOneSecond(_hours, _minutes, _seconds);

                        // update timer done internally in Timer class private method
                                                      
                        // update the display
                            Console.Write(" {0}:{1}:{2}", _t.HoursDisplay, _t.MinutesDisplay, _t.SecondsDisplay);
                    }
                }
            }

        }
    }
}
