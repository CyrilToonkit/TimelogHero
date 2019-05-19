namespace TimelogHeroGUI
{
    partial class AddClockUCtrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addLBL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addLBL
            // 
            this.addLBL.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addLBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLBL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addLBL.Location = new System.Drawing.Point(0, 0);
            this.addLBL.Name = "addLBL";
            this.addLBL.Size = new System.Drawing.Size(150, 34);
            this.addLBL.TabIndex = 0;
            this.addLBL.Text = "+";
            this.addLBL.UseVisualStyleBackColor = false;
            // 
            // AddClockUCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addLBL);
            this.Name = "AddClockUCtrl";
            this.Size = new System.Drawing.Size(150, 34);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button addLBL;


    }
}
