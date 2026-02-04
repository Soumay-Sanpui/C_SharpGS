namespace C_SharpGS.Events.ProductStock;

public class ZeroStockEventArgs(Product product) : EventArgs
{
    public Product Product = product;
}

public class LowStockEventArgs(Product product) : EventArgs
{
    public Product Product = product;
}

public class InventoryService
{
    private Product _product;

    public event EventHandler<ZeroStockEventArgs> ZeroStock; 
    public event EventHandler<LowStockEventArgs> LowStock; 

    public InventoryService(Product product)
    {
        _product = product;
    }

    public bool PurchaseProduct(int quantity)
    {
        if (_product.Stock < quantity) return false;
        _product.Stock -= quantity;
        switch (_product.Stock)
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

    protected virtual void OnZeroStock()
    {
        ZeroStock?.Invoke(this, new ZeroStockEventArgs(_product));
    }

    protected virtual void OnLowStock()
    {
        LowStock?.Invoke(this, new LowStockEventArgs(_product));
    }
}