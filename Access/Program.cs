using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Session._path = System.IO.Directory.GetCurrentDirectory();
            System.IO.DirectoryInfo dirPath = System.IO.Directory.GetParent(Session._path);
            Session._path = dirPath.Parent.FullName;
            //MessageBox.Show(Session.Path);
            //Session.Path = @"D:\porno\";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
