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
            this.PlanetButton = new System.Windows.Forms.Button();
            this.SpaceshipButton = new System.Windows.Forms.Button();
            this.PanelGeneral = new System.Windows.Forms.Panel();
            this.SendButton = new System.Windows.Forms.Button();
            this.ComboPlanets = new System.Windows.Forms.ComboBox();
            this.PanelGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlanetButton
            // 
            this.PlanetButton.Location = new System.Drawing.Point(257, 249);
            this.PlanetButton.Name = "PlanetButton";
            this.PlanetButton.Size = new System.Drawing.Size(170, 159);
            this.PlanetButton.TabIndex = 0;
            this.PlanetButton.Text = "Planet";
            this.PlanetButton.UseVisualStyleBackColor = true;
            this.PlanetButton.Visible = false;
            this.PlanetButton.Click += new System.EventHandler(this.PlanetButton_Click);
            // 
            // SpaceshipButton
            // 
            this.SpaceshipButton.Location = new System.Drawing.Point(823, 249);
            this.SpaceshipButton.Name = "SpaceshipButton";
            this.SpaceshipButton.Size = new System.Drawing.Size(170, 159);
            this.SpaceshipButton.TabIndex = 1;
            this.SpaceshipButton.Text = "Spaceship";
            this.SpaceshipButton.UseVisualStyleBackColor = true;
            this.SpaceshipButton.Visible = false;
            this.SpaceshipButton.Click += new System.EventHandler(this.SpaceshipButton_Click);
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.Controls.Add(this.SendButton);
            this.PanelGeneral.Controls.Add(this.ComboPlanets);
            this.PanelGeneral.Controls.Add(this.PlanetButton);
            this.PanelGeneral.Controls.Add(this.SpaceshipButton);
            this.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGeneral.Location = new System.Drawing.Point(0, 0);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.Size = new System.Drawing.Size(1350, 700);
            this.PanelGeneral.TabIndex = 2;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(655, 136);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(85, 23);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send petition";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ComboPlanets
            // 
            this.ComboPlanets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPlanets.FormattingEnabled = true;
            this.ComboPlanets.Location = new System.Drawing.Point(519, 136);
            this.ComboPlanets.Name = "ComboPlanets";
            this.ComboPlanets.Size = new System.Drawing.Size(121, 21);
            this.ComboPlanets.TabIndex = 3;
            // 
            // PACS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.PanelGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1350, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1350, 700);
            this.Name = "PACS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PACS_Load);
            this.PanelGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlanetButton;
        private System.Windows.Forms.Button SpaceshipButton;
        private System.Windows.Forms.Panel PanelGeneral;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ComboBox ComboPlanets;
    }
}