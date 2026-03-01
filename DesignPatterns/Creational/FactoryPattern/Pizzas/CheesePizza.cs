namespace DesignPatterns.Creational.FactoryPattern.Pizzas;

public class CheesePizza : Pizza
{
    
    public override void Bake()
    {
        Console.Write("Cheese: ");
        base.Bake();
    }
}
