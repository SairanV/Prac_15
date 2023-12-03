using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Prac_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type myClassType = typeof(MyClass);

            Console.WriteLine($"Имя класса: {myClassType.Name}");

            // Список конструкторов
            ConstructorInfo[] constructors = myClassType.GetConstructors();
            Console.WriteLine("Конструкторы:");
            foreach (var constructor in constructors)
            {
                Console.WriteLine($"{constructor.Name}, Модификатор доступа: {constructor.Attributes}");
            }

            // Список полей и свойств
            FieldInfo[] fields = myClassType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            PropertyInfo[] properties = myClassType.GetProperties();
            Console.WriteLine("Поля и свойства:");
            foreach (var field in fields)
            {
                Console.WriteLine($"{field.Name}, Тип: {field.FieldType}, Модификатор доступа: private");
            }
            foreach (var property in properties)
            {
                Console.WriteLine($"{property.Name}, Тип: {property.PropertyType}, Модификатор доступа: {property.GetGetMethod().IsPublic}");
            }

            // Список методов
            MethodInfo[] methods = myClassType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine("Методы:");
            foreach (var method in methods)
            {
                Console.WriteLine($"{method.Name}, Тип возвращаемого значения: {method.ReturnType}, Модификатор доступа: {method.Attributes}");
            }
        }
    }
}
