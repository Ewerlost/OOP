using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public static class ReflectiveFactory
    {
        public static List<Type> GetCreatableTypes()
        {
            return Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(ICreatable).IsAssignableFrom(t) && !t.IsAbstract)
                .ToList();
        }

        public static object Create(Type type, object[] args)
        {
            return Activator.CreateInstance(type, args);
        }
    }
}
