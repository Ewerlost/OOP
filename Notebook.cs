using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    public class Notebook : Product
    {
        public string CPU {  get; set; }
        public int RAM { get; set; }
        public string GPU { get; set; }

        public Notebook(string name, decimal price, string description, string cpu, string gpu, int ram, string imagePath)
        {
            Name = name;
            Price = price;
            Description = description;
            CPU = cpu;
            GPU = gpu;
            RAM = ram;
            ImagePath = imagePath;
        }
        public override string GetCategory() => "Ноутбук";
        public override string GetDetails()
        {
            return base.GetDetails() + $", CPU: {CPU}, GPU: {GPU}, RAM: {GPU}";
        }

        public override string ToString()
        {
            return GetDetails();
        }

    }
}
