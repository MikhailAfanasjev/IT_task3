using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    interface IDirectory
    {
        void CreateDirectory(String Name);
        void RenameDirectory(String OldName, String NewName);
        void DeleteDirectory(String Name);
    }
}
