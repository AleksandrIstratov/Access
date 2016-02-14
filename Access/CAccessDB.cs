using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class CAccessDB
    {
        private OleDbConnection conn;
   
        public CAccessDB()
        {
            try
            {
                conn = new OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+Session._path+@"\mrp.accdb;Persist Security Info=False;";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Failed to create a database connection. \n{0}", ex.Message);
            }
        }

        public DataTable ExecSQLQuery(string sqlcmd)
        {
            DataTable dT = null;
            try
            {
                OleDbCommand cmd = new OleDbCommand(sqlcmd, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(sqlcmd, conn);
                conn.Open();
                dT = new DataTable();
                da.Fill(dT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Failed to retrieve the required data from the DataBase.\n{0}", ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dT;
        }

        public void ExecSQLNonQuery(string sqlcmd)
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand(sqlcmd, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Failed to execuite the Query.\n{0}", ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
