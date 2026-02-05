namespace GettingStarted.Events.ProductStock;

public class Product
{
    public int Id { get; set; }
    public string? ProductName { get; private init; }
    public int Stock { get; set; }

    public static void RunProductStockExample()
    {
        Product phone = new()
        {
            Id = 1,
            ProductName = "Phone",
            Stock = 100,
        };

        InventoryService service = new(phone);
      
        service.LowStock += Man.SayLowStock;
        service.ZeroStock += Man.SayZeroStock;
        
        Console.WriteLine(service.PurchaseProduct(100) ? "Product Bought Successfully !" : "Unable to get Product.");
       
    }
}