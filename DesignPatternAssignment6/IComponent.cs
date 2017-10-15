using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment6
{
    interface IComponent
    {
        string Name { get; set; }
        //IEnumerable<IComponent> GetInnerHTML();
        //IComponent GetHTML();
        void GetInnerHTML();
        void GetHTML();
    }
}
