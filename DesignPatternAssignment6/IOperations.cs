using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment6
{
    interface IOperations
    {
        void AddComponent(IComponent component);
        void RemoveComponent(IComponent component);
        IComponent GetChild(int Index);
    }
}
