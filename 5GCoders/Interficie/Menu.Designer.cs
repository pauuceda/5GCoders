namespace Interficie
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.profile = new System.Windows.Forms.GroupBox();
            this.MoreOptionsB = new System.Windows.Forms.PictureBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.img_profile = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.moreOptions = new System.Windows.Forms.Panel();
            this.tancarSessioB = new System.Windows.Forms.Button();
            this.veurePerfilB = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.btnslide = new System.Windows.Forms.PictureBox();
            this.data = new System.Windows.Forms.Timer(this.components);
            this.PanelAbajo = new System.Windows.Forms.Panel();
            this.PanelHora = new System.Windows.Forms.Panel();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.PanelDGV = new System.Windows.Forms.Panel();
            this.opcions = new System.Windows.Forms.Timer(this.components);
            this.swipeMenu = new System.Windows.Forms.Timer(this.components);
            this.imatge = new System.Windows.Forms.Timer(this.components);
            this.MenuVertical.SuspendLayout();
            this.profile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoreOptionsB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.moreOptions.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).BeginInit();
            this.PanelAbajo.SuspendLayout();
            this.PanelHora.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(46)))), ((int)(((byte)(127)))));
            this.MenuVertical.Controls.Add(this.panelMenu);
            this.MenuVertical.Controls.Add(this.profile);
            this.MenuVertical.Controls.Add(this.logo);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.MinimumSize = new System.Drawing.Size(145, 860);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 860);
            this.MenuVertical.TabIndex = 0;
            this.MenuVertical.Click += new System.EventHandler(this.MenuVertical_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Location = new System.Drawing.Point(3, 65);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(241, 664);
            this.panelMenu.TabIndex = 5;
            this.panelMenu.Click += new System.EventHandler(this.panelMenu_Click);
            // 
            // profile
            // 
            this.profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.profile.Controls.Add(this.MoreOptionsB);
            this.profile.Controls.Add(this.lbl_user);
            this.profile.Controls.Add(this.img_profile);
            this.profile.Controls.Add(this.lbl_name);
            this.profile.Location = new System.Drawing.Point(8, 748);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(232, 100);
            this.profile.TabIndex = 1;
            this.profile.TabStop = false;
            this.profile.Click += new System.EventHandler(this.tancarOpcions);
            // 
            // MoreOptionsB
            // 
            this.MoreOptionsB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoreOptionsB.Image = global::Interficie.Properties.Resources.options;
            this.MoreOptionsB.Location = new System.Drawing.Point(201, 14);
            this.MoreOptionsB.Name = "MoreOptionsB";
            this.MoreOptionsB.Size = new System.Drawing.Size(25, 25);
            this.MoreOptionsB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoreOptionsB.TabIndex = 2;
            this.MoreOptionsB.TabStop = false;
            this.MoreOptionsB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MoreOptionsB_MouseClick);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_user.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.White;
            this.lbl_user.Location = new System.Drawing.Point(110, 44);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(30, 13);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "user";
            this.lbl_user.Click += new System.EventHandler(this.tancarOpcions);
            // 
            // img_profile
            // 
            this.img_profile.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.img_profile.Location = new System.Drawing.Point(20, 14);
            this.img_profile.Name = "img_profile";
            this.img_profile.Size = new System.Drawing.Size(87, 78);
            this.img_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_profile.TabIndex = 0;
            this.img_profile.TabStop = false;
            this.img_profile.Click += new System.EventHandler(this.tancarOpcions);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoEllipsis = true;
            this.lbl_name.AutoSize = true;
            this.lbl_name.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbl_name.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(109, 21);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(37, 18);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "nom";
            this.lbl_name.Click += new System.EventHandler(this.tancarOpcions);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(250, 60);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // moreOptions
            // 
            this.moreOptions.BackColor = System.Drawing.Color.White;
            this.moreOptions.Controls.Add(this.tancarSessioB);
            this.moreOptions.Controls.Add(this.veurePerfilB);
            this.moreOptions.Location = new System.Drawing.Point(3, -2);
            this.moreOptions.MaximumSize = new System.Drawing.Size(200, 100);
            this.moreOptions.Name = "moreOptions";
            this.moreOptions.Size = new System.Drawing.Size(200, 88);
            this.moreOptions.TabIndex = 6;
            // 
            // tancarSessioB
            // 
            this.tancarSessioB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(46)))), ((int)(((byte)(127)))));
            this.tancarSessioB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tancarSessioB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tancarSessioB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tancarSessioB.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tancarSessioB.ForeColor = System.Drawing.Color.White;
            this.tancarSessioB.Location = new System.Drawing.Point(0, 45);
            this.tancarSessioB.Name = "tancarSessioB";
            this.tancarSessioB.Size = new System.Drawing.Size(200, 45);
            this.tancarSessioB.TabIndex = 1;
            this.tancarSessioB.Text = "Tancar sessió";
            this.tancarSessioB.UseVisualStyleBackColor = false;
            this.tancarSessioB.Click += new System.EventHandler(this.tancarSessioB_Click);
            // 
            // veurePerfilB
            // 
            this.veurePerfilB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(46)))), ((int)(((byte)(127)))));
            this.veurePerfilB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.veurePerfilB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.veurePerfilB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.veurePerfilB.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veurePerfilB.ForeColor = System.Drawing.Color.White;
            this.veurePerfilB.Location = new System.Drawing.Point(0, 2);
            this.veurePerfilB.Name = "veurePerfilB";
            this.veurePerfilB.Size = new System.Drawing.Size(200, 45);
            this.veurePerfilB.TabIndex = 0;
            this.veurePerfilB.Text = "Veure perfil";
            this.veurePerfilB.UseVisualStyleBackColor = false;
            this.veurePerfilB.Click += new System.EventHandler(this.veurePerfilB_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.White;
            this.BarraTitulo.Controls.Add(this.iconminimizar);
            this.BarraTitulo.Controls.Add(this.iconcerrar);
            this.BarraTitulo.Controls.Add(this.btnslide);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1350, 60);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.Click += new System.EventHandler(this.BarraTitulo_Click);
            // 
            // iconminimizar
            // 
            this.iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimizar.Image = global::Interficie.Properties.Resources.minimize;
            this.iconminimizar.Location = new System.Drawing.Point(1296, 12);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(17, 17);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimizar.TabIndex = 5;
            this.iconminimizar.TabStop = false;
            this.iconminimizar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.iconminimizar_MouseClick);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = global::Interficie.Properties.Resources.close;
            this.iconcerrar.Location = new System.Drawing.Point(1320, 12);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(17, 17);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 2;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.iconcerrar_MouseClick);
            // 
            // btnslide
            // 
            this.btnslide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnslide.Image = global::Interficie.Properties.Resources.menu;
            this.btnslide.Location = new System.Drawing.Point(6, 12);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(42, 35);
            this.btnslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnslide.TabIndex = 1;
            this.btnslide.TabStop = false;
            this.btnslide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnslide_MouseClick);
            // 
            // data
            // 
            this.data.Enabled = true;
            this.data.Interval = 1000;
            this.data.Tick += new System.EventHandler(this.data_Tick);
            // 
            // PanelAbajo
            // 
            this.PanelAbajo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelAbajo.BackColor = System.Drawing.Color.White;
            this.PanelAbajo.Controls.Add(this.PanelHora);
            this.PanelAbajo.Controls.Add(this.moreOptions);
            this.PanelAbajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelAbajo.Location = new System.Drawing.Point(250, 769);
            this.PanelAbajo.Name = "PanelAbajo";
            this.PanelAbajo.Size = new System.Drawing.Size(1350, 91);
            this.PanelAbajo.TabIndex = 5;
            this.PanelAbajo.Click += new System.EventHandler(this.PanelHora_Click);
            // 
            // PanelHora
            // 
            this.PanelHora.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelHora.Controls.Add(this.lbl_hora);
            this.PanelHora.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelHora.Location = new System.Drawing.Point(1005, 0);
            this.PanelHora.Name = "PanelHora";
            this.PanelHora.Size = new System.Drawing.Size(345, 91);
            this.PanelHora.TabIndex = 7;
            this.PanelHora.Click += new System.EventHandler(this.PanelHora_Click_1);
            // 
            // lbl_hora
            // 
            this.lbl_hora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_hora.AutoEllipsis = true;
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_hora.Location = new System.Drawing.Point(28, 32);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(0, 47);
            this.lbl_hora.TabIndex = 2;
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbl_hora.Click += new System.EventHandler(this.lbl_hora_Click);
            // 
            // PanelDGV
            // 
            this.PanelDGV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelDGV.BackColor = System.Drawing.Color.White;
            this.PanelDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDGV.Location = new System.Drawing.Point(250, 60);
            this.PanelDGV.Name = "PanelDGV";
            this.PanelDGV.Padding = new System.Windows.Forms.Padding(15);
            this.PanelDGV.Size = new System.Drawing.Size(1350, 709);
            this.PanelDGV.TabIndex = 6;
            this.PanelDGV.Click += new System.EventHandler(this.PanelDGV_Click);
            // 
            // opcions
            // 
            this.opcions.Interval = 2;
            this.opcions.Tick += new System.EventHandler(this.opcions_Tick);
            // 
            // swipeMenu
            // 
            this.swipeMenu.Interval = 1;
            this.swipeMenu.Tick += new System.EventHandler(this.swipeMenu_Tick);
            // 
            // imatge
            // 
            this.imatge.Interval = 1;
            this.imatge.Tick += new System.EventHandler(this.imatge_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 860);
            this.Controls.Add(this.PanelDGV);
            this.Controls.Add(this.PanelAbajo);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1598, 858);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MenuVertical.ResumeLayout(false);
            this.profile.ResumeLayout(false);
            this.profile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoreOptionsB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.moreOptions.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).EndInit();
            this.PanelAbajo.ResumeLayout(false);
            this.PanelHora.ResumeLayout(false);
            this.PanelHora.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnslide;
        private System.Windows.Forms.PictureBox iconminimizar;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.GroupBox profile;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.PictureBox img_profile;
        private System.Windows.Forms.Timer data;
        private System.Windows.Forms.Panel PanelAbajo;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Panel PanelDGV;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox MoreOptionsB;
        private System.Windows.Forms.Panel moreOptions;
        private System.Windows.Forms.Timer opcions;
        private System.Windows.Forms.Button veurePerfilB;
        private System.Windows.Forms.Button tancarSessioB;
        private System.Windows.Forms.Timer swipeMenu;
        private System.Windows.Forms.Timer imatge;
        private System.Windows.Forms.Panel PanelHora;
    }
}