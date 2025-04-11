using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class Phone : Product
    {
        public string Model { get; set; }
        public int StorageGB { get; set; }

        public Phone(string name, decimal price, string description, string model, int storageGB, string imagePath)
        {
            Name = name;
            Price = price;
            Description = description;
            Model = model;
            StorageGB = storageGB;
            ImagePath = imagePath;
        }

        public override string GetCategory() => "Телефон";

        public override string GetDetails()
        {
            return base.GetDetails() + $", Модель: {Model}, Память: {StorageGB} ГБ";
        }

        public override string ToString()
        {
            return GetDetails();
        }

    }
}
