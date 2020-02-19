using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;

namespace CustomControls
{
    public class SWTextBox : TextBox
    {
        public enum TipusDada
        {
            Numero,
            Text,
            Data,
            Codi,
            Tot
        }
        
        public SWTextBox()
        {
            InitializeComponent();
        }

        private TipusDada _TipusValor;

        public TipusDada TipusValor
        {
            get { return _TipusValor; }
            set { _TipusValor = value; }
        }

        private bool _EsForania;

        public bool EsForania
        {
            get { return _EsForania; }
            set { _EsForania = value; }
        }

        private string _controlID;

        public string controlID
        {
            get { return _controlID; }
            set { _controlID = value; }
        }

        private string _NomCamp;

        public string NomCamp
        {
            get { return _NomCamp; }
            set { _NomCamp = value; }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextBox
            // 
            this.TextChanged += new System.EventHandler(this.SWTextBox_TextChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SWTextBox_KeyPress);
            this.Leave += new System.EventHandler(this.SWTextBox_Leave);
            this.ResumeLayout(false);

        }

        private void SWTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TipusValor == TipusDada.Numero)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }
            else if (TipusValor == TipusDada.Text)
            {
                if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (TipusValor == TipusDada.Data)
            {
                if ((e.KeyChar).Equals("/"))
                {
                    e.Handled = false;
                }
                else if (char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
            }
            else if(TipusValor == TipusDada.Tot)
            {
                e.Handled = false;
            }
        }

        Regex data = new Regex("(([1-2][0-9])|([1-9])|(3[0-1]))/((1[0-2])|([1-9]))/[0-9]{4}", RegexOptions.IgnoreCase);
        Regex codi = new Regex("", RegexOptions.IgnoreCase);

        private void SWTextBox_Leave(object sender, EventArgs e)
        {
            if (!this.Text.Trim().Equals(""))
            {
                if (TipusValor == TipusDada.Data)
                {
                    if (!data.IsMatch(this.Text))
                    {
                        this.Text = null;
                        MessageBox.Show("Data incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SWTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Parent.Controls)
            {
                if (EsForania)
                {
                    if (ctrl.GetType() == typeof(SWComboFK))
                    {
                        if (ctrl.Name == controlID)
                        {
                            try
                            {
                                ((SWComboFK)ctrl).SelectedValue = this.Text;
                            }
                            catch (Exception)
                            {

                            }
                        }
                    }
                }
            }
        }
    }
}
