namespace MenuOptions
{
    partial class MenuOptions
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SWImatge = new CustomControls.SWTextBox();
            this.SWDLL = new CustomControls.SWTextBox();
            this.SWNomForm = new CustomControls.SWTextBox();
            this.SWRang = new CustomControls.SWTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SWDescripcio = new CustomControls.SWTextBox();
            this.PanelEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelEdicion
            // 
            this.PanelEdicion.Controls.Add(this.label6);
            this.PanelEdicion.Controls.Add(this.SWDescripcio);
            this.PanelEdicion.Controls.Add(this.label5);
            this.PanelEdicion.Controls.Add(this.label4);
            this.PanelEdicion.Controls.Add(this.label3);
            this.PanelEdicion.Controls.Add(this.label1);
            this.PanelEdicion.Controls.Add(this.SWRang);
            this.PanelEdicion.Controls.Add(this.SWNomForm);
            this.PanelEdicion.Controls.Add(this.SWDLL);
            this.PanelEdicion.Controls.Add(this.SWImatge);
            this.PanelEdicion.Controls.SetChildIndex(this.SWImatge, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWDLL, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWNomForm, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWRang, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.label1, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.label3, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.label4, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.label5, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWDescripcio, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.label6, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWSearch, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.labelBuscar, 0);
            // 
            // SWSearch
            // 
            this.SWSearch.TabIndex = 0;
            // 
            // SWImatge
            // 
            this.SWImatge.controlID = null;
            this.SWImatge.EsForania = false;
            this.SWImatge.Location = new System.Drawing.Point(482, 19);
            this.SWImatge.MaxLength = 100;
            this.SWImatge.Name = "SWImatge";
            this.SWImatge.NomCamp = "IMG";
            this.SWImatge.Size = new System.Drawing.Size(100, 20);
            this.SWImatge.TabIndex = 4;
            this.SWImatge.Tag = "";
            this.SWImatge.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // SWDLL
            // 
            this.SWDLL.controlID = null;
            this.SWDLL.EsForania = false;
            this.SWDLL.Location = new System.Drawing.Point(134, 19);
            this.SWDLL.MaxLength = 100;
            this.SWDLL.Name = "SWDLL";
            this.SWDLL.NomCamp = "DLL";
            this.SWDLL.Size = new System.Drawing.Size(100, 20);
            this.SWDLL.TabIndex = 1;
            this.SWDLL.Tag = "";
            this.SWDLL.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // SWNomForm
            // 
            this.SWNomForm.controlID = null;
            this.SWNomForm.EsForania = false;
            this.SWNomForm.Location = new System.Drawing.Point(250, 19);
            this.SWNomForm.MaxLength = 100;
            this.SWNomForm.Name = "SWNomForm";
            this.SWNomForm.NomCamp = "NomFormulari";
            this.SWNomForm.Size = new System.Drawing.Size(100, 20);
            this.SWNomForm.TabIndex = 2;
            this.SWNomForm.Tag = "";
            this.SWNomForm.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // SWRang
            // 
            this.SWRang.controlID = null;
            this.SWRang.EsForania = false;
            this.SWRang.Location = new System.Drawing.Point(597, 18);
            this.SWRang.Name = "SWRang";
            this.SWRang.NomCamp = "Rang";
            this.SWRang.Size = new System.Drawing.Size(100, 20);
            this.SWRang.TabIndex = 5;
            this.SWRang.Tag = "";
            this.SWRang.TipusValor = CustomControls.SWTextBox.TipusDada.Numero;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(14)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(479, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Imatge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(14)))), ((int)(((byte)(81)))));
            this.label3.Location = new System.Drawing.Point(131, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "DLL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(14)))), ((int)(((byte)(81)))));
            this.label4.Location = new System.Drawing.Point(247, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nom Form";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(14)))), ((int)(((byte)(81)))));
            this.label5.Location = new System.Drawing.Point(594, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Nivell d\'accés";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(14)))), ((int)(((byte)(81)))));
            this.label6.Location = new System.Drawing.Point(364, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Descripcio";
            // 
            // SWDescripcio
            // 
            this.SWDescripcio.controlID = null;
            this.SWDescripcio.EsForania = false;
            this.SWDescripcio.Location = new System.Drawing.Point(367, 19);
            this.SWDescripcio.MaxLength = 100;
            this.SWDescripcio.Name = "SWDescripcio";
            this.SWDescripcio.NomCamp = "Descripcio";
            this.SWDescripcio.Size = new System.Drawing.Size(100, 20);
            this.SWDescripcio.TabIndex = 3;
            this.SWDescripcio.Tag = "";
            this.SWDescripcio.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // MenuOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CampBusqueda = "NomFormulari";
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Name = "MenuOptions";
            this.Taula = "Forms";
            this.PanelEdicion.ResumeLayout(false);
            this.PanelEdicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public CustomControls.SWTextBox SWImatge;
        public CustomControls.SWTextBox SWRang;
        public CustomControls.SWTextBox SWNomForm;
        public CustomControls.SWTextBox SWDLL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        public CustomControls.SWTextBox SWDescripcio;
    }
}
