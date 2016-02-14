using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication1
{
    public class CStorage:IMyTable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void LoadFromDB(int id)
        {
            this.Id = id;
            DataTable dT = this.GetDataTable();
            DataRow row = dT.Select("IdStorage = " + this.Id).First();
            Name = row.Field<string>("StorageName");            
        }

        public void SaveToDB()
        {
            CAccessDB aDB = new CAccessDB();
            string sqlcmd = null;
            if (this.Id == 0)
            {
                sqlcmd = "SELECT TOP 1 IdStorage FROM Storages ORDER BY IdStorage DESC";
                Id = aDB.ExecSQLQuery(sqlcmd).Select().First().Field<int>("IdStorage") + 1;
                sqlcmd = "INSERT INTO Storages" +
                " ([IdStorage]) VALUES (" + this.Id + ")";
                aDB.ExecSQLNonQuery(sqlcmd);
            }
            sqlcmd = "UPDATE Storages" +
            " SET [StorageName] = '" + this.Name + "'" +
            " WHERE [IdStorage] = " + this.Id;
            aDB.ExecSQLNonQuery(sqlcmd);
        }

        public void DeleteFromDB(int id)
        {
            CAccessDB aDB = new CAccessDB();
            string sqlcmd = null;
            sqlcmd = "DELETE FROM Storages" +
                     " WHERE [IdStorage] = " + id;
            aDB.ExecSQLNonQuery(sqlcmd);
        }

        public DataTable GetDataTable()
        {
            CAccessDB aDB = new CAccessDB();
            string sqlcmd = "SELECT * FROM Storages";
            DataTable gridDT = aDB.ExecSQLQuery(sqlcmd);
            return gridDT;
        }
    }
}
