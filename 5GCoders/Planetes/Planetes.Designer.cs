namespace Planets
{
    partial class Planetes
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
            this.LabelFiliation = new System.Windows.Forms.Label();
            this.LabelParsecs = new System.Windows.Forms.Label();
            this.LabelLongitud = new System.Windows.Forms.Label();
            this.LabelCodiPlaneta = new System.Windows.Forms.Label();
            this.LabelSpecies = new System.Windows.Forms.Label();
            this.LabelSector = new System.Windows.Forms.Label();
            this.LabelLatitud = new System.Windows.Forms.Label();
            this.LabelNomPlaneta = new System.Windows.Forms.Label();
            this.SWSpecies = new CustomControls.SWTextBox();
            this.SWIDFiliation = new CustomControls.SWTextBox();
            this.ForaniaFiliation = new CustomControls.SWComboFK();
            this.ForaniaSpecies = new CustomControls.SWComboFK();
            this.SWIDSector = new CustomControls.SWTextBox();
            this.ForaniaSector = new CustomControls.SWComboFK();
            this.SWParsecs = new CustomControls.SWTextBox();
            this.SWLat = new CustomControls.SWTextBox();
            this.SWLong = new CustomControls.SWTextBox();
            this.SWDescPlanet = new CustomControls.SWTextBox();
            this.SWCodePlanet = new CustomControls.SWTextBox();
            this.PanelEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelEdicion
            // 
            this.PanelEdicion.Controls.Add(this.LabelFiliation);
            this.PanelEdicion.Controls.Add(this.LabelParsecs);
            this.PanelEdicion.Controls.Add(this.LabelLongitud);
            this.PanelEdicion.Controls.Add(this.LabelCodiPlaneta);
            this.PanelEdicion.Controls.Add(this.LabelSpecies);
            this.PanelEdicion.Controls.Add(this.LabelSector);
            this.PanelEdicion.Controls.Add(this.LabelLatitud);
            this.PanelEdicion.Controls.Add(this.LabelNomPlaneta);
            this.PanelEdicion.Controls.Add(this.SWSpecies);
            this.PanelEdicion.Controls.Add(this.SWIDFiliation);
            this.PanelEdicion.Controls.Add(this.ForaniaFiliation);
            this.PanelEdicion.Controls.Add(this.ForaniaSpecies);
            this.PanelEdicion.Controls.Add(this.SWIDSector);
            this.PanelEdicion.Controls.Add(this.ForaniaSector);
            this.PanelEdicion.Controls.Add(this.SWParsecs);
            this.PanelEdicion.Controls.Add(this.SWLat);
            this.PanelEdicion.Controls.Add(this.SWLong);
            this.PanelEdicion.Controls.Add(this.SWDescPlanet);
            this.PanelEdicion.Controls.Add(this.SWCodePlanet);
            this.PanelEdicion.Controls.SetChildIndex(this.SWSearch, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.labelBuscar, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWCodePlanet, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWDescPlanet, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWLong, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWLat, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWParsecs, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.ForaniaSector, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWIDSector, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.ForaniaSpecies, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.ForaniaFiliation, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWIDFiliation, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWSpecies, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.LabelNomPlaneta, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.LabelLatitud, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.LabelSector, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.LabelSpecies, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.LabelCodiPlaneta, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.LabelLongitud, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.LabelParsecs, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.LabelFiliation, 0);
            // 
            // LabelFiliation
            // 
            this.LabelFiliation.AutoSize = true;
            this.LabelFiliation.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFiliation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LabelFiliation.Location = new System.Drawing.Point(368, 41);
            this.LabelFiliation.Name = "LabelFiliation";
            this.LabelFiliation.Size = new System.Drawing.Size(51, 15);
            this.LabelFiliation.TabIndex = 43;
            this.LabelFiliation.Text = "Afiliació";
            // 
            // LabelParsecs
            // 
            this.LabelParsecs.AutoSize = true;
            this.LabelParsecs.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelParsecs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LabelParsecs.Location = new System.Drawing.Point(251, 41);
            this.LabelParsecs.Name = "LabelParsecs";
            this.LabelParsecs.Size = new System.Drawing.Size(49, 15);
            this.LabelParsecs.TabIndex = 42;
            this.LabelParsecs.Text = "Parsecs";
            // 
            // LabelLongitud
            // 
            this.LabelLongitud.AutoSize = true;
            this.LabelLongitud.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLongitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LabelLongitud.Location = new System.Drawing.Point(131, 42);
            this.LabelLongitud.Name = "LabelLongitud";
            this.LabelLongitud.Size = new System.Drawing.Size(53, 15);
            this.LabelLongitud.TabIndex = 41;
            this.LabelLongitud.Text = "Longitud";
            // 
            // LabelCodiPlaneta
            // 
            this.LabelCodiPlaneta.AutoSize = true;
            this.LabelCodiPlaneta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodiPlaneta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LabelCodiPlaneta.Location = new System.Drawing.Point(12, 42);
            this.LabelCodiPlaneta.Name = "LabelCodiPlaneta";
            this.LabelCodiPlaneta.Size = new System.Drawing.Size(76, 15);
            this.LabelCodiPlaneta.TabIndex = 40;
            this.LabelCodiPlaneta.Text = "Codi planeta";
            // 
            // LabelSpecies
            // 
            this.LabelSpecies.AutoSize = true;
            this.LabelSpecies.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSpecies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LabelSpecies.Location = new System.Drawing.Point(499, 3);
            this.LabelSpecies.Name = "LabelSpecies";
            this.LabelSpecies.Size = new System.Drawing.Size(54, 15);
            this.LabelSpecies.TabIndex = 39;
            this.LabelSpecies.Text = "Espècies";
            // 
            // LabelSector
            // 
            this.LabelSector.AutoSize = true;
            this.LabelSector.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LabelSector.Location = new System.Drawing.Point(367, 3);
            this.LabelSector.Name = "LabelSector";
            this.LabelSector.Size = new System.Drawing.Size(41, 15);
            this.LabelSector.TabIndex = 38;
            this.LabelSector.Text = "Sector";
            // 
            // LabelLatitud
            // 
            this.LabelLatitud.AutoSize = true;
            this.LabelLatitud.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLatitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LabelLatitud.Location = new System.Drawing.Point(250, 4);
            this.LabelLatitud.Name = "LabelLatitud";
            this.LabelLatitud.Size = new System.Drawing.Size(42, 15);
            this.LabelLatitud.TabIndex = 37;
            this.LabelLatitud.Text = "Latitud";
            // 
            // LabelNomPlaneta
            // 
            this.LabelNomPlaneta.AutoSize = true;
            this.LabelNomPlaneta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomPlaneta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LabelNomPlaneta.Location = new System.Drawing.Point(131, 3);
            this.LabelNomPlaneta.Name = "LabelNomPlaneta";
            this.LabelNomPlaneta.Size = new System.Drawing.Size(76, 15);
            this.LabelNomPlaneta.TabIndex = 36;
            this.LabelNomPlaneta.Text = "Nom planeta";
            // 
            // SWSpecies
            // 
            this.SWSpecies.controlID = "ForaniaSpecies";
            this.SWSpecies.Enabled = false;
            this.SWSpecies.EsForania = true;
            this.SWSpecies.Location = new System.Drawing.Point(848, 20);
            this.SWSpecies.Name = "SWSpecies";
            this.SWSpecies.NomCamp = "idNatives";
            this.SWSpecies.Size = new System.Drawing.Size(0, 20);
            this.SWSpecies.TabIndex = 6;
            this.SWSpecies.Tag = "";
            this.SWSpecies.TipusValor = CustomControls.SWTextBox.TipusDada.Numero;
            // 
            // SWIDFiliation
            // 
            this.SWIDFiliation.controlID = "ForaniaFiliation";
            this.SWIDFiliation.Enabled = false;
            this.SWIDFiliation.EsForania = true;
            this.SWIDFiliation.Location = new System.Drawing.Point(733, 58);
            this.SWIDFiliation.Name = "SWIDFiliation";
            this.SWIDFiliation.NomCamp = "idFiliation";
            this.SWIDFiliation.Size = new System.Drawing.Size(0, 20);
            this.SWIDFiliation.TabIndex = 11;
            this.SWIDFiliation.Tag = "";
            this.SWIDFiliation.TipusValor = CustomControls.SWTextBox.TipusDada.Numero;
            // 
            // ForaniaFiliation
            // 
            this.ForaniaFiliation.controlID = "SWIDFiliation";
            this.ForaniaFiliation.DisplayMember = "CodeFiliation";
            this.ForaniaFiliation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ForaniaFiliation.FormattingEnabled = true;
            this.ForaniaFiliation.Location = new System.Drawing.Point(371, 56);
            this.ForaniaFiliation.Name = "ForaniaFiliation";
            this.ForaniaFiliation.Size = new System.Drawing.Size(114, 21);
            this.ForaniaFiliation.TabIndex = 10;
            this.ForaniaFiliation.Taula = "Filiations";
            this.ForaniaFiliation.ValueMember = "idFiliation";
            // 
            // ForaniaSpecies
            // 
            this.ForaniaSpecies.controlID = "SWSpecies";
            this.ForaniaSpecies.DisplayMember = "CodeSpecie";
            this.ForaniaSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ForaniaSpecies.FormattingEnabled = true;
            this.ForaniaSpecies.Location = new System.Drawing.Point(502, 19);
            this.ForaniaSpecies.Name = "ForaniaSpecies";
            this.ForaniaSpecies.Size = new System.Drawing.Size(114, 21);
            this.ForaniaSpecies.TabIndex = 5;
            this.ForaniaSpecies.Taula = "Species";
            this.ForaniaSpecies.ValueMember = "idSpecie";
            // 
            // SWIDSector
            // 
            this.SWIDSector.controlID = "ForaniaSector";
            this.SWIDSector.Enabled = false;
            this.SWIDSector.EsForania = true;
            this.SWIDSector.Location = new System.Drawing.Point(732, 21);
            this.SWIDSector.Name = "SWIDSector";
            this.SWIDSector.NomCamp = "idSector";
            this.SWIDSector.Size = new System.Drawing.Size(0, 20);
            this.SWIDSector.TabIndex = 4;
            this.SWIDSector.Tag = "";
            this.SWIDSector.TipusValor = CustomControls.SWTextBox.TipusDada.Numero;
            // 
            // ForaniaSector
            // 
            this.ForaniaSector.controlID = "SWIDSector";
            this.ForaniaSector.DisplayMember = "DescSector";
            this.ForaniaSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ForaniaSector.FormattingEnabled = true;
            this.ForaniaSector.Location = new System.Drawing.Point(370, 19);
            this.ForaniaSector.Name = "ForaniaSector";
            this.ForaniaSector.Size = new System.Drawing.Size(114, 21);
            this.ForaniaSector.TabIndex = 3;
            this.ForaniaSector.Taula = "Sectors";
            this.ForaniaSector.ValueMember = "idSector";
            // 
            // SWParsecs
            // 
            this.SWParsecs.controlID = null;
            this.SWParsecs.EsForania = false;
            this.SWParsecs.Location = new System.Drawing.Point(254, 57);
            this.SWParsecs.Name = "SWParsecs";
            this.SWParsecs.NomCamp = "parsecs";
            this.SWParsecs.Size = new System.Drawing.Size(100, 20);
            this.SWParsecs.TabIndex = 9;
            this.SWParsecs.Tag = "";
            this.SWParsecs.TipusValor = CustomControls.SWTextBox.TipusDada.Numero;
            // 
            // SWLat
            // 
            this.SWLat.controlID = null;
            this.SWLat.EsForania = false;
            this.SWLat.Location = new System.Drawing.Point(253, 20);
            this.SWLat.Name = "SWLat";
            this.SWLat.NomCamp = "lat";
            this.SWLat.Size = new System.Drawing.Size(100, 20);
            this.SWLat.TabIndex = 2;
            this.SWLat.Tag = "";
            this.SWLat.TipusValor = CustomControls.SWTextBox.TipusDada.Numero;
            // 
            // SWLong
            // 
            this.SWLong.controlID = null;
            this.SWLong.EsForania = false;
            this.SWLong.Location = new System.Drawing.Point(134, 58);
            this.SWLong.Name = "SWLong";
            this.SWLong.NomCamp = "long";
            this.SWLong.Size = new System.Drawing.Size(100, 20);
            this.SWLong.TabIndex = 8;
            this.SWLong.Tag = "";
            this.SWLong.TipusValor = CustomControls.SWTextBox.TipusDada.Numero;
            // 
            // SWDescPlanet
            // 
            this.SWDescPlanet.controlID = null;
            this.SWDescPlanet.EsForania = false;
            this.SWDescPlanet.Location = new System.Drawing.Point(134, 20);
            this.SWDescPlanet.Name = "SWDescPlanet";
            this.SWDescPlanet.NomCamp = "DescPlanet";
            this.SWDescPlanet.Size = new System.Drawing.Size(100, 20);
            this.SWDescPlanet.TabIndex = 1;
            this.SWDescPlanet.Tag = "";
            this.SWDescPlanet.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // SWCodePlanet
            // 
            this.SWCodePlanet.controlID = null;
            this.SWCodePlanet.EsForania = false;
            this.SWCodePlanet.Location = new System.Drawing.Point(15, 58);
            this.SWCodePlanet.Name = "SWCodePlanet";
            this.SWCodePlanet.NomCamp = "CodePlanet";
            this.SWCodePlanet.Size = new System.Drawing.Size(100, 20);
            this.SWCodePlanet.TabIndex = 7;
            this.SWCodePlanet.Tag = "";
            this.SWCodePlanet.TipusValor = CustomControls.SWTextBox.TipusDada.Tot;
            // 
            // Planetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CampBusqueda = "DescPlanet";
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Name = "Planetes";
            this.Taula = "Planets";
            this.Text = "";
            this.PanelEdicion.ResumeLayout(false);
            this.PanelEdicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label LabelFiliation;
        public System.Windows.Forms.Label LabelParsecs;
        public System.Windows.Forms.Label LabelLongitud;
        public System.Windows.Forms.Label LabelCodiPlaneta;
        public System.Windows.Forms.Label LabelSpecies;
        public System.Windows.Forms.Label LabelSector;
        public System.Windows.Forms.Label LabelLatitud;
        public System.Windows.Forms.Label LabelNomPlaneta;
        public CustomControls.SWTextBox SWSpecies;
        public CustomControls.SWTextBox SWIDFiliation;
        public CustomControls.SWComboFK ForaniaFiliation;
        public CustomControls.SWComboFK ForaniaSpecies;
        public CustomControls.SWTextBox SWIDSector;
        public CustomControls.SWComboFK ForaniaSector;
        public CustomControls.SWTextBox SWParsecs;
        public CustomControls.SWTextBox SWLat;
        public CustomControls.SWTextBox SWLong;
        public CustomControls.SWTextBox SWDescPlanet;
        public CustomControls.SWTextBox SWCodePlanet;
    }
}
