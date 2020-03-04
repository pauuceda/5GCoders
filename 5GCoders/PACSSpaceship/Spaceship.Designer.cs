namespace PACSSpaceship
{
    partial class Spaceship
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
            this.ComboPlanets = new System.Windows.Forms.ComboBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboPlanets
            // 
            this.ComboPlanets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPlanets.FormattingEnabled = true;
            this.ComboPlanets.Location = new System.Drawing.Point(219, 307);
            this.ComboPlanets.Name = "ComboPlanets";
            this.ComboPlanets.Size = new System.Drawing.Size(121, 21);
            this.ComboPlanets.TabIndex = 0;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(364, 307);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(85, 23);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send petition";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // Spaceship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 700);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ComboPlanets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(675, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(675, 700);
            this.Name = "Spaceship";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Spaceship_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboPlanets;
        private System.Windows.Forms.Button SendButton;
    }
}