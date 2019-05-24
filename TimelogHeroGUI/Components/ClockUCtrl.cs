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

        public TimelogHeroUctrl Manager
        {
            get { return ParentForm.Controls[0] as TimelogHeroUctrl; }
        }

        public TimeSpan TotalDuration;
        public TimeSpan TodayDuration;

        TimeLogger _clock = null;
        public TimeLogger Clock
        {
            get { return _clock; }
            set { _clock = value; Refresh(); }
        }

        public void RefreshClock()
        {
            if(_clock != null)
            {
                nameEdit.Enabled = !_clock.Default;

                nameEdit.Text = _clock.NiceName;

                RefreshDuration();

                if (_clock.Active)
                {
                    BackColor = TimelogHeroGUI.Properties.Settings.Default.ActiveColor;
                    activateBT.Enabled = false;
                    deactivateBT.Enabled = true;
                }
                else
                {
                    BackColor = _clock.AutoStart ? TimelogHeroGUI.Properties.Settings.Default.InactiveAutoColor : TimelogHeroGUI.Properties.Settings.Default.InactiveColor;
                    activateBT.Enabled = true;
                    deactivateBT.Enabled = false;
                }
            }
        }

        internal void RefreshDuration()
        {
            TodayDuration = _clock.GetDuration(DurationModes.Today);
            TotalDuration = _clock.GetDuration(DurationModes.All);

            clockLBL.Text = TimeLogManager.formatDuration(TodayDuration);
            totalLBL.Text = string.Format("Total {0}", TimeLogManager.formatDuration(TotalDuration));
        }
        
        int IComparable.CompareTo(object obj)
        {
            return _clock.Priority.CompareTo(((ClockUCtrl)obj).Clock.Priority);
        }

        private void activateBT_Click(object sender, EventArgs e)
        {
            Manager.ClockState(_clock, true);
        }

        private void deactivateBT_Click(object sender, EventArgs e)
        {
            Manager.ClockState(_clock, false);
        }

        private void nameLBL_DoubleClick(object sender, EventArgs e)
        {
            nameEdit.Text = _clock.NiceName;
            nameEdit.Show();
        }

        private void nameEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && _clock.Name != nameEdit.Text)
            {
                Manager.Rename(_clock, nameEdit.Text);
            }
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented");
        }

        private void finishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.Finish(_clock);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.Delete(_clock);
        }
    }
}
