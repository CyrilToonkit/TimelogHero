using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimelogHeroGUI
{
    public partial class ReorderableFlow : FlowLayoutPanel
    {
        public ReorderableFlow()
        {
            InitializeComponent();
        }

        public ReorderableFlow(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
