namespace Interficie
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.SWUserRank = new CustomControls.SWComboFK();
            this.label7 = new System.Windows.Forms.Label();
            this.SWUserRankTB = new CustomControls.SWTextBox();
            this.SWCategoriaCB = new CustomControls.SWComboFK();
            this.label6 = new System.Windows.Forms.Label();
            this.SWLogin = new CustomControls.SWTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SWCategoriaTB = new CustomControls.SWTextBox();
            this.SWNomUsuari = new CustomControls.SWTextBox();
            this.SWCodeUser = new CustomControls.SWTextBox();
            this.SWPassword = new CustomControls.SWTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SWRepeatPassword = new CustomControls.SWTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tancarAplicacio = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LabelError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tancarAplicacio)).BeginInit();
            this.SuspendLayout();
            // 
            // SWUserRank
            // 
            this.SWUserRank.controlID = "SWUserRankTB";
            this.SWUserRank.DisplayMember = "DescRank";
            this.SWUserRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SWUserRank.FormattingEnabled = true;
            this.SWUserRank.Location = new System.Drawing.Point(489, 159);
            this.SWUserRank.Name = "SWUserRank";
            this.SWUserRank.Size = new System.Drawing.Size(123, 21);
            this.SWUserRank.TabIndex = 8;
            this.SWUserRank.Taula = "UserRanks";
            this.SWUserRank.ValueMember = "idUserRank";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.label7.Location = new System.Drawing.Point(486, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 81;
            this.label7.Text = "Rang";
            // 
            // SWUserRankTB
            // 
            this.SWUserRankTB.controlID = "SWUserRank";
            this.SWUserRankTB.Enabled = false;
            this.SWUserRankTB.EsForania = true;
            this.SWUserRankTB.Location = new System.Drawing.Point(641, 159);
            this.SWUserRankTB.MaxLength = 100;
            this.SWUserRankTB.Name = "SWUserRankTB";
            this.SWUserRankTB.NomCamp = "idUserRank";
            this.SWUserRankTB.Size = new System.Drawing.Size(0, 20);
            this.SWUserRankTB.TabIndex = 80;
            this.SWUserRankTB.Tag = "";
            this.SWUserRankTB.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // SWCategoriaCB
            // 
            this.SWCategoriaCB.controlID = "SWCategoriaTB";
            this.SWCategoriaCB.DisplayMember = "DescCategory";
            this.SWCategoriaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SWCategoriaCB.FormattingEnabled = true;
            this.SWCategoriaCB.Location = new System.Drawing.Point(489, 104);
            this.SWCategoriaCB.Name = "SWCategoriaCB";
            this.SWCategoriaCB.Size = new System.Drawing.Size(123, 21);
            this.SWCategoriaCB.TabIndex = 7;
            this.SWCategoriaCB.Taula = "UserCategories";
            this.SWCategoriaCB.ValueMember = "idUserCategory";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.label6.Location = new System.Drawing.Point(192, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 78;
            this.label6.Text = "Login";
            // 
            // SWLogin
            // 
            this.SWLogin.controlID = null;
            this.SWLogin.EsForania = false;
            this.SWLogin.Location = new System.Drawing.Point(195, 217);
            this.SWLogin.MaxLength = 100;
            this.SWLogin.Name = "SWLogin";
            this.SWLogin.NomCamp = "Login";
            this.SWLogin.Size = new System.Drawing.Size(100, 20);
            this.SWLogin.TabIndex = 3;
            this.SWLogin.Tag = "";
            this.SWLogin.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.label4.Location = new System.Drawing.Point(486, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 77;
            this.label4.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.label2.Location = new System.Drawing.Point(192, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 75;
            this.label2.Text = "Nom Usuari";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.label1.Location = new System.Drawing.Point(192, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 74;
            this.label1.Text = "Codi Usuari";
            // 
            // SWCategoriaTB
            // 
            this.SWCategoriaTB.controlID = "SWCategoriaCB";
            this.SWCategoriaTB.Enabled = false;
            this.SWCategoriaTB.EsForania = true;
            this.SWCategoriaTB.Location = new System.Drawing.Point(641, 104);
            this.SWCategoriaTB.MaxLength = 100;
            this.SWCategoriaTB.Name = "SWCategoriaTB";
            this.SWCategoriaTB.NomCamp = "idUserCategory";
            this.SWCategoriaTB.Size = new System.Drawing.Size(0, 20);
            this.SWCategoriaTB.TabIndex = 73;
            this.SWCategoriaTB.Tag = "";
            this.SWCategoriaTB.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // SWNomUsuari
            // 
            this.SWNomUsuari.controlID = null;
            this.SWNomUsuari.EsForania = false;
            this.SWNomUsuari.Location = new System.Drawing.Point(195, 160);
            this.SWNomUsuari.MaxLength = 100;
            this.SWNomUsuari.Name = "SWNomUsuari";
            this.SWNomUsuari.NomCamp = "UserName";
            this.SWNomUsuari.Size = new System.Drawing.Size(100, 20);
            this.SWNomUsuari.TabIndex = 2;
            this.SWNomUsuari.Tag = "";
            this.SWNomUsuari.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // SWCodeUser
            // 
            this.SWCodeUser.controlID = null;
            this.SWCodeUser.EsForania = false;
            this.SWCodeUser.Location = new System.Drawing.Point(195, 105);
            this.SWCodeUser.MaxLength = 100;
            this.SWCodeUser.Name = "SWCodeUser";
            this.SWCodeUser.NomCamp = "CodeUser";
            this.SWCodeUser.Size = new System.Drawing.Size(100, 20);
            this.SWCodeUser.TabIndex = 1;
            this.SWCodeUser.Tag = "";
            this.SWCodeUser.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // SWPassword
            // 
            this.SWPassword.controlID = null;
            this.SWPassword.EsForania = false;
            this.SWPassword.Location = new System.Drawing.Point(338, 104);
            this.SWPassword.MaxLength = 100;
            this.SWPassword.Name = "SWPassword";
            this.SWPassword.NomCamp = "Password";
            this.SWPassword.Size = new System.Drawing.Size(100, 20);
            this.SWPassword.TabIndex = 4;
            this.SWPassword.Tag = "";
            this.SWPassword.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            this.SWPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.label3.Location = new System.Drawing.Point(335, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 76;
            this.label3.Text = "Contrasenya";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.label5.Location = new System.Drawing.Point(335, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 15);
            this.label5.TabIndex = 83;
            this.label5.Text = "Repetir ontrasenya";
            // 
            // SWRepeatPassword
            // 
            this.SWRepeatPassword.controlID = null;
            this.SWRepeatPassword.EsForania = false;
            this.SWRepeatPassword.Location = new System.Drawing.Point(338, 161);
            this.SWRepeatPassword.MaxLength = 100;
            this.SWRepeatPassword.Name = "SWRepeatPassword";
            this.SWRepeatPassword.NomCamp = "Password";
            this.SWRepeatPassword.Size = new System.Drawing.Size(100, 20);
            this.SWRepeatPassword.TabIndex = 5;
            this.SWRepeatPassword.Tag = "";
            this.SWRepeatPassword.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            this.SWRepeatPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 275);
            this.panel1.TabIndex = 85;
            // 
            // tancarAplicacio
            // 
            this.tancarAplicacio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tancarAplicacio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tancarAplicacio.Image = ((System.Drawing.Image)(resources.GetObject("tancarAplicacio.Image")));
            this.tancarAplicacio.Location = new System.Drawing.Point(618, 12);
            this.tancarAplicacio.Name = "tancarAplicacio";
            this.tancarAplicacio.Size = new System.Drawing.Size(20, 22);
            this.tancarAplicacio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tancarAplicacio.TabIndex = 86;
            this.tancarAplicacio.TabStop = false;
            this.tancarAplicacio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tancarAplicacio_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.label8.Location = new System.Drawing.Point(192, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 87;
            this.label8.Text = "Registrar-se";
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(424, 196);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(15, 14);
            this.ShowPassword.TabIndex = 6;
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.label9.Location = new System.Drawing.Point(320, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Mostrar contrasenya";
            // 
            // RegisterButton
            // 
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Location = new System.Drawing.Point(537, 214);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "Registrar-se";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.ForeColor = System.Drawing.Color.Red;
            this.LabelError.Location = new System.Drawing.Point(311, 224);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(167, 13);
            this.LabelError.TabIndex = 91;
            this.LabelError.Text = "Les contrasenyes no coincideixen";
            this.LabelError.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 275);
            this.ControlBox = false;
            this.Controls.Add(this.LabelError);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tancarAplicacio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SWRepeatPassword);
            this.Controls.Add(this.SWUserRank);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SWUserRankTB);
            this.Controls.Add(this.SWCategoriaCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SWLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SWCategoriaTB);
            this.Controls.Add(this.SWPassword);
            this.Controls.Add(this.SWNomUsuari);
            this.Controls.Add(this.SWCodeUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(650, 275);
            this.MinimumSize = new System.Drawing.Size(650, 275);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tancarAplicacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CustomControls.SWComboFK SWUserRank;
        private System.Windows.Forms.Label label7;
        public CustomControls.SWTextBox SWUserRankTB;
        public CustomControls.SWComboFK SWCategoriaCB;
        private System.Windows.Forms.Label label6;
        public CustomControls.SWTextBox SWLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public CustomControls.SWTextBox SWCategoriaTB;
        public CustomControls.SWTextBox SWNomUsuari;
        public CustomControls.SWTextBox SWCodeUser;
        public CustomControls.SWTextBox SWPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public CustomControls.SWTextBox SWRepeatPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox tancarAplicacio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label LabelError;
    }
}