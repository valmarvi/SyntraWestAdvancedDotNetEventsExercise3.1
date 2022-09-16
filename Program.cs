using System;

namespace AdvancedDotNetEventsExercise3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var clock = new Clock();

            clock.AddAlarm(new DateTime(2022, 9, 16, 0, 16, 0));
            clock.AddAlarm(new DateTime(2022, 9, 16, 0, 16, 5));
            clock.AddAlarm(new DateTime(2022, 9, 16, 0, 16, 10));

            clock.AlarmTriggered += Clock_AlarmTriggered;

            void Clock_AlarmTriggered(AlarmEventArgs e)
            {
                Console.WriteLine("Alarm goes off: " + e.Alarm.ToLongTimeString());
            }

            Console.ReadKey();
        }


    }
}
