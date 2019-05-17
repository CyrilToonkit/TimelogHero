using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeLogHeroLib;

namespace TimelogHeroGUI
{
    public partial class ClockUCtrl : UserControl, IComparable
    {
        public ClockUCtrl()
        {
            InitializeComponent();
        }

        TimeLogger _clock = null;
        public TimeLogger Clock
        {
            get { return Clock; }
            set { _clock = value; Refresh(); }
        }

        private string formatDuration(TimeSpan duration)
        {
            StringBuilder sb = new StringBuilder();

            if (duration.Days > 0)
                sb.Append(string.Format("{0} days ", duration.Days));

            if (duration.Minutes > 0)
                sb.Append(string.Format("{0} min ", duration.Minutes));

            sb.Append(string.Format("{0} s ", duration.Seconds));

            return sb.ToString();
        }
        
        public void RefreshClock()
        {
            if(_clock != null)
            {
                nameLBL.Text = _clock.NiceName;
                clockLBL.Text = formatDuration(_clock.Duration);
            }
        }
        
        int IComparable.CompareTo(object obj)
        {
            return _clock.Priority.CompareTo(((ClockUCtrl)obj).Clock.Priority);
        }
    }
}
