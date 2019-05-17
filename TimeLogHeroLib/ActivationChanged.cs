using System;

namespace TimeLogHeroLib
{
    public class ActivationChanged
    {
        DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        bool _activated = false;
        public bool Activated
        {
            get { return _activated; }
            set { _activated = value; }
        }
    }
}