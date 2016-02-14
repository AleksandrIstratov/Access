using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication1
{
    public class CProduct : IMyTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ItemId { get; set; }
        public string SerialNumber { get; set; }
        public string InventoryNumber { get; set; }
        public DateTime? ProductionDate { get; set; }
        public DateTime? PurchaseDate { get; set; }

        public void LoadFromDB(int id)
        {
            this.Id = id;
            DataTable dT = this.GetDataTable();
            DataRow row = dT.Select("IdProduct = " + this.Id).First();
            this.Name = row.Field<string>("ProductName");
            this.ItemId = row.Field<int?>("ItemId");
            this.SerialNumber = row.Field<string>("SerialNumber");
            this.InventoryNumber = row.Field<string>("InventoryNumber");
            this.ProductionDate = row.Field<DateTime?>("ProductionDate");
            this.PurchaseDate = row.Field<DateTime?>("PurchaseDate");
        }

        public void SaveToDB()
        {
            CAccessDB aDB = new CAccessDB();
            string sqlcmd = null;
            if (this.Id == 0)
            {
                sqlcmd = "SELECT TOP 1 IdProduct FROM Products ORDER BY IdProduct DESC";
                this.Id = aDB.ExecSQLQuery(sqlcmd).Select().First().Field<int>("IdProduct") + 1;
                sqlcmd = "INSERT INTO Products" +
                " ([IdProduct]) VALUES (" + this.Id + ")";
                aDB.ExecSQLNonQuery(sqlcmd);
            }
            sqlcmd = "UPDATE Products" +
            " SET [ProductName] = '" + this.Name + "'," +
            " [ItemId] = " + ((this.ItemId != null) ? this.ItemId.ToString() : "NULL") + "," +
            " [SerialNumber] = '" + this.SerialNumber + "'," +
            " [InventoryNumber] = '" + this.InventoryNumber + "'," +
            " [ProductionDate] = " + ((this.ProductionDate != null) ? "'"+this.ProductionDate.Value.ToString()+"'" : "NULL") + "," +
            " [PurchaseDate] = " + ((this.PurchaseDate != null) ? "'"+this.PurchaseDate.Value.ToString()+ "'" : "NULL") +
            " WHERE [IdProduct] = " + this.Id;
            aDB.ExecSQLNonQuery(sqlcmd);
        }

        public void DeleteFromDB(int id)
        {
            CAccessDB aDB = new CAccessDB();
            string sqlcmd = null;
            sqlcmd = "DELETE FROM Products" +
                     " WHERE [IdProduct] = " + id;
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

        public DataTable GetDataTable()
        {
            CAccessDB aDB = new CAccessDB();
            string sqlcmd = "SELECT * FROM Products";
            DataTable gridDT = aDB.ExecSQLQuery(sqlcmd);
            return gridDT;
        }
    }
}
