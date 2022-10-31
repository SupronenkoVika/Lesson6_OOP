namespace Lesson6_OOP
{
    internal class Food : Product
    {
        public ProductType type { get; private set; }
        public Food(int id, string name, decimal price, double quant, ProductType type) : base(id, name, price, quant, type)
        {

        }
    }
}
