using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication1
{
    public class CGridField
    {
        public string FieldName { get; set; }
        public string FieldHeaderText { get; set; }
        public bool FieldVisible { get; set; }
    }

    public static class CGrid
    {
        private static List<CGridField> Fields { get; set; }
        public static void SetDGridView(DataGridView _dGW, string _tbl)
        {
            {
                CAccessDB aDB = new CAccessDB();
                string sqlcmd = @"SELECT P.TTableFieldName,
                                     P.TTableFieldHeaderText, 
                                     P.TTableFieldVisible
                              FROM PGrids P, TTables T
                              WHERE P.TTableID = T.IdTTable
                              AND T.TTableName = '" + _tbl + "'";
                DataTable gridDT = aDB.ExecSQLQuery(sqlcmd);
                var query = from tbl in gridDT.AsEnumerable()
                            select new CGridField()
                            {
                                FieldHeaderText = tbl.Field<string>("TTableFieldHeaderText"),
                                FieldName = tbl.Field<string>("TTableFieldName"),
                                FieldVisible = tbl.Field<bool>("TTableFieldVisible")
                            };
                Fields = query.ToList();
            }
            foreach ( CGridField _el in Fields)
            {
                _dGW.Columns[_el.FieldName].Visible = _el.FieldVisible;
                if (_el.FieldVisible == true)
                {
                    _dGW.Columns[_el.FieldName].HeaderText = _el.FieldHeaderText;
                }
            }
        }
    }
}
