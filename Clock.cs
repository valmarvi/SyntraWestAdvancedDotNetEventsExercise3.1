using System;
using System.Collections.Generic;
using System.Threading;

namespace AdvancedDotNetEventsExercise3_1
{
    public class Clock
    {
        private IDictionary<DateTime, bool> _alarms;

        public delegate void AlarmEventHandler(AlarmEventArgs e);

        public event AlarmEventHandler AlarmTriggered;

        public Clock()
        {
            _alarms = new Dictionary<DateTime, bool>();
            new Timer(TimerTriggered, null, 0, 1000);
        }

        public void AddAlarm(DateTime alarm)
        {
            if (!_alarms.ContainsKey(alarm))
            {
                _alarms.Add(alarm, false);
            }
        }

        public void TimerTriggered(object? s)
        {
            foreach (var alarm in _alarms)
            {

                if (alarm.Key <= DateTime.Now && alarm.Value == false)
                {
                    AlarmTriggered?.Invoke(new AlarmEventArgs(alarm.Key));
                    _alarms[alarm.Key] = true;
                }

            }
        }
    }
}
