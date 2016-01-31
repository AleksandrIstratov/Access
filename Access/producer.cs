using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class producer:IMyTable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void LoadFromDB(int id)
        {
            this.Id = id;
            AccessDB aDB = new AccessDB();
            DataTable dT = aDB.getTable(Session.DTables[Session.Act.Producers]);
            DataRow row = dT.Select("IdProducer = " + this.Id).First();
            this.Name = row.Field<string>("ProducerName");
        }

        public void SaveToDB()
        {
            AccessDB aDB = new AccessDB();
            string sqlcmd = null;
            if (this.Id == 0)
            {
                sqlcmd = "SELECT TOP 1 IdProducer FROM " + Session.DTables[Session.Act.Producers] + " ORDER BY IdProducer DESC";
                this.Id = aDB.ExecSQLQuery(sqlcmd).Select().First().Field<int>("IdProducer")+1;
                sqlcmd = "INSERT INTO " + Session.DTables[Session.Act.Producers]+
                " ([IdProducer]) VALUES (" + this.Id + ")";
                aDB.ExecSQLNonQuery(sqlcmd);
            }
                sqlcmd = "UPDATE " + Session.DTables[Session.Act.Producers] +
                " SET [ProducerName] = '" + this.Name + "'" +
                " WHERE [IdProducer] = " + this.Id;
                aDB.ExecSQLNonQuery(sqlcmd);
        }

        public void DeleteFromDB(int id)
        {
            AccessDB aDB = new AccessDB();
            string sqlcmd = null;
            sqlcmd = "DELETE FROM " + Session.DTables[Session.Act.Producers] +
                     " WHERE [IdProducer] = " + id;
            aDB.ExecSQLNonQuery(sqlcmd);
        }
    }
}
