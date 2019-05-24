namespace TimelogHeroGUI
{
    partial class TimelogHeroForm
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
            this.timelogHeroUctrl1 = new TimelogHeroGUI.TimelogHeroUctrl();
            this.SuspendLayout();
            // 
            // timelogHeroUctrl1
            // 
            this.timelogHeroUctrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timelogHeroUctrl1.Location = new System.Drawing.Point(0, 0);
            this.timelogHeroUctrl1.Name = "timelogHeroUctrl1";
            this.timelogHeroUctrl1.Size = new System.Drawing.Size(814, 399);
            this.timelogHeroUctrl1.TabIndex = 0;
            // 
            // TimelogHeroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 399);
            this.Controls.Add(this.timelogHeroUctrl1);
            this.Name = "TimelogHeroForm";
            this.Text = "Time Log Hero ALPHA 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimelogHeroForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private TimelogHeroUctrl timelogHeroUctrl1;

    }
}

