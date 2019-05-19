namespace TimelogHeroGUI
{
    partial class TimelogHeroUctrl
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimelogHeroUctrl));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.totalLBL = new System.Windows.Forms.ToolStripLabel();
            this.clocksPL = new System.Windows.Forms.Panel();
            this.ReopenDD = new System.Windows.Forms.ToolStripDropDownButton();
            this.cocoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalLBL,
            this.ReopenDD});
            this.toolStrip1.Location = new System.Drawing.Point(0, 374);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(814, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // totalLBL
            // 
            this.totalLBL.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.totalLBL.Name = "totalLBL";
            this.totalLBL.Size = new System.Drawing.Size(54, 22);
            this.totalLBL.Text = "0 s today";
            // 
            // clocksPL
            // 
            this.clocksPL.AutoScroll = true;
            this.clocksPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clocksPL.Location = new System.Drawing.Point(0, 0);
            this.clocksPL.Name = "clocksPL";
            this.clocksPL.Size = new System.Drawing.Size(814, 374);
            this.clocksPL.TabIndex = 2;
            // 
            // ReopenDD
            // 
            this.ReopenDD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ReopenDD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cocoToolStripMenuItem});
            this.ReopenDD.Image = ((System.Drawing.Image)(resources.GetObject("ReopenDD.Image")));
            this.ReopenDD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReopenDD.Name = "ReopenDD";
            this.ReopenDD.Size = new System.Drawing.Size(60, 22);
            this.ReopenDD.Text = "Reopen";
            this.ReopenDD.DropDownOpening += new System.EventHandler(this.ReopenDD_DropDownOpening);
            // 
            // cocoToolStripMenuItem
            // 
            this.cocoToolStripMenuItem.Name = "cocoToolStripMenuItem";
            this.cocoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cocoToolStripMenuItem.Text = "Coco";
            this.cocoToolStripMenuItem.Click += new System.EventHandler(this.cocoToolStripMenuItem_Click);
            // 
            // TimelogHeroUctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clocksPL);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TimelogHeroUctrl";
            this.Size = new System.Drawing.Size(814, 399);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel totalLBL;
        private System.Windows.Forms.Panel clocksPL;
        private System.Windows.Forms.ToolStripDropDownButton ReopenDD;
        private System.Windows.Forms.ToolStripMenuItem cocoToolStripMenuItem;
    }
}

