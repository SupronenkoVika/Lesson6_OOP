using Lesson6_OOP;

Inventory inventory = new Inventory();
inventory.prods = new List<Product>();

Food apple = new Food(1, "Apple", 3.50m, 2.0, ProductType.Food);
Food tomato = new Food(2, "Tomato", 5.00m, 3, ProductType.Food);
Machinery phone = new Machinery(3, "Phone", 1560.00m, 1, ProductType.Machinery);
Machinery computer = new Machinery(4, "Computer", 2350.00m, 1, ProductType.Machinery);
Chemicals cleanser = new Chemicals(5, "Cleanser", 9.50m, 2, ProductType.Chemicals);
Chemicals soap = new Chemicals(6, "Soap", 5.00m, 6, ProductType.Chemicals);

inventory.AddProd(apple);
inventory.AddProd(tomato);
inventory.AddProd(phone);
inventory.AddProd(computer);
inventory.AddProd(cleanser);
inventory.AddProd(soap);

Console.WriteLine("Choose you want to see: ");
Console.WriteLine("a - All products");
Console.WriteLine("f - Food");
Console.WriteLine("m - Machinery");
Console.WriteLine("c - Chemicals");
Console.WriteLine("p - Products total price");

char prodAct = Convert.ToChar(Console.ReadLine());

switch (prodAct)
{
    case 'a':
        inventory.ProductsOutput(inventory.prods);
        break;
    case 'f':
        inventory.GetFood(inventory.prods);
        break;
    case 'm':
        inventory.GetMachinery(inventory.prods);
        break;
    case 'c':
        inventory.GetChemicals(inventory.prods);
        break;
    case 'p':
        inventory.ProdsTotalPrice(inventory.prods);
        break;
}