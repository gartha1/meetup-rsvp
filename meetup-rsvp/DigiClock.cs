using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace meetup_rsvp
{
    class DigiClock
    {
        int hours, mins, seconds;

        public DigiClock(string time)
        {
            string[] parts = time.Split(new char[]{':'});
            
            bool convertedHours = int.TryParse(parts[0],out this.hours);

            bool convertedMins = int.TryParse(parts[1], out this.mins);

            bool convertedSeconds = int.TryParse(parts[2], out this.seconds);

            if (convertedHours && convertedMins && convertedSeconds)
            {
                // all conversions succeded.
            }
            else
            {
                throw new ApplicationException("Time not in correct format");
            }
        }// ctor ends

        public string tick()
        {
            string time="";
            // Inc seconds first
            if (seconds == 59)
            {
                seconds = 0;
                if (mins != 59)
                    mins++;
                else
                {
                    mins = 0;
                    if (hours == 23)
                        hours = 0;
                    else
                        hours++;
                }
            }
            else
                seconds++;

            time = string.Format("{0:D2}:{1:D2}:{2:D2}", hours, mins, seconds);

            return time;
        }

        public void set(string time)
        {
            string[] parts = time.Split(new char[] { ':' });

            bool convertedHours = int.TryParse(parts[0], out this.hours);

            bool convertedMins = int.TryParse(parts[1], out this.mins);

            bool convertedSeconds = int.TryParse(parts[2], out this.seconds);

            if (convertedHours && convertedMins && convertedSeconds)
            {
                // all conversions succeded.
            }
            else
            {
                throw new ApplicationException("Time not in correct format");
            }
        }

    }
}
