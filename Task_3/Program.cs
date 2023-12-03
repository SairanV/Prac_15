using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type myClassType = typeof(MyClass);

            object myObject = Activator.CreateInstance(myClassType);

            // Изменение значений свойств
            PropertyInfo propertyInfo = myClassType.GetProperty("PublicProperty");
            propertyInfo.SetValue(myObject, 42);

            // Вызов метода
            MethodInfo methodInfo = myClassType.GetMethod("UpdateInternalState");
            methodInfo.Invoke(myObject, null);

            // Вывод измененных значений
            Console.WriteLine($"Значение свойства после изменения: {propertyInfo.GetValue(myObject)}");
        }
    }
}
