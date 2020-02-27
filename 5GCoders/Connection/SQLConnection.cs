using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace Connection
{
    public class SQLConnection
    {
        //Variables globals
        private SqlConnection conn;
        private string cnx;

        //Obrir la connexió a la base de dades amb el ConnectionString
        public void Connectar()
        {
            cnx = ConfigurationManager.ConnectionStrings["5GCoders"].ConnectionString;
            conn = new SqlConnection(cnx);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        //Omplir el DataSet amb la taula especificada de la base de dades
        public DataSet PortarTaula(string query)
        {
            DataSet dts = new DataSet();

            try
            {
                Connectar();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dts);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }

            return dts;
        }

        public void SQLCommand(string query)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["5GCoders"].ConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        //Funció que es connecta a la base de dades i si hi ha hagut canvis al dataset els actualitza
        public void Actualitzar(DataSet dts, string query)
        {
            Connectar();

            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);

            if (dts.HasChanges())
            {
                int result = adapter.Update(dts.Tables[0]);
            }

            conn.Close();
        }

        //Funció que retorna una taula amb una query especificada
        public DataTable GetTable(SqlConnection conn, string query)
        {
            DataTable table = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.Fill(table);

            return table;
        }
    }
}
