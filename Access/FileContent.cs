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

        public void AddFile()
        {
            //Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (string _file in openFileDialog1.FileNames)
                    {
                        string _filename = Path.GetFileName(_file);
                        File.Copy(openFileDialog1.FileName, path + Session.__dirPhoto + @"\" + _filename);
                        MessageBox.Show("Done. File(s) added");
                    }
                    
                }
                catch (IOException e)
                {
                    MessageBox.Show("Error. AddFile(): " + e.Message);
                }
            }
                
        }

        public void SaveFromURL(string remoteImageUrl)
        {
            //string remoteImageUrl = remoteImageUrl;
            string strRealname = Path.GetFileName(remoteImageUrl);
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile(remoteImageUrl, path + Session.__dirPhoto + @"\" + strRealname);
                MessageBox.Show("Done. File(s) added");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error. SaveFromURL(): " + e.Message);
            }
            
        }

        public List<string> GetImg()
        {
            List<string> imgFiles = null;
            try
            {                
                imgFiles = Directory.GetFiles(path + Session.__dirPhoto + @"\").ToList<string>();
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

        public void DeleteImg(string fileName)
        {
            try
            {
                File.Delete(fileName);
                MessageBox.Show("Done. File deleted");
            }
            catch (IOException e)
            {
                MessageBox.Show("Error. DeleteImg(string fileName): " + e.Message);
            }
        }

    }
}
