using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class MyClass
    {
        private int privateField;

        public int PublicProperty { get; set; }

        public void UpdateInternalState()
        {
            Console.WriteLine("Обновление внутреннего состояния...");
            privateField = 100;
        }
    }
}
