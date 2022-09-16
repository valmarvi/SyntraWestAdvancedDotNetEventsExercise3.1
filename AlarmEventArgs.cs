using System;

namespace AdvancedDotNetEventsExercise3_1
{
    public class AlarmEventArgs : EventArgs
    {
        public DateTime Alarm { get; set; }

        public AlarmEventArgs(DateTime alarm)
        {
            Alarm = alarm;
        }
    }
}