using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows;

namespace SQLConnection
{
    public class BbddChampions
    {
        private string cnx;
        private SqlConnection conn;
        SqlDataAdapter adapter;
        SqlCommandBuilder cmdBuilder;
        DataSet dts;

        public BbddChampions()
        {

        }
        //OMPLIR DATASET AMB DADES DE LA CONSULTA QUE LA FUNCIÓ OBTÉ COM A PARÀMETRE
        public DataSet PortarPerConsulta(string consulta)
        {
            Connectar();

            adapter = new SqlDataAdapter(consulta, conn);
            dts = new DataSet();
            adapter.Fill(dts);

            Desconnectar();

            return dts;
        }
        
        public DataSet PortarPerConsulta(string consulta, string NomTaula)
        {
            dts = PortarPerConsulta(consulta);

            dts.Tables[0].TableName = NomTaula;

            return dts;
        }
        //ACTUALITZAR DADES
        public void Actualitzar(string consulta, DataSet dts)
        {
            Connectar();

            adapter = new SqlDataAdapter(consulta, conn);
            cmdBuilder = new SqlCommandBuilder(adapter);

            if (dts.HasChanges())
            {
                try
                {
                    adapter.Update(dts.Tables[0]);
                }
                catch (Exception)
                {

                }
            }

            Desconnectar();
        }
        //OBRIR CONNEXIÓ
        private void Connectar()
        {
            cnx = ConfigurationManager.ConnectionStrings["championsbbdd"].ConnectionString;
            conn = new SqlConnection(cnx);
            conn.Open();
        }
        //TANCAR CONNEXIÓ
        private void Desconnectar()
        {
            conn.Close();
        }
    }
}
