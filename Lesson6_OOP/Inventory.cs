namespace Lesson6_OOP
{
    internal class Inventory
    {
        public List<Product> prods;
        decimal totalPrice = 0;

        public void AddProd(Product prod)
        {
            prods.Add(prod);
        }

        public void ProdsData(Product product)
        {
            Console.WriteLine($"Id: {product.ID}\n Name: {product.Name}\n Price {product.Price}\n Quantity: {product.Quantity}\n Type: {product.Type}");
        }

        public void ProductsOutput(List<Product> productList)
        {
            foreach (Product products in productList)
            {
                ProdsData(products);
                Console.WriteLine();
            }
        }

        public decimal ProdsTotalPrice(List<Product> products)
        {
            totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.Price;
            }
            Console.WriteLine(totalPrice);
            return totalPrice;
        }

        public void GetFood(List<Product> ProdsList)
        {
            foreach (Product prod in ProdsList)
            {
                if (prod.Type == ProductType.Food)
                {
                    ProdsData(prod);
                }
            }
        }
        public void GetMachinery(List<Product> ProdsList)
        {
            foreach (Product prod in ProdsList)
            {
                if (prod.Type == ProductType.Machinery)
                {
                    ProdsData(prod);
                }
            }
        }
        public void GetChemicals(List<Product> ProdsList)
        {
            foreach (Product prod in ProdsList)
            {
                if (prod.Type == ProductType.Chemicals)
                {
                    ProdsData(prod);
                    Console.WriteLine();
                }
            }
        }
    }
}
