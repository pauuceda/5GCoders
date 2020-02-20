namespace Prova
{
    partial class FormBase
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
            this.PanelEdicion = new System.Windows.Forms.Panel();
            this.InsertButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.SWSearch = new CustomControls.SWTextBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.PanelDGV = new System.Windows.Forms.Panel();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.PanelEdicion.SuspendLayout();
            this.PanelDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelEdicion
            // 
            this.PanelEdicion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelEdicion.Controls.Add(this.InsertButton);
            this.PanelEdicion.Controls.Add(this.CancelButton);
            this.PanelEdicion.Controls.Add(this.labelBuscar);
            this.PanelEdicion.Controls.Add(this.SWSearch);
            this.PanelEdicion.Controls.Add(this.NewButton);
            this.PanelEdicion.Controls.Add(this.UpdateButton);
            this.PanelEdicion.Location = new System.Drawing.Point(0, 0);
            this.PanelEdicion.Name = "PanelEdicion";
            this.PanelEdicion.Size = new System.Drawing.Size(1350, 82);
            this.PanelEdicion.TabIndex = 9;
            // 
            // InsertButton
            // 
            this.InsertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertButton.Location = new System.Drawing.Point(1260, 44);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(75, 23);
            this.InsertButton.TabIndex = 25;
            this.InsertButton.Text = "Afegir";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Visible = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(1260, 15);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 24;
            this.CancelButton.Text = "Cancel·lar";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Visible = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.labelBuscar.Location = new System.Drawing.Point(12, 3);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(44, 15);
            this.labelBuscar.TabIndex = 23;
            this.labelBuscar.Text = "Buscar";
            // 
            // SWSearch
            // 
            this.SWSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.SWSearch.controlID = null;
            this.SWSearch.EsForania = false;
            this.SWSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SWSearch.ForeColor = System.Drawing.Color.White;
            this.SWSearch.Location = new System.Drawing.Point(15, 19);
            this.SWSearch.Name = "SWSearch";
            this.SWSearch.NomCamp = "";
            this.SWSearch.Size = new System.Drawing.Size(100, 20);
            this.SWSearch.TabIndex = 0;
            this.SWSearch.Tag = "";
            this.SWSearch.TipusValor = CustomControls.SWTextBox.TipusDada.Text;
            this.SWSearch.TextChanged += new System.EventHandler(this.SWSearch_TextChanged);
            // 
            // NewButton
            // 
            this.NewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewButton.Location = new System.Drawing.Point(1260, 15);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 23);
            this.NewButton.TabIndex = 20;
            this.NewButton.Text = "Nou registre";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.Location = new System.Drawing.Point(1260, 44);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 21;
            this.UpdateButton.Text = "Actualitzar";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // PanelDGV
            // 
            this.PanelDGV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelDGV.Controls.Add(this.DGV);
            this.PanelDGV.Location = new System.Drawing.Point(0, 82);
            this.PanelDGV.Name = "PanelDGV";
            this.PanelDGV.Padding = new System.Windows.Forms.Padding(15);
            this.PanelDGV.Size = new System.Drawing.Size(1350, 618);
            this.PanelDGV.TabIndex = 11;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGV.GridColor = System.Drawing.Color.White;
            this.DGV.Location = new System.Drawing.Point(15, 15);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.DGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(1320, 588);
            this.DGV.TabIndex = 20;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Controls.Add(this.PanelDGV);
            this.Controls.Add(this.PanelEdicion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1350, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1350, 700);
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBase";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.PanelEdicion.ResumeLayout(false);
            this.PanelEdicion.PerformLayout();
            this.PanelDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button UpdateButton;
        public System.Windows.Forms.Panel PanelEdicion;
        public System.Windows.Forms.Panel PanelDGV;
        public System.Windows.Forms.Label labelBuscar;
        public CustomControls.SWTextBox SWSearch;
        public System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button CancelButton;
    }
}