namespace PACSGeneral
{
    partial class PACS
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelPlanet = new System.Windows.Forms.Panel();
            this.PanelSpaceship = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelPlanet
            // 
            this.PanelPlanet.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelPlanet.Location = new System.Drawing.Point(0, 0);
            this.PanelPlanet.Name = "PanelPlanet";
            this.PanelPlanet.Size = new System.Drawing.Size(675, 700);
            this.PanelPlanet.TabIndex = 2;
            // 
            // PanelSpaceship
            // 
            this.PanelSpaceship.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelSpaceship.Location = new System.Drawing.Point(675, 0);
            this.PanelSpaceship.Name = "PanelSpaceship";
            this.PanelSpaceship.Size = new System.Drawing.Size(675, 700);
            this.PanelSpaceship.TabIndex = 3;
            // 
            // PACS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.PanelSpaceship);
            this.Controls.Add(this.PanelPlanet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1350, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1350, 700);
            this.Name = "PACS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PACS_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelPlanet;
        private System.Windows.Forms.Panel PanelSpaceship;
    }
}