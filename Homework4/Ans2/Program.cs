using System;

namespace Ans2
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock c = new Clock();
            DiscribeEvent d = new DiscribeEvent();
            c.Tick += new Clock.ClockHandler(d.PrintTick);
            c.Alarm += new Clock.ClockHandler(d.PrintAlarm);

            c.AlarmTime = DateTime.Now.AddSeconds(5).ToString();
            c.StartTick();
        }
    }
}
