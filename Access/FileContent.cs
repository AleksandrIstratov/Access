using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class FileContent
    {

        public string Path { get; private set;}

        public string MakePath(Item _item)
        {
            string _path = ""; 
            _path = Session.Path + @"data\" + _item.ProducerId + " - " + _item.IdItem + @"\";
            return Path = _path;
        }

        public void CreateFolder(string dir)
        {
            if (!Directory.Exists(Path+dir))
            {
                Directory.CreateDirectory(Path+dir);
            }
        }

        public int NumberOfFiles()
        {
            return 0;
        }
    }
}
