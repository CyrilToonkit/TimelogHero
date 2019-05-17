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
            this.activateBT = new System.Windows.Forms.Button();
            this.clockLBL = new System.Windows.Forms.Label();
            this.nameLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // activateBT
            // 
            this.activateBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.activateBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateBT.Location = new System.Drawing.Point(0, 0);
            this.activateBT.Name = "activateBT";
            this.activateBT.Size = new System.Drawing.Size(296, 53);
            this.activateBT.TabIndex = 0;
            this.activateBT.Text = ">";
            this.activateBT.UseVisualStyleBackColor = true;
            // 
            // clockLBL
            // 
            this.clockLBL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clockLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLBL.Location = new System.Drawing.Point(0, 93);
            this.clockLBL.Name = "clockLBL";
            this.clockLBL.Size = new System.Drawing.Size(296, 87);
            this.clockLBL.TabIndex = 1;
            this.clockLBL.Text = "0 s";
            this.clockLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLBL
            // 
            this.nameLBL.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLBL.Location = new System.Drawing.Point(0, 53);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(296, 40);
            this.nameLBL.TabIndex = 2;
            this.nameLBL.Text = "Coco";
            this.nameLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClockUCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clockLBL);
            this.Controls.Add(this.nameLBL);
            this.Controls.Add(this.activateBT);
            this.Name = "ClockUCtrl";
            this.Size = new System.Drawing.Size(296, 180);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button activateBT;
        private System.Windows.Forms.Label clockLBL;
        private System.Windows.Forms.Label nameLBL;
    }
}
