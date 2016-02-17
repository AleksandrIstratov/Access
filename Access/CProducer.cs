using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class CProducer:IMyTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public void LoadFromDB(int id)
        {
            this.Id = id;
            DataTable dT = this.GetDataTable();
            DataRow row = dT.Select("IdProducer = " + this.Id).First();
            this.Name = row.Field<string>("ProducerName");
            this.ShortName = row.Field<string>("ProducerShortName");
        }

        public void SaveToDB()
        {
            CAccessDB aDB = new CAccessDB();
            string sqlcmd = null;
            if (this.Id == 0)
            {
                sqlcmd = "SELECT TOP 1 IdProducer FROM Producers ORDER BY IdProducer DESC";
                this.Id = aDB.ExecSQLQuery(sqlcmd).Select().First().Field<int>("IdProducer")+1;
                sqlcmd = "INSERT INTO Producers" +
                " ([IdProducer]) VALUES (" + this.Id + ")";
                aDB.ExecSQLNonQuery(sqlcmd);
            }
                sqlcmd = "UPDATE Producers" +
                " SET [ProducerName] = '" + this.Name + "'," +
                " [ProducerShortName] = '" + this.ShortName + "'" +
                " WHERE [IdProducer] = " + this.Id;
                aDB.ExecSQLNonQuery(sqlcmd);
        }

        public void DeleteFromDB(int id)
        {
            CAccessDB aDB = new CAccessDB();
            string sqlcmd = null;
            sqlcmd = "DELETE FROM Producers" +
                     " WHERE [IdProducer] = " + id;
            aDB.ExecSQLNonQuery(sqlcmd);
        }

        public DataTable GetDataTable()
        {
            CAccessDB aDB = new CAccessDB();
            string sqlcmd = "SELECT * FROM Producers";
            DataTable gridDT = aDB.ExecSQLQuery(sqlcmd);
            return gridDT;
        }
    }
}
