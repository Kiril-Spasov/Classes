using System;

namespace exercise01
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;


        public void Start()
        {
            _startTime = DateTime.Now;

        }
        public TimeSpan Stop()
        {
            _stopTime = DateTime.Now;
            return _stopTime - _startTime;
        }
    }
}
