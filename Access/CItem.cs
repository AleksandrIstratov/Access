using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace WindowsFormsApplication1
{
    public class CItem : IMyTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OrderPrefix { get; set; }
        public bool MachineBit { get; set; }
        public int? ProducerId { get; set; }

        public DataTable GetDataTable()
        {
            CAccessDB aDB = new CAccessDB();
            string sqlcmd = @"SELECT IdItem, 
                                     ItemName, 
                                     ProducerId,
                                     OrderPrefix,
                                     MachineBit,
                                     ParentId
                              FROM Items";
            DataTable gridDT = aDB.ExecSQLQuery(sqlcmd);
            return gridDT;
        }

        public void LoadFromDB(int id)
        {
            this.Id = id;
            DataTable dT = this.GetDataTable();
            DataRow row = dT.Select("IdItem = " + this.Id).First();
            this.Name = row.Field<string>("ItemName");
            OrderPrefix = row.Field<string>("OrderPrefix");
            MachineBit = row.Field<bool>("MachineBit");
            ProducerId = row.Field<int?>("ProducerId");
        }

        public void SaveToDB()
        {
            CAccessDB aDB = new CAccessDB();
            string sqlcmd = null;
            if (this.Id == 0)
            {
                sqlcmd = "SELECT TOP 1 IdItem FROM Items ORDER BY IdItem DESC";
                this.Id = aDB.ExecSQLQuery(sqlcmd).Select().First().Field<int>("IdItem") + 1;
                sqlcmd = "INSERT INTO Items" +
                " ([IdItem]) VALUES (" + this.Id + ")";
                aDB.ExecSQLNonQuery(sqlcmd);
            }
            sqlcmd = "UPDATE Items" +
            " SET [ItemName] = '" + this.Name + "'," +
            " [OrderPrefix] = '" + this.OrderPrefix + "'," +
            " [MachineBit] = " + this.MachineBit + "," +
            " [ProducerId] = " + ((this.ProducerId != null) ? this.ProducerId.ToString() : "NULL") +
            " WHERE [IdItem] = " + this.Id;
            aDB.ExecSQLNonQuery(sqlcmd);
        }

        public void DeleteFromDB(int id)
        {
            CAccessDB aDB = new CAccessDB();
            string sqlcmd = null;
            sqlcmd = "DELETE FROM Items" +
                     " WHERE [IdItem] = " + id;
            aDB.ExecSQLNonQuery(sqlcmd);
        }
    }
}
