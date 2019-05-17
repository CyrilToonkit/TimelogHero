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
            this.components = new System.ComponentModel.Container();
            this.clocksFlow = new TimelogHeroGUI.ReorderableFlow(this.components);
            this.SuspendLayout();
            // 
            // clocksFlow
            // 
            this.clocksFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clocksFlow.Location = new System.Drawing.Point(0, 0);
            this.clocksFlow.Name = "clocksFlow";
            this.clocksFlow.Size = new System.Drawing.Size(1629, 767);
            this.clocksFlow.TabIndex = 0;
            // 
            // TimelogHeroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1629, 767);
            this.Controls.Add(this.clocksFlow);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TimelogHeroForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimelogHeroForm_FormClosing);
            this.Load += new System.EventHandler(this.TimelogHeroForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ReorderableFlow clocksFlow;
    }
}

