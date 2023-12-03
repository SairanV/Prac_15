using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type myClassType = typeof(MyClass);

            // Создание экземпляра с использованием рефлексии
            object myObject = Activator.CreateInstance(myClassType);

            // Установка значения свойства
            PropertyInfo propertyInfo = myClassType.GetProperty("PublicProperty");
            propertyInfo.SetValue(myObject, 42);

            // Вывод значения свойства
            Console.WriteLine($"Значение свойства: {propertyInfo.GetValue(myObject)}");
        }
    }
}
