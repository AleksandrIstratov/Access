using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApplication1
{
    public class FileContent
    {

        public string path { get; private set;}

        public string MakePath(Item _item)
        {
            string _path = ""; 
            _path = Session._path + Session.__pathPrefix + @"\" + _item.ProducerId + " - " + _item.IdItem;
            return path = _path;
        }

        public void CreateFolder(string dir)
        {
            if (!Directory.Exists(path + @"\" + dir))
            {
                Directory.CreateDirectory(path + @"\" + dir);
            }
        }

        public int OpenFile()
        {
            //Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK) return 1;
                return 0;
        }

        public void SaveFromURL()//string remoteImageUrl)
        {
            string remoteImageUrl = "https://i-msdn.sec.s-msft.com/dynimg/IC74937.jpeg";
            string strRealname = System.IO.Path.GetFileName(remoteImageUrl);            

            WebClient webClient = new WebClient();
            webClient.DownloadFile(remoteImageUrl, path + Session.__dirPhoto + "\\" + strRealname);
        }

        public List<string> GetImg()
        {
            List<string> imgFiles = null;
            try
            {                
                imgFiles = Directory.GetFiles(path + Session.__dirPhoto + "\\").ToList<string>();
            }
            catch(System.IO.IOException e)
            {
                MessageBox.Show("Error. GetImg(): "+ e.Message);
                imgFiles = new List<string>();                
            }
            
            if (imgFiles.Count == 0)
            {
                imgFiles.Add(Session._path + Session.__file404);
            }
            return imgFiles;
        }

    }
}
