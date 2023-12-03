using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type myClassType = typeof(MyClass);

            MethodInfo privateMethodInfo = myClassType.GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);
            object myObject = Activator.CreateInstance(myClassType);
            privateMethodInfo.Invoke(myObject, null);
        }
    }
}
