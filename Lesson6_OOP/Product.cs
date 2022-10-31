namespace Lesson6_OOP
{
    internal class Product
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public double Quantity { get; private set; }
        public ProductType Type { get; private set; }

        public Product(int id, string name, decimal price, double quant, ProductType type)
        {
            ID = id;
            Name = name;
            Price = price;
            Quantity = quant;
            Type = type;
        }
    }
}
