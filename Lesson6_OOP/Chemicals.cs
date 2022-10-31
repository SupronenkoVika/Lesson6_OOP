namespace Lesson6_OOP
{
    internal class Chemicals : Product
    {
        public ProductType type { get; private set; }
        public Chemicals(int id, string name, decimal price, double quant, ProductType type) : base(id, name, price, quant, type)
        {

        }
    }
}
