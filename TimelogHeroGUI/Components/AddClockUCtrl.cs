using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimelogHeroGUI
{
    public partial class AddClockUCtrl : UserControl
    {
        public AddClockUCtrl()
        {
            InitializeComponent();
        }

        public TimelogHeroUctrl Manager
        {
            get { return ParentForm.Controls[0] as TimelogHeroUctrl; }
        }
    }
}
