using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    interface IFile
    {
        void CreateFile(String Name);
        void RenameFile(String OldName, String NewName);
        string GetContent(String Name);
        void DeleteFile(String Name);
        void AddToFile(String Name, String Content);
    }

}
