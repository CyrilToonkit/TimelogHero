using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TimeLogHeroLib
{
    public class TimeLogManager
    {
        List<TimeLogger> _clocks = new List<TimeLogger>();
        public List<TimeLogger> Clocks
        {
            get { return _clocks; }
            set { _clocks = value; }
        }

        [XmlIgnore]
        public List<TimeLogger> ActiveClocks
        {
            get { return _clocks.Where(c => !c.Archived).ToList(); }
        }

        [XmlIgnore]
        public List<TimeLogger> ArchivedClocks
        {
            get { return _clocks.Where(c => c.Archived).ToList(); }
        }

        public static string formatDuration(TimeSpan duration)
        {
            StringBuilder sb = new StringBuilder();

            int hours = duration.Days * 24 + duration.Hours;

            if (hours > 0)
                sb.Append(string.Format("{0} h ", hours));

            if (duration.Minutes > 0)
                sb.Append(string.Format("{0} m ", duration.Minutes));

            sb.Append(string.Format("{0} s ", duration.Seconds));

            return sb.ToString();
        }

        /// <summary>
        /// Serialize the Data to a file
        /// </summary>
        /// <param name="inPath">Path to save the file to</param>
        /// <param name="inOverWrite">OverWrite if exists</param>
        /// <returns>True in case of success</returns>
        public bool Save(string inPath, bool inOverWrite)
        {
            FileInfo ThisFileInfo = new FileInfo(inPath);

            if (inOverWrite || !(ThisFileInfo.Exists))
            {
                XmlSerializer thisSaveable = new XmlSerializer(GetType());
                DirectoryInfo parentDir = ThisFileInfo.Directory;

                if (!parentDir.Exists)
                {
                    parentDir.Create();
                }

                if (ThisFileInfo.Exists)
                {
                    ThisFileInfo.Delete();
                }

                FileStream stream = ThisFileInfo.OpenWrite();

                try
                {
                    thisSaveable.Serialize(stream, this);
                    stream.Close();
                    return true;
                }
                catch (Exception)
                {
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
            }

            return false;
        }

        public void Save()
        {
            Save(Path.Combine(getFolder(), "session.xml"), true);
        }

        public void LoadDefault()
        {
        }

        /// <summary>
        /// Deserialize the Data to a file, Always overwriting
        /// </summary>
        /// <param name="inPath">Path to load the file from</param>
        /// <returns>True in case of Success</returns>
        public bool Load(string inPath)
        {
            FileInfo ThisFileInfo = new FileInfo(inPath);

            if (ThisFileInfo.Exists)
            {
                XmlSerializer thisSaveable = new XmlSerializer(GetType());
                FileStream stream = ThisFileInfo.OpenRead();

                try
                {
                    TimeLogManager loaded = (TimeLogManager)thisSaveable.Deserialize(stream);

                    _clocks = loaded.Clocks;

                    stream.Close();
                }
                catch (Exception)
                {
                    if (stream != null)
                    {
                        stream.Close();
                    }
                }
            }
            else
            {
                LoadDefault();
            }

            return false;
        }

        /*
        public void RefreshDuration()
        {
            foreach (TimeLogger clock in _clocks)
                clock.RefreshDuration();
        }*/

        public void Load()
        {
            Load(Path.Combine(getFolder(), "session.xml"));
        }

        public string getFolder()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TimeLogHero");
        }

        public void ClockState(TimeLogger inClock, bool inActivate)
        {
            bool newValue = inActivate;

            List<TimeLogger> toActivate = new List<TimeLogger>();
            List<TimeLogger> toDeActivate = new List<TimeLogger>();

            (inActivate ? toActivate : toDeActivate).Add(inClock);

            bool allDeactivated = !inActivate;

            foreach (TimeLogger clock in _clocks)
            {
                if (clock == inClock)
                    continue;

                if(inActivate)
                {
                    if (clock.Active)
                    {
                        if(inClock.Solo || clock.Solo)
                            toDeActivate.Add(clock);
                        else if(allDeactivated)
                            allDeactivated = false;
                    }
                }
                else if (clock.Active && allDeactivated)
                {
                    allDeactivated = false;
                }
            }

            if (allDeactivated)
            {
                List<TimeLogger> autoStartCandidates = new List<TimeLogger>();

                foreach (TimeLogger clock in _clocks)
                {
                    if (clock.AutoStart)
                        autoStartCandidates.Add(clock);
                }

                //Reactivate an available TimeLogger
                if (autoStartCandidates.Count > 0)
                {
                    autoStartCandidates.Sort();
                    toActivate.Add(autoStartCandidates[0]);
                }
                else
                {
                    //Reactivate the same logger
                    //toDeActivate.Remove(inClock);
                }
            }

            foreach (TimeLogger clock in toActivate)
            {
                clock.Activate();
            }

            foreach (TimeLogger clock in toDeActivate)
            {
                clock.DeActivate();
            }
        }

        public string GetUniqueName(string inName)
        {
            string uniqueName = inName;
            bool unique = false;
            int index = 0;

            while(!unique)
            {
                bool exists = false;
                foreach (TimeLogger clock in _clocks)
                {
                    if(clock.Name == uniqueName)
                    {
                        index += 1;
                        uniqueName = inName + index.ToString();
                        exists = true;
                        break;
                    }
                }

                if(!exists)
                    unique = true;
            }

            return uniqueName;
        }

        public void AddClock()
        {
            TimeLogger newClock = new TimeLogger();

            newClock.Name = newClock.NiceName = GetUniqueName(newClock.Name);

            List<int> priorities = new List<int>(){-1};

            foreach (TimeLogger clock in _clocks)
            {
                priorities.Add(clock.Priority);
            }

            priorities.Sort();
            priorities.Reverse();

            newClock.Priority = priorities[0] + 1;

            _clocks.Add(newClock);
        }

        public void Archive(TimeLogger inClock)
        {
            if (inClock.Active)
                ClockState(inClock, false);

            inClock.Archived = true;
        }

        public void Delete(TimeLogger inClock)
        {
            if (inClock.Active)
                ClockState(inClock, false);

            _clocks.Remove(inClock);
        }

        public void Unarchive(string clockName)
        {
            foreach (TimeLogger clock in ArchivedClocks)
            {
                if (clock.Name == clockName)
                {
                    clock.Archived = false;
                    break;
                }
            }
        }
    }
}
