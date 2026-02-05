namespace GettingStarted.Events.ProductStock;

public class ZeroStockEventArgs(Product product) : EventArgs
{
    public Product Product = product;
}

public class LowStockEventArgs(Product product) : EventArgs
{
    public Product Product = product;
}

public sealed class InventoryService(Product product)
{
    public event EventHandler<ZeroStockEventArgs>? ZeroStock; 
    public event EventHandler<LowStockEventArgs>? LowStock;

    public bool PurchaseProduct(int quantity)
    {
        if (product.Stock < quantity) return false;
        product.Stock -= quantity;
        switch (product.Stock)
        {
            case <= 0:
                OnZeroStock();
                break;
            case < 10:
                OnLowStock();
                break;
        }
        return true;
    }

    private void OnZeroStock()
    {
        ZeroStock?.Invoke(this, new ZeroStockEventArgs(product));
    }

    private void OnLowStock()
    {
        LowStock?.Invoke(this, new LowStockEventArgs(product));
    }
}