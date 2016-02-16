using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication1
{
    public class CHardware : IMyTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ItemId { get; set; }
        public int? ParentHardware { get; set; }

        public void LoadFromDB(int id)
        {
            this.Id = id;
            DataTable dT = this.GetDataTable();
            DataRow row = dT.Select("IdHardware = " + this.Id).First();
            this.Name = row.Field<string>("H.HardwareName");
            this.ItemId = row.Field<int?>("ItemId");
            this.ParentHardware = row.Field<int?>("ParentHardware");           
        }

        public void SaveToDB()
        {
            CAccessDB aDB = new CAccessDB();
            string sqlcmd = null;
            if (this.Id == 0)
            {
                sqlcmd = "SELECT TOP 1 IdHardware FROM Hardwares ORDER BY IdHardware DESC";
                this.Id = aDB.ExecSQLQuery(sqlcmd).Select().First().Field<int>("IdHardware") + 1;
                sqlcmd = "INSERT INTO Hardwares" +
                         " ([IdHardware]) VALUES (" + this.Id + ")";
                aDB.ExecSQLNonQuery(sqlcmd);
            }
            sqlcmd = "UPDATE Hardwares" +
            " SET [HardwareName] = '" + this.Name + "'," +
            " [ItemId] = " + ((this.ItemId != null) ? this.ItemId.ToString() : "NULL") + "," +
            " [ParentHardware] = " + ((this.ParentHardware != null) ? this.ParentHardware.ToString() : "NULL") +
            " WHERE [IdHardware] = " + this.Id;
            aDB.ExecSQLNonQuery(sqlcmd);
        }

        public void DeleteFromDB(int id)
        {
            CAccessDB aDB = new CAccessDB();
            string sqlcmd = null;
            sqlcmd = "DELETE FROM Hardwares" +
                     " WHERE [IdHardware] = " + id;
            aDB.ExecSQLNonQuery(sqlcmd);
        }

        public DataTable GetItemsTable()
        {
            DataTable _dt = null;
            CAccessDB aDB = new CAccessDB();
            string sqlcmd = null;
            sqlcmd = "SELECT IdItem AS ValueMember, (ItemName & ' ' & OrderPrefix) AS DisplayMember FROM Items"; 
            _dt = aDB.ExecSQLQuery(sqlcmd);
            return _dt;
        }

        public DataTable GetHardwareTable()
        {
            DataTable _dt = null;
            CAccessDB aDB = new CAccessDB();
            string sqlcmd = null;
            sqlcmd = "SELECT H.IdHardware AS ValueMember, (H.HardwareName & ' ' & I.ItemName)  AS DisplayMember" +
                     " FROM Hardwares H " +
                     " LEFT JOIN Items I" +
                     " ON H.ItemId = I.IdItem" +
                     " WHERE NOT H.IdHardware = " + this.Id;
            _dt = aDB.ExecSQLQuery(sqlcmd);
            return _dt;
        }

        public DataTable GetDataTable()
        {
            CAccessDB aDB = new CAccessDB();
            string sqlcmd = @"SELECT H.IdHardware,
                                     H.HardwareName,
                                     H.ItemId,
                                     H.ParentHardware,
                                     Ph.HardwareName,
                                     I.ItemName,
                                     P.ProducerName
                              FROM (((Hardwares H)
                              LEFT JOIN Items I ON H.ItemId = I.IdItem)
                              LEFT JOIN Hardwares Ph ON H.ParentHardware = Ph.IdHardware)
                              LEFT JOIN Producers P ON I.ProducerId = P.IdProducer";

            DataTable gridDT = aDB.ExecSQLQuery(sqlcmd);
            return gridDT;
        }
    }
}
