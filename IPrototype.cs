using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3dn
{
    public interface IPrototype  
    {
        IPrototype Clone();
        StringBuilder GetDetails();
    }
}
