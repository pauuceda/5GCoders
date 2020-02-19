namespace GestioComandes
{
    partial class MestreDetall
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
            this.PanelDetails = new System.Windows.Forms.Panel();
            this.labelDetalls = new System.Windows.Forms.Label();
            this.SWReference = new CustomControls.SWComboFK();
            this.SWPlanet = new CustomControls.SWComboFK();
            this.SWQuantity = new CustomControls.SWTextBox();
            this.SWOrderDetails = new CustomControls.SWComboFK();
            this.SWDeliveryDate = new CustomControls.SWTextBox();
            this.SWIDReference = new CustomControls.SWTextBox();
            this.SWIDPlanet = new CustomControls.SWTextBox();
            this.SWIDOrderDetail = new CustomControls.SWTextBox();
            this.DGVDetall = new System.Windows.Forms.DataGridView();
            this.PanelOrder = new System.Windows.Forms.Panel();
            this.labelOrdres = new System.Windows.Forms.Label();
            this.InsertOrder = new System.Windows.Forms.Button();
            this.CancelOrder = new System.Windows.Forms.Button();
            this.NewOrder = new System.Windows.Forms.Button();
            this.UpdateOrder = new System.Windows.Forms.Button();
            this.SWFactory = new CustomControls.SWComboFK();
            this.SWPriority = new CustomControls.SWComboFK();
            this.SWIDFactory = new CustomControls.SWTextBox();
            this.SWIDPriority = new CustomControls.SWTextBox();
            this.SWDateOrder = new CustomControls.SWTextBox();
            this.SWCodeOrder = new CustomControls.SWTextBox();
            this.DGVMestre = new System.Windows.Forms.DataGridView();
            this.PanelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetall)).BeginInit();
            this.PanelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMestre)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelDetails
            // 
            this.PanelDetails.Controls.Add(this.labelDetalls);
            this.PanelDetails.Controls.Add(this.SWReference);
            this.PanelDetails.Controls.Add(this.SWPlanet);
            this.PanelDetails.Controls.Add(this.SWQuantity);
            this.PanelDetails.Controls.Add(this.SWOrderDetails);
            this.PanelDetails.Controls.Add(this.SWDeliveryDate);
            this.PanelDetails.Controls.Add(this.SWIDReference);
            this.PanelDetails.Controls.Add(this.SWIDPlanet);
            this.PanelDetails.Controls.Add(this.SWIDOrderDetail);
            this.PanelDetails.Controls.Add(this.DGVDetall);
            this.PanelDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelDetails.Location = new System.Drawing.Point(697, 0);
            this.PanelDetails.Name = "PanelDetails";
            this.PanelDetails.Size = new System.Drawing.Size(653, 700);
            this.PanelDetails.TabIndex = 0;
            // 
            // labelDetalls
            // 
            this.labelDetalls.AutoSize = true;
            this.labelDetalls.BackColor = System.Drawing.Color.Transparent;
            this.labelDetalls.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetalls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.labelDetalls.Location = new System.Drawing.Point(33, 9);
            this.labelDetalls.Name = "labelDetalls";
            this.labelDetalls.Size = new System.Drawing.Size(79, 25);
            this.labelDetalls.TabIndex = 25;
            this.labelDetalls.Text = "Detalls";
            // 
            // SWReference
            // 
            this.SWReference.controlID = "SWIDReference";
            this.SWReference.DisplayMember = "DescFactory";
            this.SWReference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SWReference.FormattingEnabled = true;
            this.SWReference.Location = new System.Drawing.Point(38, 96);
            this.SWReference.Name = "SWReference";
            this.SWReference.Size = new System.Drawing.Size(108, 21);
            this.SWReference.TabIndex = 21;
            this.SWReference.Taula = "Factories";
            this.SWReference.ValueMember = "idFactory";
            // 
            // SWPlanet
            // 
            this.SWPlanet.controlID = "SWIDPlanet";
            this.SWPlanet.DisplayMember = "DescFactory";
            this.SWPlanet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SWPlanet.FormattingEnabled = true;
            this.SWPlanet.Location = new System.Drawing.Point(433, 56);
            this.SWPlanet.Name = "SWPlanet";
            this.SWPlanet.Size = new System.Drawing.Size(108, 21);
            this.SWPlanet.TabIndex = 12;
            this.SWPlanet.Taula = "Factories";
            this.SWPlanet.ValueMember = "idFactory";
            // 
            // SWQuantity
            // 
            this.SWQuantity.controlID = null;
            this.SWQuantity.EsForania = false;
            this.SWQuantity.Location = new System.Drawing.Point(167, 56);
            this.SWQuantity.Multiline = true;
            this.SWQuantity.Name = "SWQuantity";
            this.SWQuantity.NomCamp = "Quantity";
            this.SWQuantity.Size = new System.Drawing.Size(108, 21);
            this.SWQuantity.TabIndex = 20;
            this.SWQuantity.TipusValor = CustomControls.SWTextBox.TipusDada.Numero;
            // 
            // SWOrderDetails
            // 
            this.SWOrderDetails.controlID = "SWIDOrderDetail";
            this.SWOrderDetails.DisplayMember = "DescPriority";
            this.SWOrderDetails.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SWOrderDetails.FormattingEnabled = true;
            this.SWOrderDetails.Location = new System.Drawing.Point(298, 56);
            this.SWOrderDetails.Name = "SWOrderDetails";
            this.SWOrderDetails.Size = new System.Drawing.Size(108, 21);
            this.SWOrderDetails.TabIndex = 11;
            this.SWOrderDetails.Taula = "Priority";
            this.SWOrderDetails.ValueMember = "idPriority";
            // 
            // SWDeliveryDate
            // 
            this.SWDeliveryDate.controlID = null;
            this.SWDeliveryDate.EsForania = false;
            this.SWDeliveryDate.Location = new System.Drawing.Point(38, 56);
            this.SWDeliveryDate.Multiline = true;
            this.SWDeliveryDate.Name = "SWDeliveryDate";
            this.SWDeliveryDate.NomCamp = "DeliveryDate";
            this.SWDeliveryDate.Size = new System.Drawing.Size(108, 21);
            this.SWDeliveryDate.TabIndex = 19;
            this.SWDeliveryDate.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // SWIDReference
            // 
            this.SWIDReference.controlID = null;
            this.SWIDReference.Enabled = false;
            this.SWIDReference.EsForania = true;
            this.SWIDReference.Location = new System.Drawing.Point(622, 159);
            this.SWIDReference.Multiline = true;
            this.SWIDReference.Name = "SWIDReference";
            this.SWIDReference.NomCamp = "IDReference";
            this.SWIDReference.Size = new System.Drawing.Size(0, 0);
            this.SWIDReference.TabIndex = 16;
            this.SWIDReference.TipusValor = CustomControls.SWTextBox.TipusDada.Numero;
            // 
            // SWIDPlanet
            // 
            this.SWIDPlanet.controlID = null;
            this.SWIDPlanet.Enabled = false;
            this.SWIDPlanet.EsForania = true;
            this.SWIDPlanet.Location = new System.Drawing.Point(622, 113);
            this.SWIDPlanet.Multiline = true;
            this.SWIDPlanet.Name = "SWIDPlanet";
            this.SWIDPlanet.NomCamp = "IDPlanet";
            this.SWIDPlanet.Size = new System.Drawing.Size(0, 0);
            this.SWIDPlanet.TabIndex = 15;
            this.SWIDPlanet.TipusValor = CustomControls.SWTextBox.TipusDada.Numero;
            // 
            // SWIDOrderDetail
            // 
            this.SWIDOrderDetail.controlID = null;
            this.SWIDOrderDetail.Enabled = false;
            this.SWIDOrderDetail.EsForania = true;
            this.SWIDOrderDetail.Location = new System.Drawing.Point(622, 69);
            this.SWIDOrderDetail.Multiline = true;
            this.SWIDOrderDetail.Name = "SWIDOrderDetail";
            this.SWIDOrderDetail.NomCamp = "IDOrderDetail";
            this.SWIDOrderDetail.Size = new System.Drawing.Size(0, 0);
            this.SWIDOrderDetail.TabIndex = 12;
            this.SWIDOrderDetail.TipusValor = CustomControls.SWTextBox.TipusDada.Numero;
            // 
            // DGVDetall
            // 
            this.DGVDetall.AllowUserToAddRows = false;
            this.DGVDetall.AllowUserToDeleteRows = false;
            this.DGVDetall.AllowUserToResizeColumns = false;
            this.DGVDetall.AllowUserToResizeRows = false;
            this.DGVDetall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDetall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDetall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVDetall.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVDetall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDetall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVDetall.Location = new System.Drawing.Point(3, 166);
            this.DGVDetall.MultiSelect = false;
            this.DGVDetall.Name = "DGVDetall";
            this.DGVDetall.ReadOnly = true;
            this.DGVDetall.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVDetall.RowHeadersVisible = false;
            this.DGVDetall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDetall.Size = new System.Drawing.Size(648, 529);
            this.DGVDetall.TabIndex = 0;
            // 
            // PanelOrder
            // 
            this.PanelOrder.Controls.Add(this.labelOrdres);
            this.PanelOrder.Controls.Add(this.InsertOrder);
            this.PanelOrder.Controls.Add(this.CancelOrder);
            this.PanelOrder.Controls.Add(this.NewOrder);
            this.PanelOrder.Controls.Add(this.UpdateOrder);
            this.PanelOrder.Controls.Add(this.SWFactory);
            this.PanelOrder.Controls.Add(this.SWPriority);
            this.PanelOrder.Controls.Add(this.SWIDFactory);
            this.PanelOrder.Controls.Add(this.SWIDPriority);
            this.PanelOrder.Controls.Add(this.SWDateOrder);
            this.PanelOrder.Controls.Add(this.SWCodeOrder);
            this.PanelOrder.Controls.Add(this.DGVMestre);
            this.PanelOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelOrder.Location = new System.Drawing.Point(-2, 0);
            this.PanelOrder.Name = "PanelOrder";
            this.PanelOrder.Size = new System.Drawing.Size(699, 700);
            this.PanelOrder.TabIndex = 1;
            // 
            // labelOrdres
            // 
            this.labelOrdres.AutoSize = true;
            this.labelOrdres.BackColor = System.Drawing.Color.Transparent;
            this.labelOrdres.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrdres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(144)))), ((int)(((byte)(156)))));
            this.labelOrdres.Location = new System.Drawing.Point(44, 9);
            this.labelOrdres.Name = "labelOrdres";
            this.labelOrdres.Size = new System.Drawing.Size(80, 25);
            this.labelOrdres.TabIndex = 24;
            this.labelOrdres.Text = "Ordres";
            // 
            // InsertOrder
            // 
            this.InsertOrder.Location = new System.Drawing.Point(601, 77);
            this.InsertOrder.Name = "InsertOrder";
            this.InsertOrder.Size = new System.Drawing.Size(75, 23);
            this.InsertOrder.TabIndex = 14;
            this.InsertOrder.Text = "Insertar";
            this.InsertOrder.UseVisualStyleBackColor = true;
            this.InsertOrder.Visible = false;
            this.InsertOrder.Click += new System.EventHandler(this.InsertOrder_Click);
            // 
            // CancelOrder
            // 
            this.CancelOrder.Location = new System.Drawing.Point(601, 46);
            this.CancelOrder.Name = "CancelOrder";
            this.CancelOrder.Size = new System.Drawing.Size(75, 23);
            this.CancelOrder.TabIndex = 13;
            this.CancelOrder.Text = "Cancel·lar";
            this.CancelOrder.UseVisualStyleBackColor = true;
            this.CancelOrder.Visible = false;
            this.CancelOrder.Click += new System.EventHandler(this.CancelOrder_Click);
            // 
            // NewOrder
            // 
            this.NewOrder.Location = new System.Drawing.Point(601, 46);
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(75, 23);
            this.NewOrder.TabIndex = 12;
            this.NewOrder.Text = "Nou Registre";
            this.NewOrder.UseVisualStyleBackColor = true;
            this.NewOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // UpdateOrder
            // 
            this.UpdateOrder.Location = new System.Drawing.Point(601, 77);
            this.UpdateOrder.Name = "UpdateOrder";
            this.UpdateOrder.Size = new System.Drawing.Size(75, 23);
            this.UpdateOrder.TabIndex = 11;
            this.UpdateOrder.Text = "Actualitzar";
            this.UpdateOrder.UseVisualStyleBackColor = true;
            this.UpdateOrder.Click += new System.EventHandler(this.UpdateOrder_Click);
            // 
            // SWFactory
            // 
            this.SWFactory.controlID = "SWIDFactory";
            this.SWFactory.DisplayMember = "DescFactory";
            this.SWFactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SWFactory.FormattingEnabled = true;
            this.SWFactory.Location = new System.Drawing.Point(437, 56);
            this.SWFactory.Name = "SWFactory";
            this.SWFactory.Size = new System.Drawing.Size(108, 21);
            this.SWFactory.TabIndex = 10;
            this.SWFactory.Taula = "Factories";
            this.SWFactory.ValueMember = "idFactory";
            // 
            // SWPriority
            // 
            this.SWPriority.controlID = "SWIDPriority";
            this.SWPriority.DisplayMember = "DescPriority";
            this.SWPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SWPriority.FormattingEnabled = true;
            this.SWPriority.Location = new System.Drawing.Point(308, 56);
            this.SWPriority.Name = "SWPriority";
            this.SWPriority.Size = new System.Drawing.Size(108, 21);
            this.SWPriority.TabIndex = 9;
            this.SWPriority.Taula = "Priority";
            this.SWPriority.ValueMember = "idPriority";
            // 
            // SWIDFactory
            // 
            this.SWIDFactory.controlID = "SWFactory";
            this.SWIDFactory.Enabled = false;
            this.SWIDFactory.EsForania = true;
            this.SWIDFactory.Location = new System.Drawing.Point(33, 160);
            this.SWIDFactory.Multiline = true;
            this.SWIDFactory.Name = "SWIDFactory";
            this.SWIDFactory.NomCamp = "IDFactory";
            this.SWIDFactory.Size = new System.Drawing.Size(0, 0);
            this.SWIDFactory.TabIndex = 8;
            this.SWIDFactory.TipusValor = CustomControls.SWTextBox.TipusDada.Numero;
            // 
            // SWIDPriority
            // 
            this.SWIDPriority.controlID = "SWPriority";
            this.SWIDPriority.Enabled = false;
            this.SWIDPriority.EsForania = true;
            this.SWIDPriority.Location = new System.Drawing.Point(33, 117);
            this.SWIDPriority.Multiline = true;
            this.SWIDPriority.Name = "SWIDPriority";
            this.SWIDPriority.NomCamp = "IDPriority";
            this.SWIDPriority.Size = new System.Drawing.Size(0, 0);
            this.SWIDPriority.TabIndex = 7;
            this.SWIDPriority.TipusValor = CustomControls.SWTextBox.TipusDada.Numero;
            // 
            // SWDateOrder
            // 
            this.SWDateOrder.controlID = null;
            this.SWDateOrder.EsForania = false;
            this.SWDateOrder.Location = new System.Drawing.Point(177, 56);
            this.SWDateOrder.Multiline = true;
            this.SWDateOrder.Name = "SWDateOrder";
            this.SWDateOrder.NomCamp = "DateOrder";
            this.SWDateOrder.Size = new System.Drawing.Size(108, 21);
            this.SWDateOrder.TabIndex = 3;
            this.SWDateOrder.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // SWCodeOrder
            // 
            this.SWCodeOrder.controlID = null;
            this.SWCodeOrder.EsForania = false;
            this.SWCodeOrder.Location = new System.Drawing.Point(49, 56);
            this.SWCodeOrder.Multiline = true;
            this.SWCodeOrder.Name = "SWCodeOrder";
            this.SWCodeOrder.NomCamp = "CodeOrder";
            this.SWCodeOrder.Size = new System.Drawing.Size(108, 21);
            this.SWCodeOrder.TabIndex = 2;
            this.SWCodeOrder.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // DGVMestre
            // 
            this.DGVMestre.AllowUserToAddRows = false;
            this.DGVMestre.AllowUserToResizeColumns = false;
            this.DGVMestre.AllowUserToResizeRows = false;
            this.DGVMestre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMestre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVMestre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVMestre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMestre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGVMestre.Location = new System.Drawing.Point(6, 166);
            this.DGVMestre.MultiSelect = false;
            this.DGVMestre.Name = "DGVMestre";
            this.DGVMestre.ReadOnly = true;
            this.DGVMestre.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVMestre.RowHeadersVisible = false;
            this.DGVMestre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMestre.Size = new System.Drawing.Size(690, 529);
            this.DGVMestre.TabIndex = 0;
            // 
            // MestreDetall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.PanelOrder);
            this.Controls.Add(this.PanelDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MestreDetall";
            this.Text = "MestreDetall";
            this.Load += new System.EventHandler(this.MestreDetall_Load);
            this.PanelDetails.ResumeLayout(false);
            this.PanelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetall)).EndInit();
            this.PanelOrder.ResumeLayout(false);
            this.PanelOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMestre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelDetails;
        private System.Windows.Forms.Panel PanelOrder;
        private System.Windows.Forms.DataGridView DGVMestre;
        private System.Windows.Forms.DataGridView DGVDetall;
        private CustomControls.SWTextBox SWDateOrder;
        private CustomControls.SWTextBox SWCodeOrder;
        private CustomControls.SWTextBox SWIDFactory;
        private CustomControls.SWTextBox SWIDPriority;
        private CustomControls.SWTextBox SWIDReference;
        private CustomControls.SWTextBox SWIDPlanet;
        private CustomControls.SWTextBox SWIDOrderDetail;
        private CustomControls.SWTextBox SWQuantity;
        private CustomControls.SWTextBox SWDeliveryDate;
        private CustomControls.SWComboFK SWFactory;
        private CustomControls.SWComboFK SWPriority;
        private CustomControls.SWComboFK SWReference;
        private CustomControls.SWComboFK SWPlanet;
        private CustomControls.SWComboFK SWOrderDetails;
        private System.Windows.Forms.Button InsertOrder;
        private System.Windows.Forms.Button CancelOrder;
        private System.Windows.Forms.Button NewOrder;
        private System.Windows.Forms.Button UpdateOrder;
        public System.Windows.Forms.Label labelDetalls;
        public System.Windows.Forms.Label labelOrdres;
    }
}