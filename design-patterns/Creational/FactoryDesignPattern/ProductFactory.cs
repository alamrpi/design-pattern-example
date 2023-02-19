namespace design_patterns.Creational.FactoryDesignPattern
{
    public class ProductFactory
    {
        public IProduct GetInstance(string productType)
        {
            switch (productType)
            {
                case "A":
                    return new ProductA();
                case "B":
                    return new ProductB();
                default:
                    throw new ArgumentException("Invalid product type");
            }
        }
    }
}
