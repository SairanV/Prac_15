using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_15
{
    public class MyClass
    {
        private int privateField;
        public int PublicProperty { get; set; }
        public string PublicMethod() => "ПабХаус";

        private void PrivateMethod()
        {
            Console.WriteLine("ПиватныйПабХаус.");
        }
    }
}
