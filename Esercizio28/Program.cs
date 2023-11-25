/*Given two lists, one containing Product objects and the other containing Category objects. 
 * Both classes need a CategoryId property. 
 * Create a console application that joins the two lists based on the CategoryId using LINQ.
 */


var categories = new List<Category>
{
    new Category("Cellulari", 1),
    new Category("Televisioni",2),
    new Category("Automobili",3),
    new Category("Laptop",4),
};

var products = new List<Product>
{
    new Product("Iphone 14 pro",1),
    new Product("Samsung Galaxy s22",1),
    new Product("Huawei P20",1),
    new Product("Fiat 500",3),
    new Product("Jaguar xf",3),
    new Product("Lenovo ideaPadGaming",4),
    new Product("Samung Oled A44i",2)

};

var result = products.Join(
    categories,
    product => product.CategoryId,
    categories => categories.Id,
    (product, category) => new
    { product.Name, category.Type });

var result2 = from product in products
              join category in categories
              on product.CategoryId equals category.Id
              select new { product.Name, category.Type };


Console.WriteLine("Method Syntax\n");
foreach (var item in result)
{
    Console.WriteLine($"Prodotto : {item.Name}\n Categoria : {item.Type}");
}
Console.WriteLine("\nQuery Syntax\n");
foreach (var item in result2)
{
    Console.WriteLine($"Prodotto : {item.Name}\n Categoria : {item.Type}");
}




internal class Category
    {
    public int Id { get; set; }   
    public string Type { get; set; }
    public Category(string name, int id)
    
    {
        Id = id;
        Type = name;
    }
    public override string ToString()
    {
        return $"{Type} / {Id}";
    }
}

    
    internal class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public Product(string name, int id)
    {
        CategoryId = id;
        Name = name;
    }
    public override string ToString()
    {
        return $"{Name} / {CategoryId}";
    }
}

