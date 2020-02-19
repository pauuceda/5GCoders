namespace Interficie
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.textb_user = new System.Windows.Forms.TextBox();
            this.textb_pass = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.tancarAplicacio = new System.Windows.Forms.PictureBox();
            this.errorValidacio = new System.Windows.Forms.Label();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tancarAplicacio)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(38, 22);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(173, 180);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 0;
            this.pic_logo.TabStop = false;
            // 
            // textb_user
            // 
            this.textb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textb_user.Location = new System.Drawing.Point(280, 86);
            this.textb_user.Name = "textb_user";
            this.textb_user.Size = new System.Drawing.Size(130, 20);
            this.textb_user.TabIndex = 1;
            this.textb_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_KeyPress);
            // 
            // textb_pass
            // 
            this.textb_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textb_pass.Location = new System.Drawing.Point(280, 125);
            this.textb_pass.Name = "textb_pass";
            this.textb_pass.Size = new System.Drawing.Size(130, 20);
            this.textb_pass.TabIndex = 2;
            this.textb_pass.UseSystemPasswordChar = true;
            this.textb_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pass_KeyPress);
            // 
            // btn_entrar
            // 
            this.btn_entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_entrar.Location = new System.Drawing.Point(335, 188);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(75, 23);
            this.btn_entrar.TabIndex = 3;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // tancarAplicacio
            // 
            this.tancarAplicacio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tancarAplicacio.Image = ((System.Drawing.Image)(resources.GetObject("tancarAplicacio.Image")));
            this.tancarAplicacio.Location = new System.Drawing.Point(443, 12);
            this.tancarAplicacio.Name = "tancarAplicacio";
            this.tancarAplicacio.Size = new System.Drawing.Size(20, 22);
            this.tancarAplicacio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tancarAplicacio.TabIndex = 4;
            this.tancarAplicacio.TabStop = false;
            this.tancarAplicacio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tancarAplicacio_MouseClick);
            // 
            // errorValidacio
            // 
            this.errorValidacio.AutoSize = true;
            this.errorValidacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorValidacio.ForeColor = System.Drawing.Color.Red;
            this.errorValidacio.Location = new System.Drawing.Point(225, 222);
            this.errorValidacio.Name = "errorValidacio";
            this.errorValidacio.Size = new System.Drawing.Size(185, 15);
            this.errorValidacio.TabIndex = 5;
            this.errorValidacio.Text = "Usuari o contrasenya incorrectes";
            this.errorValidacio.Visible = false;
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(395, 161);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(15, 14);
            this.ShowPassword.TabIndex = 6;
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.label1.Location = new System.Drawing.Point(289, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mostrar contrasenya";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.RegisterLabel.Location = new System.Drawing.Point(35, 222);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(63, 13);
            this.RegisterLabel.TabIndex = 9;
            this.RegisterLabel.Text = "Registrar-se";
            this.RegisterLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RegisterLabel_MouseClick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(475, 270);
            this.ControlBox = false;
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.errorValidacio);
            this.Controls.Add(this.tancarAplicacio);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.textb_pass);
            this.Controls.Add(this.textb_user);
            this.Controls.Add(this.pic_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(475, 270);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(475, 270);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tancarAplicacio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.TextBox textb_pass;
        private System.Windows.Forms.Button btn_entrar;
        public System.Windows.Forms.TextBox textb_user;
        private System.Windows.Forms.PictureBox tancarAplicacio;
        private System.Windows.Forms.Label errorValidacio;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RegisterLabel;
    }
}

