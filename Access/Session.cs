using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public sealed class Session
    {
        public const string __pathPrefix = @"\data";
        public const string __dirPhoto = @"\photo";
        public const string __file404 = @"\data\404.jpg";

        private static Act _currAct;

        public enum Act { Items,
                          Producers,
                          Storages,
                          Products,
                          Hardwares};



        public static Act currAct
        {
            get
            {
                return _currAct;
            }
            set
            {
                _currAct = value;
            }
        }

        public static string _path { get; set; }
        public static Dictionary<Act, int> GridPosition = new Dictionary<Act, int>();

        private static readonly Session instance = new Session();

        public static Session Instance
        {
            get { return instance; }
        }

        private Session()
        {
            foreach (Act _item in Enum.GetValues(typeof(Act)))
            {
                GridPosition.Add(_item, 0);
            }            
        }

        public static Form ReturnActForm(int _id)
        {
            Form frm = null;
            if (Session.currAct == Session.Act.Producers)
            {
                frm = new FProducers(_id);
            }
            if (Session.currAct == Session.Act.Items)
            {
                frm = new FItems(_id);
            }
            if (Session.currAct == Session.Act.Storages)
            {
                frm = new FStorages(_id);
            }
            if (Session.currAct == Session.Act.Products)
            {
                frm = new FProducts(_id);
            }
            if (Session.currAct == Session.Act.Hardwares)
            {
                frm = new FHardwares(_id);
            }
            return frm;
        }

        private static string GetActClassName()
        {
            string className = Session._currAct.ToString();
            className = className.Remove(className.Length - 1);
            return "WindowsFormsApplication1.C"+className;
        }

        public static IMyTable GetCurrTable()
        {
            var myObj = Activator.CreateInstance(Type.GetType(GetActClassName()));
            IMyTable tbl = (IMyTable)myObj;
            return tbl;
        }
    }
}
