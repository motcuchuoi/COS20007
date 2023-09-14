using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CounterClass;

namespace ClockClass
{
    public class Clock
    {
        private Counter _hours;
        private Counter _minutes;
        private Counter _seconds;

        public Clock()
        {
            _hours = new Counter("hours");
            _minutes = new Counter("minutes");
            _seconds = new Counter("seconds");
        }
        public Counter Seconds
        {
            get 
            { 
                return _seconds;
            }
        }

        public Counter Minutes
        {
            get 
            { 
                return _minutes;
            }
        }

        public Counter Hours
        {
            get
            {
                return _hours;
            }
        }

        public void Ticks()
        {
            _seconds.Increment();
            if (_seconds.Ticks > 59)
            {
                _seconds.Reset();
                _minutes.Increment();
            }

            if (_minutes.Ticks > 59)
            {
                _minutes.Reset();
                _hours.Increment();
            }

            if (_hours.Ticks > 23)
            {
                _hours.Reset();
                _minutes.Reset();
                _seconds.Reset();
            }
        }
        public void Reset()
        {
            _hours.Reset();
            _minutes.Reset();
            _seconds.Reset();
        }
        public string GetTime
        {
            get
            {
                return $"{_hours.Ticks:D2}:{_minutes.Ticks:D2}:{_seconds.Ticks:D2}";
            } 
        }
    }
}