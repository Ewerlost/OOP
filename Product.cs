using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
     public abstract class Product : Entity, ICreatable
     {
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Seller Seller { get; set; } 

        public string ImagePath { get; set; }

        public abstract string GetCategory();

        public virtual void ApplyDiscount(decimal percent)
        {
            if (percent <= 0 || percent >= 100) return;
            Price -= Price * (percent / 100);
        }

        public override string GetDetails()
        {
            return $"{GetCategory()} - {Name}, Цена: {Price:C}, Описание: {Description}";
        }

    }
}
