using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TimeLogHeroLib
{
    public enum DurationModes
    {
        Today, Unarchived, All
    }

    public class TimeLogger
    {
        TimeLogManager _manager = null;
        [XmlIgnore]
        public TimeLogManager Manager
        {
            get { return _manager; }
            set { _manager = value; }
        }

        #region time
        /*
        TimeSpan _duration = TimeSpan.Zero;
        [XmlIgnore]
        public TimeSpan Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }*/

        bool _active = false;
        public bool Active
        {
            get { return _active; }
            set
            {
                _active = value;
            }
        }
        
        #endregion

        #region basic
        string _name = "";
        public string Name
        {
            get { return string.IsNullOrEmpty(_name) ? _niceName : _name; }
            set { _name = value; }
        }

        string _niceName = "New Task";
        public string NiceName
        {
            get { return _niceName; }
            set { _niceName = value; }
        }

        string _project = "New Project";
        public string Project
        {
            get { return _project; }
            set { _project = value; }
        }

        string _user = "";
        public string User
        {
            get { return string.IsNullOrEmpty(_user) ? Environment.UserName : _user; }
            set { _user = value; }
        }

        #endregion

        #region behavior
        bool _default = false;
        public bool Default
        {
            get { return _default; }
            set { _default = value; }
        }

        int _priority = 0;
        public int Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        bool _autoStart = false;
        public bool AutoStart
        {
            get { return _autoStart; }
            set { _autoStart = value; }
        }

        bool _solo = true;
        public bool Solo
        {
            get { return _solo; }
            set { _solo = value; }
        }

        bool _archived = false;
        public bool Archived
        {
            get { return _archived; }
            set { _archived = value; }
        }
        #endregion

        List<ActivationChanged> _history = new List<ActivationChanged>();
        public List<ActivationChanged> History
        {
            get { return _history; }
            set { _history = value; }
        }

        public List<ActivationChanged> ActiveHistory
        {
            get { return _history.SkipWhile(h => h.Archived).ToList(); }
        }

        public void Activate()
        {
            if(!_active)
            {
                _active = true;
                _history.Add(new ActivationChanged() { Date = DateTime.Now, Activated = true });
            }
        }

        public void DeActivate()
        {
            if (_active)
            {
                _active = false;
                _history.Add(new ActivationChanged() { Date = DateTime.Now, Activated = false });
            }
        }

        public TimeSpan GetDuration(DurationModes inMode)
        {
            TimeSpan duration = new TimeSpan(0);

            List<ActivationChanged> history = inMode == DurationModes.Unarchived ? ActiveHistory : _history;

            DateTime now = Manager != null ? Manager.Today : DateTime.Now;

            DateTime todayDateTime = new DateTime(now.Year, now.Month, now.Day);

            DateTime lastStart = new DateTime(0);
            foreach (ActivationChanged activation in history)
            {
                if (activation.Activated)
                {
                    lastStart = activation.Date;
                }
                else
                {
                    if (lastStart.Ticks > 0)
                    {
                        if (inMode == DurationModes.Today)
                        {
                            if (now.Year == activation.Date.Year && now.DayOfYear == activation.Date.DayOfYear)
                            {
                                duration += activation.Date - (lastStart > todayDateTime ? lastStart : todayDateTime);
                            }
                        }
                        else
                            duration += activation.Date - lastStart;
                    }
                }
            }

            //If its was activated till now
            if (history.Count > 0 && history[history.Count - 1].Activated)
            {
                if (inMode == DurationModes.Today)
                {
                    duration += now - (history[history.Count - 1].Date > todayDateTime ? history[history.Count - 1].Date : todayDateTime);//
                }
                else
                    duration += now - history[history.Count - 1].Date;
            }

            return duration;
        }
        /*
        public void RefreshDuration()
        {
            RefreshDuration(true);
        }
        
        public void RefreshDuration(bool inSkipArchived)
        {
            Duration = new TimeSpan(0);

            List<ActivationChanged> history = inSkipArchived ? ActiveHistory : _history;

            DateTime lastStart = new DateTime(0);
            foreach (ActivationChanged activation in history)
            {
                if(activation.Activated)
                {
                    lastStart = activation.Date;
                }
                else
                {
                    if(lastStart.Ticks > 0)
                    {
                        Duration += activation.Date - lastStart;
                    }
                }
            }

            //If its was activated till now
            if (history.Count > 0 && history[history.Count - 1].Activated)
            {
                D
            }
        }*/
    }
}
