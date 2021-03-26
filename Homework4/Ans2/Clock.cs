using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Ans2
{
    class Clock
    {
        public delegate void ClockHandler();
        public event ClockHandler Tick;
        public event ClockHandler Alarm;

        public String AlarmTime
        {
            get; set;
        }

        protected virtual void OnTick()
        {
            if(Tick != null)
            {
                Tick();
            }
            else
            {
                Console.WriteLine("TickEvent not fire");
            }
        }

        protected virtual void OnAlarm()
        {
            if (Alarm != null)
            {
                Alarm();
            }
            else
            {
                Console.WriteLine("AlarmEvent not fire");
            }
        }

        public void StartTick()
        {
            while (true)
            {
                Thread.Sleep(1000);
                OnTick();

                if (AlarmTime == DateTime.Now.ToString())
                {
                    OnAlarm();
                }
            }
        }
    }
}
