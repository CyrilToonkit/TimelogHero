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
    public partial class TimelogHeroForm : Form
    {
        Dictionary<string, ClockUCtrl>  _clocks = new Dictionary<string, ClockUCtrl>();

        TimeLogManager _manager = new TimeLogManager();

        public TimelogHeroForm()
        {
            InitializeComponent();

            _manager.Load();

            RefreshClocks();
        }

        public void RefreshUI()
        {
            clocksFlow.SuspendLayout();

            clocksFlow.Controls.Clear();

            List<ClockUCtrl> ctrls = new List<ClockUCtrl>(_clocks.Values);
            ctrls.Sort();

            foreach (ClockUCtrl ctrl in ctrls)
                clocksFlow.Controls.Add(ctrl);

            clocksFlow.ResumeLayout();
        }

        public void RefreshClocks()
        {
            Dictionary<string, ClockUCtrl> oldClocks = new Dictionary<string, ClockUCtrl>(_clocks);

            foreach(TimeLogger logger in _manager.Clocks)
            {
                ClockUCtrl currentCtrl;
                if(_clocks.TryGetValue(logger.Name, out currentCtrl))
                {
                    currentCtrl.RefreshClock();
                    oldClocks.Remove(logger.Name);
                }
                else
                {
                    _clocks.Add(logger.Name, new ClockUCtrl() { Clock = logger });
                }
            }

            foreach(string ctrlName in oldClocks.Keys)
            {
                _clocks.Remove(ctrlName);
            }

            RefreshUI();
        }

        private void TimelogHeroForm_Load(object sender, EventArgs e)
        {
            _manager.Load();
            /*
            Label tst = new Label();
            tst.Text = _manager.getPath();

            clocksFlow.Controls.Add(tst);
            */
        }

        private void TimelogHeroForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _manager.Save();
        }
    }
}
