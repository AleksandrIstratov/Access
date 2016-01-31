using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public interface IMyTable
    {
        int Id { get; set; }
        string Name { get; set; }

        void LoadFromDB(int id);
        void SaveToDB();
        void DeleteFromDB(int id);
    }
}
