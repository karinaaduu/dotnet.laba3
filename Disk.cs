using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3dn
{
    public class Disk : IPrototype
    {
        public string name { get; set; }
        public List<Folder> folders = new List<Folder>();

        public IPrototype Clone()
        {
            Disk cloneDisk = new Disk { name = this.name + "_clone" };
            if (this.folders.Count() != 0)
            {
                foreach (Folder folder in this.folders)
                {
                    cloneDisk.folders.Add((Folder)folder.Clone());
                }
            }
            return cloneDisk;
        }
        public StringBuilder GetDetails()
        {
            StringBuilder outputString = new StringBuilder();
            outputString.AppendLine($"{name}");
            if (this.folders.Count() != 0)
            {
                foreach (Folder folder in this.folders)
                {
                    outputString.AppendLine(folder.GetDetails().ToString());
                }
            }
            return outputString;
        }
    }
}
