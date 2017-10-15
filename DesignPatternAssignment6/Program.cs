using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternAssignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositeNode Html = new CompositeNode
            {
                Name = "HTML"
            };
            Html.AddComponent(new LeafNode{ Name="a" });
            CompositeNode Div = new CompositeNode
            {
                Name = "Div"
            };
            Div.AddComponent(new LeafNode { Name="b" });
            Html.AddComponent(Div);
            Html.GetHTML();
            //Html.GetInnerHTML();
            Console.ReadLine();
        }
    }
}
