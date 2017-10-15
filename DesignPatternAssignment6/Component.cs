using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment6
{
    abstract class Component:IComponent
    {
        public string Name { get; set; }
        public virtual void GetInnerHTML()
        {
        }
        public void GetHTML()
        {
            Console.WriteLine(this.Name);
            GetInnerHTML();
        }
    }
}
