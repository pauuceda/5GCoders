using System;

namespace CustomControls
{
    partial class OpcionsMenu
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.taulaForms = new System.Windows.Forms.Label();
            this.Imatge = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Imatge)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taulaForms
            // 
            this.taulaForms.AutoSize = true;
            this.taulaForms.BackColor = System.Drawing.Color.Transparent;
            this.taulaForms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taulaForms.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taulaForms.ForeColor = System.Drawing.Color.Transparent;
            this.taulaForms.Location = new System.Drawing.Point(62, 25);
            this.taulaForms.Name = "taulaForms";
            this.taulaForms.Size = new System.Drawing.Size(64, 15);
            this.taulaForms.TabIndex = 4;
            this.taulaForms.Text = "Nom Taula";
            this.taulaForms.MouseClick += new System.Windows.Forms.MouseEventHandler(this.taulaForms_MouseClick);
            // 
            // Imatge
            // 
            this.Imatge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Imatge.Location = new System.Drawing.Point(8, 13);
            this.Imatge.Name = "Imatge";
            this.Imatge.Size = new System.Drawing.Size(48, 42);
            this.Imatge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Imatge.TabIndex = 3;
            this.Imatge.TabStop = false;
            this.Imatge.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Imatge_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Imatge);
            this.groupBox1.Controls.Add(this.taulaForms);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.MaximumSize = new System.Drawing.Size(236, 62);
            this.groupBox1.MinimumSize = new System.Drawing.Size(130, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 62);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.groupBox1_MouseClick);
            // 
            // OpcionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(46)))), ((int)(((byte)(127)))));
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(245, 68);
            this.MinimumSize = new System.Drawing.Size(138, 68);
            this.Name = "OpcionsMenu";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(245, 68);
            this.Load += new System.EventHandler(this.OpcionsMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Imatge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label taulaForms;
        public System.Windows.Forms.PictureBox Imatge;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}
