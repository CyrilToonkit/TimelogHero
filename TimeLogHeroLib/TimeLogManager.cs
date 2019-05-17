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
            _clocks = new List<TimeLogger>() { new TimeLogger {NiceName = "Inactive", Default = true, AutoStart = true, Solo = true, Manager = this} };
            _clocks[0].Activate();
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

            LoadDefault();

            InitClocks();

            return false;
        }

        private void InitClocks()
        {
            foreach (TimeLogger clock in _clocks)
                clock.RefreshDuration();
        }

        public void Load()
        {
            Load(Path.Combine(getFolder(), "session.xml"));
        }

        public string getFolder()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TimeLogHero");
        }
    }
}
