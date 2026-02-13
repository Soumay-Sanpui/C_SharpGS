namespace DesignPatterns.Structural.DecoratorPattern.Beverages;

/// <summary>
/// Abstract base type for beverages used in the Decorator pattern.
/// </summary>
/// <remarks>
/// Adding new behavior to the existing class without modifying the code of the existing class.
/// </remarks>
public abstract class Beverage
{
    /// <summary>
    /// A human-readable description of the beverage.
    /// Concrete beverages and decorators may modify this value.
    /// </summary>
    public virtual string Description { get; set; } = "This is a beverage";

    /// <summary>
    /// Calculates the cost of the beverage. Concrete beverages return
    /// their base price; decorators should add their surcharge to
    /// the wrapped beverage's cost.
    /// </summary>
    public abstract decimal Cost();
}
