namespace DesignPatterns.Creational.FactoryPattern.Pizzas;

public abstract class Pizza
{
    public void Prepare()
    {
        Console.WriteLine("Preparing pizza..");
    }
    public virtual void Bake()
    {
        Console.WriteLine("Baking pizza..");
    }

    public void Cut()
    {
        Console.WriteLine("Cutting Pizza....");
    }

    public void Box()
    {
        Console.WriteLine("Boxing pizza...");
    }
}
