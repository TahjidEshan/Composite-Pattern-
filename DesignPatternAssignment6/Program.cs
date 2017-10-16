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
            HTML Html = new HTML();
            Html.AddComponent(new DIV());
            LI li = new LI();
            li.AddComponent(new IMG());
            li.AddComponent(new BR());
            li.AddComponent(new HR());
            Html.AddComponent(li);
            Html.GetHTML();
            //Html.GetInnerHTML();
            Console.ReadLine();
        }
    }
}
