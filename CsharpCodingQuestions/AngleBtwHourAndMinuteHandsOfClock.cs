﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpCodingQuestions
{
    class AngleBtwHourAndMinuteHandsOfClock
    {
        /* find the angle between hour and minute hands of a clock at any given time:
         * The user will input the hour and minute of the time and the method should give the angle between the hour hand 
         * and minute hand at that given time.
         * 
         * input: 9 30, output: The angle between hour hand and minute hand is 105 degrees
         * input: 13 30, output: The angle between hour hand and minute hand is 135 degrees
         * 
         * The logic is to find the difference in the angle of an hour and minute hand from the position of 12 O Clock when 
         * the angle between them is zero. Each hour on the clock represents an angle of 30 degrees (360 divided by 12). 
         * Similarly, each minute on the clock will represent an angle of 6 degrees (360 divided by 60) and the angle for an hour 
         * will increase as the minutes for that hour increases.
         */

        internal static void FindAngleinTime(int hours, int mins)
        {
            double hourDegrees = (hours * 30) + (mins * 30.0 / 60);
            double minuteDegrees = mins * 6;

            double diff = Math.Abs(hourDegrees - minuteDegrees);

            if (diff > 180)
            {
                diff = 360 - diff;
            }

            Console.WriteLine("The angle between hour hand and minute hand is {0} degrees", diff);
        }
    }
}
