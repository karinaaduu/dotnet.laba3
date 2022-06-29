using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3dn
{
    public class File : IPrototype
    {
        public string name { get; set; }

        public IPrototype Clone()
        {
            File cloneFile = new File { name = this.name + "_clone" };
            return cloneFile;
        }
        public StringBuilder GetDetails()
        {
            StringBuilder outputString = new StringBuilder();
            outputString.AppendLine($"      {name}");
            return outputString;
        }
    }
}
