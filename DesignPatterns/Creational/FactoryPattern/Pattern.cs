using System;

namespace DesignPatterns.Creational.FactoryPattern;

/// <summary>
/// Intent: Create objects without exposing the creation logic.
/// </summary>
public class Pattern
{
    public static void RunFactoryPatternExample()
    {
        PizzaShop pizzaShop = new();
        pizzaShop.OrderPizza("GrEeK");
    }
}
