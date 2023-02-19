using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Creational.FactoryDesignPattern
{
    public interface IProduct
    {
        string GetName();
    }

    public class ProductA : IProduct
    {
        public string GetName()
        {
            return "Product A";
        }
    }

    public class ProductB : IProduct
    {
        public string GetName()
        {
            return "Product B";
        }
    }

}
