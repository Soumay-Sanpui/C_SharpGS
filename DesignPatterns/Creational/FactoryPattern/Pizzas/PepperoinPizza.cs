namespace DesignPatterns.Creational.FactoryPattern.Pizzas;

public class PepperoinPizza: Pizza
{
    public override void Bake()
    {
        Console.Write("Pepperoni: ");
        base.Bake();
    }
}
