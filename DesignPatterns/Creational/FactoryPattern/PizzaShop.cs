using DesignPatterns.Creational.FactoryPattern.Pizzas;
namespace DesignPatterns.Creational.FactoryPattern;


public class PizzaShop
{
    public Pizza OrderPizza(string type)
    {
        Pizza pizza = SimplePizzaFactory.CreatePizza("cheese");
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}
