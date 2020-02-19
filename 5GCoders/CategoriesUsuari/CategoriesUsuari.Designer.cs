namespace CategoriesUsuari
{
    partial class CategoriesUsuari
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
            this.LabelCodiPlaneta = new System.Windows.Forms.Label();
            this.SWCodePlanet = new CustomControls.SWTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.swTextBox1 = new CustomControls.SWTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.swTextBox2 = new CustomControls.SWTextBox();
            this.PanelEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelEdicion
            // 
            this.PanelEdicion.Controls.Add(this.label2);
            this.PanelEdicion.Controls.Add(this.swTextBox2);
            this.PanelEdicion.Controls.Add(this.label1);
            this.PanelEdicion.Controls.Add(this.swTextBox1);
            this.PanelEdicion.Controls.Add(this.LabelCodiPlaneta);
            this.PanelEdicion.Controls.Add(this.SWCodePlanet);
            this.PanelEdicion.Controls.SetChildIndex(this.SWSearch, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.labelBuscar, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.SWCodePlanet, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.LabelCodiPlaneta, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.swTextBox1, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.label1, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.swTextBox2, 0);
            this.PanelEdicion.Controls.SetChildIndex(this.label2, 0);
            // 
            // LabelCodiPlaneta
            // 
            this.LabelCodiPlaneta.AutoSize = true;
            this.LabelCodiPlaneta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodiPlaneta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(14)))), ((int)(((byte)(81)))));
            this.LabelCodiPlaneta.Location = new System.Drawing.Point(131, 2);
            this.LabelCodiPlaneta.Name = "LabelCodiPlaneta";
            this.LabelCodiPlaneta.Size = new System.Drawing.Size(32, 15);
            this.LabelCodiPlaneta.TabIndex = 27;
            this.LabelCodiPlaneta.Text = "Codi";
            // 
            // SWCodePlanet
            // 
            this.SWCodePlanet.controlID = null;
            this.SWCodePlanet.EsForania = false;
            this.SWCodePlanet.Location = new System.Drawing.Point(134, 18);
            this.SWCodePlanet.Name = "SWCodePlanet";
            this.SWCodePlanet.NomCamp = "CodeCategory";
            this.SWCodePlanet.Size = new System.Drawing.Size(100, 20);
            this.SWCodePlanet.TabIndex = 26;
            this.SWCodePlanet.Tag = "";
            this.SWCodePlanet.TipusValor = CustomControls.SWTextBox.TipusDada.Text;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(14)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(255, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Descripció";
            // 
            // swTextBox1
            // 
            this.swTextBox1.controlID = null;
            this.swTextBox1.EsForania = false;
            this.swTextBox1.Location = new System.Drawing.Point(257, 17);
            this.swTextBox1.Name = "swTextBox1";
            this.swTextBox1.NomCamp = "DescCategory";
            this.swTextBox1.Size = new System.Drawing.Size(100, 20);
            this.swTextBox1.TabIndex = 28;
            this.swTextBox1.Tag = "";
            this.swTextBox1.TipusValor = CustomControls.SWTextBox.TipusDada.Text;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(14)))), ((int)(((byte)(81)))));
            this.label2.Location = new System.Drawing.Point(377, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nivell d\'accés";
            // 
            // swTextBox2
            // 
            this.swTextBox2.controlID = null;
            this.swTextBox2.EsForania = false;
            this.swTextBox2.Location = new System.Drawing.Point(380, 17);
            this.swTextBox2.Name = "swTextBox2";
            this.swTextBox2.NomCamp = "AccessLevel";
            this.swTextBox2.Size = new System.Drawing.Size(100, 20);
            this.swTextBox2.TabIndex = 30;
            this.swTextBox2.Tag = "";
            this.swTextBox2.TipusValor = CustomControls.SWTextBox.TipusDada.Numero;
            // 
            // CategoriesUsuari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CampBusqueda = "DescCategory";
            this.ClientSize = new System.Drawing.Size(1350, 700);
            this.Name = "CategoriesUsuari";
            this.Taula = "UserCategories";
            this.Text = "";
            this.PanelEdicion.ResumeLayout(false);
            this.PanelEdicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public CustomControls.SWTextBox swTextBox2;
        public System.Windows.Forms.Label label1;
        public CustomControls.SWTextBox swTextBox1;
        public System.Windows.Forms.Label LabelCodiPlaneta;
        public CustomControls.SWTextBox SWCodePlanet;
    }
}
