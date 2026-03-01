namespace DesignPatterns.Creational.FactoryPattern.Pizzas;

public class GreekPizza : Pizza
{
    public override void Bake()
    {
        Console.WriteLine("Baking Greek Pizza.....");
    }
}
