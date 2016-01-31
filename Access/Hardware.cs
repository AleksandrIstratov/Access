using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication1
{
    public class Hardware : IMyTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ItemId { get; set; }
        public int? ParentHardware { get; set; }


        public void LoadFromDB(int id)
        {
            this.Id = id;
            AccessDB aDB = new AccessDB();
            DataTable dT = aDB.getTable(Session.DTables[Session.Act.Hardwares]);
            DataRow row = dT.Select("IdHardware = " + this.Id).First();
            this.Name = row.Field<string>("HardwareName");
            this.ItemId = row.Field<int?>("ItemId");
            this.ParentHardware = row.Field<int?>("ParentHardware");           
        }

        public void SaveToDB()
        {
            AccessDB aDB = new AccessDB();
            string sqlcmd = null;
            if (this.Id == 0)
            {
                sqlcmd = "SELECT TOP 1 IdHardware FROM " + Session.DTables[Session.Act.Hardwares] + " ORDER BY IdHardware DESC";
                this.Id = aDB.ExecSQLQuery(sqlcmd).Select().First().Field<int>("IdHardware") + 1;
                sqlcmd = "INSERT INTO " + 
                         Session.DTables[Session.Act.Hardwares] +
                         " ([IdHardware]) VALUES (" + this.Id + ")";
                aDB.ExecSQLNonQuery(sqlcmd);
            }
            sqlcmd = "UPDATE " + Session.DTables[Session.Act.Hardwares] +
            " SET [HardwareName] = '" + this.Name + "'," +
            " [ItemId] = " + ((this.ItemId != null) ? this.ItemId.ToString() : "NULL") + "," +
            " [ParentHardware] = " + ((this.ParentHardware != null) ? this.ParentHardware.ToString() : "NULL") +
            " WHERE [IdHardware] = " + this.Id;
            aDB.ExecSQLNonQuery(sqlcmd);
        }

        public void DeleteFromDB(int id)
        {
            AccessDB aDB = new AccessDB();
            string sqlcmd = null;
            sqlcmd = "DELETE FROM " + Session.DTables[Session.Act.Hardwares] +
                     " WHERE [IdHardware] = " + id;
            aDB.ExecSQLNonQuery(sqlcmd);
        }

        public DataTable GetItemsTable()
        {
            DataTable _dt = null;
            AccessDB aDB = new AccessDB();
            string sqlcmd = null;
            sqlcmd = "SELECT IdItem AS ValueMember, (ItemName & ' ' & OrderPrefix) AS DisplayMember FROM " +
                     Session.DTables[Session.Act.Items]; 
            _dt = aDB.ExecSQLQuery(sqlcmd);
            return _dt;
        }

        public DataTable GetHardwareTable()
        {
            DataTable _dt = null;
            AccessDB aDB = new AccessDB();
            string sqlcmd = null;
            sqlcmd = "SELECT H.IdHardware AS ValueMember, (H.HardwareName & ' ' & I.ItemName)  AS DisplayMember FROM " +
                     Session.DTables[Session.Act.Hardwares] + " H " + //(H.HardwareName + ' ' + I.ItemName)
                     " LEFT JOIN " +
                     Session.DTables[Session.Act.Items] + " I" +
                     " ON H.ItemId = I.IdItem"+
                     " WHERE NOT H.IdHardware = " + this.Id;
            _dt = aDB.ExecSQLQuery(sqlcmd);
            return _dt;
        }
    }
}
