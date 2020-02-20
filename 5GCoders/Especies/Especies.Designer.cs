namespace Especies
{
    partial class Especies
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
            this.LabelLongitud = new System.Windows.Forms.Label();
            this.LabelCodiPlaneta = new System.Windows.Forms.Label();
            this.SWLong = new CustomControls.SWTextBox();
            this.SWCodePlanet = new CustomControls.SWTextBox();
            this.PanelEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelEdicion
            // 
            this.PanelEdicion.Controls.Add(this.LabelLongitud);
            this.PanelEdicion.Controls.Add(this.LabelCodiPlaneta);
            this.PanelEdicion.Controls.Add(this.SWLong);
            this.PanelEdicion.Controls.Add(this.SWCodePlanet);
            this.PanelEdicion.Controls.SetChildIndex(this.SWSearch, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.labelBuscar, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWCodePlanet, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWLong, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.LabelCodiPlaneta, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.LabelLongitud, 0);
            // 
            // LabelLongitud
            // 
            this.LabelLongitud.AutoSize = true;
            this.LabelLongitud.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLongitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LabelLongitud.Location = new System.Drawing.Point(246, 3);
            this.LabelLongitud.Name = "LabelLongitud";
            this.LabelLongitud.Size = new System.Drawing.Size(49, 15);
            this.LabelLongitud.TabIndex = 26;
            this.LabelLongitud.Text = "Espècie";
            // 
            // LabelCodiPlaneta
            // 
            this.LabelCodiPlaneta.AutoSize = true;
            this.LabelCodiPlaneta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodiPlaneta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.LabelCodiPlaneta.Location = new System.Drawing.Point(128, 3);
            this.LabelCodiPlaneta.Name = "LabelCodiPlaneta";
            this.LabelCodiPlaneta.Size = new System.Drawing.Size(78, 15);
            this.LabelCodiPlaneta.TabIndex = 25;
            this.LabelCodiPlaneta.Text = "Codi espècie";
            // 
            // SWLong
            // 
            this.SWLong.controlID = null;
            this.SWLong.EsForania = false;
            this.SWLong.Location = new System.Drawing.Point(249, 19);
            this.SWLong.Name = "SWLong";
            this.SWLong.NomCamp = "DescSpecie";
            this.SWLong.Size = new System.Drawing.Size(100, 20);
            this.SWLong.TabIndex = 2;
            this.SWLong.Tag = "";
            this.SWLong.TipusValor = CustomControls.SWTextBox.TipusDada.Text;
            // 
            // SWCodePlanet
            // 
            this.SWCodePlanet.controlID = null;
            this.SWCodePlanet.EsForania = false;
            this.SWCodePlanet.Location = new System.Drawing.Point(131, 19);
            this.SWCodePlanet.Name = "SWCodePlanet";
            this.SWCodePlanet.NomCamp = "CodeSpecie";
            this.SWCodePlanet.Size = new System.Drawing.Size(100, 20);
            this.SWCodePlanet.TabIndex = 1;
            this.SWCodePlanet.Tag = "";
            this.SWCodePlanet.TipusValor = CustomControls.SWTextBox.TipusDada.Text;
            // 
            // Especies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CampBusqueda = "DescSpecie";
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Name = "Especies";
            this.Taula = "Species";
            this.PanelEdicion.ResumeLayout(false);
            this.PanelEdicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label LabelLongitud;
        public System.Windows.Forms.Label LabelCodiPlaneta;
        public CustomControls.SWTextBox SWLong;
        public CustomControls.SWTextBox SWCodePlanet;
    }
}
