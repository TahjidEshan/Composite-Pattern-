using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment6
{
    class CompositeNode : Component, IOperations
    {
        protected ICollection<IComponent> _innerHTML = new List<IComponent>();
        public override void GetInnerHTML()
        {
            foreach (var item in _innerHTML)
            {
                item.GetHTML();
            }
        }
        public void AddComponent(IComponent component)
        {
            this._innerHTML.Add(component);
        }
        public void RemoveComponent(IComponent component)
        {
            this._innerHTML.Remove(component);
        }
        public IComponent GetChild(int index)
        {
            return this._innerHTML.ToList().ElementAt(index);
        }
    }
}
