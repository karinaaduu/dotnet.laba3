using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3dn
{
    public class Folder : IPrototype
    {
        public string name { get; set; }
        public List<File> files = new List<File>();

        public IPrototype Clone()
        {
            Folder cloneFolder = new Folder { name = this.name + "_clone" };
            if (this.files.Count != 0)
            {
                foreach (File file in this.files)
                {
                    cloneFolder.files.Add((File)file.Clone());
                }
            }
            return cloneFolder;
        }

        public StringBuilder GetDetails()
        {
            StringBuilder outputString = new StringBuilder();
            outputString.AppendLine($"   {name}");
            if (this.files.Count() != 0)
            {
                foreach (File file in this.files)
                {
                   outputString.AppendLine(file.GetDetails().ToString());
                }
            }
            return outputString;
        }
    }
}
