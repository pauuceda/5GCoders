using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connection;

namespace CustomControls
{
    public partial class SWComboFK : ComboBox
    {
        public SWComboFK()
        {
            InitializeComponent();
        }

        private string _controlID;

        public string controlID
        {
            get { return _controlID; }
            set { _controlID = value; }
        }

        private string _Taula;

        public string Taula
        {
            get { return _Taula; }
            set { _Taula = value; }
        }

        public void carregaDades()
        {
            string query = "SELECT * FROM " + Taula;

            DataSet dtSet = new DataSet();
            SQLConnection bd = new SQLConnection();
            
            dtSet = bd.PortarTaula(query);
            this.DataSource = dtSet.Tables[0];
        }

        private void SWComboFK_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Parent.Controls)
            {
                if (ctrl.GetType() == typeof(SWTextBox) && ctrl.Name.Equals(controlID))
                {
                    ctrl.Text = this.SelectedValue.ToString();
                }
            }
        }
    }
}