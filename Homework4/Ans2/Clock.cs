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

        public String DT
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
                Console.ReadKey();
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
                Console.ReadKey();
            }
        }

        public void MyTick()
        {
            while (true)
            {
                Thread.Sleep(1000);
                OnTick();

                MyAlarm();
            }
        }

        public void MyAlarm()
        {
            if(DT == DateTime.Now.ToString())
            {
                OnAlarm();
            }
        }
    }
}
