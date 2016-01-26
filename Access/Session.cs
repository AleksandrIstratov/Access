using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public sealed class Session
    {
        public const string __dirPhoto = @"photo";
        public static Dictionary<Act, string> DTables = new Dictionary<Act, string>();
        //public Dictionary<Act, IMyTable> DClass = new Dictionary<Act, IMyTable>();
        //public Dictionary<Act, Type> DForm = new Dictionary<Act, Type>();
        public enum Act { Items, Producers};
        public static Act currAct { get; set; }
        public static string Path { get; set; }
        public static int GridPosition = 1;

        private static readonly Session instance = new Session();

        private Session()
        {
            DTables.Add(Act.Items, "Items");
            DTables.Add(Act.Producers, "Producers");
            //DClass.Add(Act.Items, null);
            //DClass.Add(Act.Producers, null);
            //DForm.Add(Act.Items, typeof(Items));
            //DForm.Add(Act.Producers, null);
        }

        public static Session Instance
        {
            get { return instance; }
        }

        public static string ActToString()
        {
            return DTables[currAct];
        }

    }
}
