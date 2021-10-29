using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp2
{
    class TextFile : IFile, IDirectory
    {
        public void CreateDirectory(String Name)
        {
            Directory.CreateDirectory(Name);
        }
        public void RenameDirectory(String OldName, String NewName)
        {
            Directory.Move(OldName, NewName);
        }
        public void DeleteDirectory(String Name)
        {
            Directory.Delete(Name);
        }
        public void CreateFile(String Name)
        {
            if (!File.Exists(Name))
                File.Create(Name);
        }
        public void RenameFile(String OldName, String NewName)
        {
            File.Move(OldName, NewName);
        }
        public void DeleteFile(String Name)
        {
            File.Delete(Name);
        }
        public void AddToFile(String Name, String Content)
        {
            File.AppendAllText(Name, Content);
        }
        public string GetContent(String Name)
        {
            return File.ReadAllText(Name);
        }
    }
}
