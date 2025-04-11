using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static Dictionary<Type, int> ObjectCounts { get; } = new();

        static Entity()
        {
            
        }

        protected Entity()
        {
            Type type = this.GetType();
            if (ObjectCounts.ContainsKey(type))
            {
                ObjectCounts[type]++;
            }
            else
            {
                ObjectCounts[type] = 1;
            }
        }

        public abstract string GetDetails();

    }

    public interface ICreatable { }
}
