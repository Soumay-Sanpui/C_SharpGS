using DesignPatterns.Creational.FactoryPattern.Pizzas;

namespace DesignPatterns.Creational.FactoryPattern;

/// <summary>
/// Simple Factory is not a design pattern it's just a programming idiom.
/// </summary>
public class SimplePizzaFactory
{
    public static Pizza CreatePizza(string type)
    {
        Pizza pizza;
        return type.ToLower() switch
        {
            "cheese" => pizza = new CheesePizza(),
            "greek" => pizza = new GreekPizza(),
            "pepproni" => pizza = new PepperoinPizza(),
            _ => pizza = new CheesePizza(),
        };
    }
}
