using System;
using System.Timers;
namespace CSRegler.Services
{
    public class TempTimer
    {
        private System.Timers.Timer aTimer;

        public void SetTimer(double interval)
        {
            aTimer = new System.Timers.Timer(interval);
            aTimer.Elapsed += TimedOut;
            aTimer.Enabled = true;
        }
        public event Action OnTimeout;
        private void TimedOut(Object source, ElapsedEventArgs e)
        {
            OnTimeout();
        }
    }
}
