﻿using System;
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
        public TimelogHeroForm()
        {
            InitializeComponent();
        }

        public void TimelogHeroForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timelogHeroUctrl1.FormClosing(sender, e);
        }
    }
}
