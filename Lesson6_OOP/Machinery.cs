namespace Lesson6_OOP
{
    internal class Machinery : Product
    {
        public ProductType type { get; private set; }
        public Machinery(int id, string name, decimal price, double quant, ProductType type) : base(id, name, price, quant, type)
        {

        }
    }
}
