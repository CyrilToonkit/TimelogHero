namespace TimelogHeroGUI
{
    partial class ClockUCtrl
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClockUCtrl));
            this.clockLBL = new System.Windows.Forms.Label();
            this.borderPanel = new System.Windows.Forms.Panel();
            this.nameEdit = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.optionsDD = new System.Windows.Forms.ToolStripDropDownButton();
            this.finishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.totalLBL = new System.Windows.Forms.Label();
            this.deactivateBT = new System.Windows.Forms.Button();
            this.activateBT = new System.Windows.Forms.Button();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borderPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clockLBL
            // 
            this.clockLBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clockLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLBL.Location = new System.Drawing.Point(402, 0);
            this.clockLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clockLBL.Name = "clockLBL";
            this.clockLBL.Size = new System.Drawing.Size(136, 34);
            this.clockLBL.TabIndex = 1;
            this.clockLBL.Text = "25 d 15 h 07 min 32 s";
            this.clockLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borderPanel
            // 
            this.borderPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.borderPanel.Controls.Add(this.tableLayoutPanel1);
            this.borderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borderPanel.Location = new System.Drawing.Point(4, 4);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Size = new System.Drawing.Size(554, 34);
            this.borderPanel.TabIndex = 3;
            // 
            // nameEdit
            // 
            this.nameEdit.BackColor = System.Drawing.Color.LightGray;
            this.nameEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameEdit.Location = new System.Drawing.Point(3, 3);
            this.nameEdit.Name = "nameEdit";
            this.nameEdit.Size = new System.Drawing.Size(194, 29);
            this.nameEdit.TabIndex = 3;
            this.nameEdit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nameEdit_KeyUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsDD});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(540, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(14, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // optionsDD
            // 
            this.optionsDD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.optionsDD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finishToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.propertiesToolStripMenuItem});
            this.optionsDD.Image = ((System.Drawing.Image)(resources.GetObject("optionsDD.Image")));
            this.optionsDD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.optionsDD.Name = "optionsDD";
            this.optionsDD.Size = new System.Drawing.Size(13, 31);
            // 
            // finishToolStripMenuItem
            // 
            this.finishToolStripMenuItem.Name = "finishToolStripMenuItem";
            this.finishToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.finishToolStripMenuItem.Text = "Finish";
            this.finishToolStripMenuItem.Click += new System.EventHandler(this.finishToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.propertiesToolStripMenuItem.Text = "Properties...";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.Controls.Add(this.activateBT, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.deactivateBT, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.totalLBL, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameEdit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clockLBL, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(554, 34);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // totalLBL
            // 
            this.totalLBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLBL.Location = new System.Drawing.Point(202, 0);
            this.totalLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalLBL.Name = "totalLBL";
            this.totalLBL.Size = new System.Drawing.Size(136, 34);
            this.totalLBL.TabIndex = 4;
            this.totalLBL.Text = "Total 25 d 15 h 07 min 32 s";
            this.totalLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deactivateBT
            // 
            this.deactivateBT.BackColor = System.Drawing.Color.Silver;
            this.deactivateBT.Dock = System.Windows.Forms.DockStyle.Left;
            this.deactivateBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deactivateBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deactivateBT.Image = global::TimelogHeroGUI.Properties.Resources.pause;
            this.deactivateBT.Location = new System.Drawing.Point(342, 2);
            this.deactivateBT.Margin = new System.Windows.Forms.Padding(2);
            this.deactivateBT.Name = "deactivateBT";
            this.deactivateBT.Size = new System.Drawing.Size(26, 30);
            this.deactivateBT.TabIndex = 5;
            this.deactivateBT.UseVisualStyleBackColor = false;
            this.deactivateBT.Click += new System.EventHandler(this.deactivateBT_Click);
            // 
            // activateBT
            // 
            this.activateBT.BackColor = System.Drawing.Color.Silver;
            this.activateBT.Dock = System.Windows.Forms.DockStyle.Left;
            this.activateBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activateBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateBT.Image = global::TimelogHeroGUI.Properties.Resources.play;
            this.activateBT.Location = new System.Drawing.Point(372, 2);
            this.activateBT.Margin = new System.Windows.Forms.Padding(2);
            this.activateBT.Name = "activateBT";
            this.activateBT.Size = new System.Drawing.Size(26, 30);
            this.activateBT.TabIndex = 6;
            this.activateBT.UseVisualStyleBackColor = false;
            this.activateBT.Click += new System.EventHandler(this.activateBT_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // ClockUCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.borderPanel);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "ClockUCtrl";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(562, 42);
            this.borderPanel.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label clockLBL;
        private System.Windows.Forms.Panel borderPanel;
        private System.Windows.Forms.TextBox nameEdit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton optionsDD;
        private System.Windows.Forms.ToolStripMenuItem finishToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button activateBT;
        private System.Windows.Forms.Button deactivateBT;
        private System.Windows.Forms.Label totalLBL;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}
