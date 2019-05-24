using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeLogHeroLib;

namespace TimelogHeroGUI
{
    public partial class TimelogHeroUctrl : UserControl
    {
        Dictionary<string, ClockUCtrl>  _clocks = new Dictionary<string, ClockUCtrl>();

        TimeLogManager _manager = new TimeLogManager();
        public TimeLogManager Manager
        {
            get { return _manager; }
        }

        public TimeSpan TotalDuration;
        public TimeSpan TodayDuration;

        AddClockUCtrl _addNewUCtrl = null; 

        public TimelogHeroUctrl()
        {
            InitializeComponent();

            _manager.Load();

            RefreshClocks();
        }

        public void RefreshUI()
        {
            clocksPL.SuspendLayout();

            clocksPL.Controls.Clear();

            if (_addNewUCtrl == null)
            {
                _addNewUCtrl = new AddClockUCtrl();
                _addNewUCtrl.addLBL.Click += addLBL_Click;
            }

            List<ClockUCtrl> ctrls = new List<ClockUCtrl>(_clocks.Values);
            ctrls.Sort();
            ctrls.Reverse();

            foreach (ClockUCtrl ctrl in ctrls)
            {
                clocksPL.Controls.Add(ctrl);
                ctrl.Dock = DockStyle.Top;
            }

            clocksPL.Controls.Add(_addNewUCtrl);
            _addNewUCtrl.Dock = DockStyle.Top;

            clocksPL.ResumeLayout();
        }

        void addLBL_Click(object sender, EventArgs e)
        {
            AddClock();
        }

        public void RefreshClocks()
        {
            Dictionary<string, ClockUCtrl> oldClocks = new Dictionary<string, ClockUCtrl>(_clocks);

            foreach(TimeLogger logger in _manager.ActiveClocks)
            {
                ClockUCtrl currentCtrl;
                if(_clocks.TryGetValue(logger.Name, out currentCtrl))
                {
                    currentCtrl.RefreshClock();
                    oldClocks.Remove(logger.Name);
                }
                else
                {
                    ClockUCtrl newCLock = new ClockUCtrl() { Clock = logger };
                    newCLock.RefreshClock();
                    _clocks.Add(logger.Name, newCLock);
                }
            }

            foreach(string ctrlName in oldClocks.Keys)
            {
                _clocks.Remove(ctrlName);
            }

            RefreshUI();
        }

        public void FormClosing(object sender, FormClosingEventArgs e)
        {
            _manager.Save();
        }

        #region Wrapper

        public void ClockState(TimeLogger inClock, bool inActivate)
        {
            Manager.ClockState(inClock, inActivate);
            RefreshClocks();
        }

        public void AddClock()
        {
            Manager.AddClock();
            RefreshClocks();
        }

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            TotalDuration = new TimeSpan(0);
            TodayDuration = new TimeSpan(0);

            foreach (ClockUCtrl clock in _clocks.Values)
            {
                clock.RefreshDuration();

                TotalDuration += clock.TotalDuration;
                TodayDuration += clock.TodayDuration;

                totalLBL.Text = string.Format("Total {0} | Today {1}", TimeLogManager.formatDuration(TotalDuration), TimeLogManager.formatDuration(TodayDuration));
            }
        }

        internal void Rename(TimeLogger _clock, string p)
        {
            string newName = Manager.GetUniqueName(p);
            _clocks.Add(newName, _clocks[_clock.Name]);
            _clocks.Remove(_clock.Name);
            _clock.Name = _clock.NiceName = newName;

            RefreshClocks();
        }

        internal void Finish(TimeLogger _clock)
        {
            Manager.Archive(_clock);
            RefreshClocks();
        }

        internal void Delete(TimeLogger _clock)
        {
            DialogResult rslt = MessageBox.Show(string.Format("Permanently delete '{0}' ?", _clock.Name), "Delete item", MessageBoxButtons.OKCancel);
            if (rslt == DialogResult.OK)
            {
                Manager.Delete(_clock);
                RefreshClocks();
            }
        }

        private void ReopenDD_DropDownOpening(object sender, EventArgs e)
        {
            ReopenDD.DropDownItems.Clear();

            foreach (TimeLogger logger in Manager.ArchivedClocks)
            {
                ReopenDD.DropDownItems.Add(logger.Name, null, new EventHandler( cocoToolStripMenuItem_Click));
            }
        }

        private void cocoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.Unarchive((sender as ToolStripDropDownItem).Text);
            RefreshClocks();
        }

        private void todayCB_CheckedChanged(object sender, EventArgs e)
        {
            _manager.OverrideToday = todayCB.Checked;
            if(_manager.OverrideToday)
            {
                _manager.Today = todayDTP.Value;
            }
        }

        private void todayDTP_ValueChanged(object sender, EventArgs e)
        {
            _manager.Today = todayDTP.Value;
        }
    }
}
