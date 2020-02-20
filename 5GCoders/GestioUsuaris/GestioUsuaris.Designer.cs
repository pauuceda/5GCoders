namespace GestioUsuaris
{
    partial class GestioUsuaris
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
            this.SWCategoriaTB = new CustomControls.SWTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SWCategoriaCB = new CustomControls.SWComboFK();
            this.SWPhoto = new CustomControls.SWTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SWPassword = new CustomControls.SWTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SWLogin = new CustomControls.SWTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SWNomUsuari = new CustomControls.SWTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SWCodeUser = new CustomControls.SWTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SWUserRank = new CustomControls.SWComboFK();
            this.label7 = new System.Windows.Forms.Label();
            this.SWUserRankTB = new CustomControls.SWTextBox();
            this.SWEspeciesCB = new CustomControls.SWComboFK();
            this.label8 = new System.Windows.Forms.Label();
            this.SWPlanetsCB = new CustomControls.SWComboFK();
            this.label9 = new System.Windows.Forms.Label();
            this.SWPlanetsTB = new CustomControls.SWTextBox();
            this.SWEspeciesTB = new CustomControls.SWTextBox();
            this.PanelEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelEdicion
            // 
            this.PanelEdicion.Controls.Add(this.SWEspeciesTB);
            this.PanelEdicion.Controls.Add(this.SWPlanetsTB);
            this.PanelEdicion.Controls.Add(this.SWEspeciesCB);
            this.PanelEdicion.Controls.Add(this.label8);
            this.PanelEdicion.Controls.Add(this.SWPlanetsCB);
            this.PanelEdicion.Controls.Add(this.label9);
            this.PanelEdicion.Controls.Add(this.SWUserRank);
            this.PanelEdicion.Controls.Add(this.label7);
            this.PanelEdicion.Controls.Add(this.SWUserRankTB);
            this.PanelEdicion.Controls.Add(this.label5);
            this.PanelEdicion.Controls.Add(this.SWPhoto);
            this.PanelEdicion.Controls.Add(this.SWCategoriaCB);
            this.PanelEdicion.Controls.Add(this.label6);
            this.PanelEdicion.Controls.Add(this.SWLogin);
            this.PanelEdicion.Controls.Add(this.label4);
            this.PanelEdicion.Controls.Add(this.label3);
            this.PanelEdicion.Controls.Add(this.label2);
            this.PanelEdicion.Controls.Add(this.label1);
            this.PanelEdicion.Controls.Add(this.SWCategoriaTB);
            this.PanelEdicion.Controls.Add(this.SWPassword);
            this.PanelEdicion.Controls.Add(this.SWNomUsuari);
            this.PanelEdicion.Controls.Add(this.SWCodeUser);
            this.PanelEdicion.Controls.SetChildIndex(this.SWCodeUser, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWNomUsuari, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWPassword, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWCategoriaTB, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.label1, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.label2, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.label3, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.label4, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWLogin, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.label6, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWCategoriaCB, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWPhoto, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.label5, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWSearch, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.labelBuscar, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWUserRankTB, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.label7, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWUserRank, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.label9, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWPlanetsCB, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.label8, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWEspeciesCB, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWPlanetsTB, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWEspeciesTB, 0);
            // 
            // SWCategoriaTB
            // 
            this.SWCategoriaTB.controlID = "SWCategoriaCB";
            this.SWCategoriaTB.Enabled = false;
            this.SWCategoriaTB.EsForania = true;
            this.SWCategoriaTB.Location = new System.Drawing.Point(1060, 56);
            this.SWCategoriaTB.MaxLength = 100;
            this.SWCategoriaTB.Name = "SWCategoriaTB";
            this.SWCategoriaTB.NomCamp = "idUserCategory";
            this.SWCategoriaTB.Size = new System.Drawing.Size(0, 20);
            this.SWCategoriaTB.TabIndex = 7;
            this.SWCategoriaTB.Tag = "";
            this.SWCategoriaTB.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label4.Location = new System.Drawing.Point(846, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Categoria";
            // 
            // SWCategoriaCB
            // 
            this.SWCategoriaCB.controlID = "SWCategoriaTB";
            this.SWCategoriaCB.DisplayMember = "DescCategory";
            this.SWCategoriaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SWCategoriaCB.FormattingEnabled = true;
            this.SWCategoriaCB.Location = new System.Drawing.Point(849, 17);
            this.SWCategoriaCB.Name = "SWCategoriaCB";
            this.SWCategoriaCB.Size = new System.Drawing.Size(100, 21);
            this.SWCategoriaCB.TabIndex = 6;
            this.SWCategoriaCB.Taula = "UserCategories";
            this.SWCategoriaCB.ValueMember = "idUserCategory";
            // 
            // SWPhoto
            // 
            this.SWPhoto.controlID = null;
            this.SWPhoto.EsForania = false;
            this.SWPhoto.Location = new System.Drawing.Point(611, 18);
            this.SWPhoto.MaxLength = 100;
            this.SWPhoto.Name = "SWPhoto";
            this.SWPhoto.NomCamp = "Photo";
            this.SWPhoto.Size = new System.Drawing.Size(100, 20);
            this.SWPhoto.TabIndex = 5;
            this.SWPhoto.Tag = "";
            this.SWPhoto.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label5.Location = new System.Drawing.Point(608, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "Foto";
            // 
            // SWPassword
            // 
            this.SWPassword.controlID = null;
            this.SWPassword.EsForania = false;
            this.SWPassword.Location = new System.Drawing.Point(492, 18);
            this.SWPassword.MaxLength = 100;
            this.SWPassword.Name = "SWPassword";
            this.SWPassword.NomCamp = "Password";
            this.SWPassword.Size = new System.Drawing.Size(100, 20);
            this.SWPassword.TabIndex = 4;
            this.SWPassword.Tag = "";
            this.SWPassword.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.Location = new System.Drawing.Point(489, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Contrasenya";
            // 
            // SWLogin
            // 
            this.SWLogin.controlID = null;
            this.SWLogin.EsForania = false;
            this.SWLogin.Location = new System.Drawing.Point(373, 18);
            this.SWLogin.MaxLength = 100;
            this.SWLogin.Name = "SWLogin";
            this.SWLogin.NomCamp = "Login";
            this.SWLogin.Size = new System.Drawing.Size(100, 20);
            this.SWLogin.TabIndex = 3;
            this.SWLogin.Tag = "";
            this.SWLogin.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label6.Location = new System.Drawing.Point(370, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 48;
            this.label6.Text = "Login";
            // 
            // SWNomUsuari
            // 
            this.SWNomUsuari.controlID = null;
            this.SWNomUsuari.EsForania = false;
            this.SWNomUsuari.Location = new System.Drawing.Point(254, 18);
            this.SWNomUsuari.MaxLength = 100;
            this.SWNomUsuari.Name = "SWNomUsuari";
            this.SWNomUsuari.NomCamp = "UserName";
            this.SWNomUsuari.Size = new System.Drawing.Size(100, 20);
            this.SWNomUsuari.TabIndex = 2;
            this.SWNomUsuari.Tag = "";
            this.SWNomUsuari.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.Location = new System.Drawing.Point(251, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "Nom Usuari";
            // 
            // SWCodeUser
            // 
            this.SWCodeUser.controlID = null;
            this.SWCodeUser.EsForania = false;
            this.SWCodeUser.Location = new System.Drawing.Point(134, 18);
            this.SWCodeUser.MaxLength = 100;
            this.SWCodeUser.Name = "SWCodeUser";
            this.SWCodeUser.NomCamp = "CodeUser";
            this.SWCodeUser.Size = new System.Drawing.Size(100, 20);
            this.SWCodeUser.TabIndex = 1;
            this.SWCodeUser.Tag = "";
            this.SWCodeUser.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Location = new System.Drawing.Point(131, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Codi Usuari";
            // 
            // SWUserRank
            // 
            this.SWUserRank.controlID = "SWUserRankTB";
            this.SWUserRank.DisplayMember = "DescRank";
            this.SWUserRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SWUserRank.FormattingEnabled = true;
            this.SWUserRank.Location = new System.Drawing.Point(728, 17);
            this.SWUserRank.Name = "SWUserRank";
            this.SWUserRank.Size = new System.Drawing.Size(100, 21);
            this.SWUserRank.TabIndex = 51;
            this.SWUserRank.Taula = "UserRanks";
            this.SWUserRank.ValueMember = "idUserRank";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label7.Location = new System.Drawing.Point(725, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 53;
            this.label7.Text = "Rang";
            // 
            // SWUserRankTB
            // 
            this.SWUserRankTB.controlID = "SWUserRank";
            this.SWUserRankTB.Enabled = false;
            this.SWUserRankTB.EsForania = true;
            this.SWUserRankTB.Location = new System.Drawing.Point(1230, 56);
            this.SWUserRankTB.MaxLength = 100;
            this.SWUserRankTB.Name = "SWUserRankTB";
            this.SWUserRankTB.NomCamp = "idUserRank";
            this.SWUserRankTB.Size = new System.Drawing.Size(0, 20);
            this.SWUserRankTB.TabIndex = 52;
            this.SWUserRankTB.Tag = "";
            this.SWUserRankTB.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // SWEspeciesCB
            // 
            this.SWEspeciesCB.controlID = "SWEspeciesTB";
            this.SWEspeciesCB.DisplayMember = "DescSpecie";
            this.SWEspeciesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SWEspeciesCB.FormattingEnabled = true;
            this.SWEspeciesCB.Location = new System.Drawing.Point(1088, 18);
            this.SWEspeciesCB.Name = "SWEspeciesCB";
            this.SWEspeciesCB.Size = new System.Drawing.Size(100, 21);
            this.SWEspeciesCB.TabIndex = 56;
            this.SWEspeciesCB.Taula = "Species";
            this.SWEspeciesCB.ValueMember = "idSpecie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label8.Location = new System.Drawing.Point(1085, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 15);
            this.label8.TabIndex = 57;
            this.label8.Text = "Espècie";
            // 
            // SWPlanetsCB
            // 
            this.SWPlanetsCB.controlID = "SWPlanetsTB";
            this.SWPlanetsCB.DisplayMember = "DescPlanet";
            this.SWPlanetsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SWPlanetsCB.FormattingEnabled = true;
            this.SWPlanetsCB.Location = new System.Drawing.Point(970, 17);
            this.SWPlanetsCB.Name = "SWPlanetsCB";
            this.SWPlanetsCB.Size = new System.Drawing.Size(100, 21);
            this.SWPlanetsCB.TabIndex = 54;
            this.SWPlanetsCB.Taula = "Planets";
            this.SWPlanetsCB.ValueMember = "idPlanet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label9.Location = new System.Drawing.Point(967, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 55;
            this.label9.Text = "Planeta";
            // 
            // SWPlanetsTB
            // 
            this.SWPlanetsTB.controlID = "SWPlanetsCB";
            this.SWPlanetsTB.Enabled = false;
            this.SWPlanetsTB.EsForania = true;
            this.SWPlanetsTB.Location = new System.Drawing.Point(1020, 56);
            this.SWPlanetsTB.MaxLength = 100;
            this.SWPlanetsTB.Name = "SWPlanetsTB";
            this.SWPlanetsTB.NomCamp = "idPlanet";
            this.SWPlanetsTB.Size = new System.Drawing.Size(0, 20);
            this.SWPlanetsTB.TabIndex = 58;
            this.SWPlanetsTB.Tag = "";
            this.SWPlanetsTB.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // SWEspeciesTB
            // 
            this.SWEspeciesTB.controlID = "SWEspeciesCB";
            this.SWEspeciesTB.Enabled = false;
            this.SWEspeciesTB.EsForania = true;
            this.SWEspeciesTB.Location = new System.Drawing.Point(977, 56);
            this.SWEspeciesTB.MaxLength = 100;
            this.SWEspeciesTB.Name = "SWEspeciesTB";
            this.SWEspeciesTB.NomCamp = "idSpecie";
            this.SWEspeciesTB.Size = new System.Drawing.Size(0, 20);
            this.SWEspeciesTB.TabIndex = 59;
            this.SWEspeciesTB.Tag = "";
            this.SWEspeciesTB.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // GestioUsuaris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CampBusqueda = "UserName";
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Name = "GestioUsuaris";
            this.Taula = "Users";
            this.PanelEdicion.ResumeLayout(false);
            this.PanelEdicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        public CustomControls.SWTextBox SWPhoto;
        public CustomControls.SWComboFK SWCategoriaCB;
        private System.Windows.Forms.Label label6;
        public CustomControls.SWTextBox SWLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public CustomControls.SWTextBox SWCategoriaTB;
        public CustomControls.SWTextBox SWPassword;
        public CustomControls.SWTextBox SWNomUsuari;
        public CustomControls.SWTextBox SWCodeUser;
        public CustomControls.SWComboFK SWUserRank;
        private System.Windows.Forms.Label label7;
        public CustomControls.SWTextBox SWUserRankTB;
        public CustomControls.SWComboFK SWEspeciesCB;
        private System.Windows.Forms.Label label8;
        public CustomControls.SWComboFK SWPlanetsCB;
        private System.Windows.Forms.Label label9;
        public CustomControls.SWTextBox SWEspeciesTB;
        public CustomControls.SWTextBox SWPlanetsTB;
    }
}
