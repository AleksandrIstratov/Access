using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication1
{
    public class Storage:IMyTable
    {
        public int Id;
        public string Name;

        public void LoadFromDB(int id)
        {
            this.Id = id;
            AccessDB aDB = new AccessDB();
            DataTable dT = aDB.getTable(Session.DTables[Session.Act.Storages]);
            DataRow row = dT.Select("IdStorage = " + this.Id).First();
            Name = row.Field<string>("StorageName");            
        }

        public void SaveToDB()
        {
            AccessDB aDB = new AccessDB();
            string sqlcmd = null;
            if (this.Id == 0)
            {
                sqlcmd = "SELECT TOP 1 IdStorage FROM " + Session.DTables[Session.Act.Storages] + " ORDER BY IdStorage DESC";
                Id = aDB.ExecSQLQuery(sqlcmd).Select().First().Field<int>("IdStorage") + 1;
                sqlcmd = "INSERT INTO " + Session.DTables[Session.Act.Storages] +
                " ([IdStorage]) VALUES (" + this.Id + ")";
                aDB.ExecSQLNonQuery(sqlcmd);
            }
            sqlcmd = "UPDATE " + Session.DTables[Session.Act.Storages] +
            " SET [StorageName] = '" + this.Name + "'" +
            " WHERE [IdStorage] = " + this.Id;
            aDB.ExecSQLNonQuery(sqlcmd);
        }

        public void DeleteFromDB(int id)
        {
            AccessDB aDB = new AccessDB();
            string sqlcmd = null;
            sqlcmd = "DELETE FROM " + Session.DTables[Session.Act.Storages] +
                     " WHERE [IdStorage] = " + id;
            aDB.ExecSQLNonQuery(sqlcmd);
        }        
    }
}
