namespace C_SharpGS.Events.ProductStock;

public class Man
{
    public static void SayLowStock(Object? sender, LowStockEventArgs e)
    {
        Console.WriteLine($"The stock of the product {e.Product.ProductName} is Low.");
    }

    public static void SayZeroStock(Object? sender, ZeroStockEventArgs e)
    {
        Console.WriteLine($"The stock of the product {e.Product.ProductName} is Zero.");
    }
}