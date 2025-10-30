namespace Module08_lab.Decorator;

public class ChocolateDecorator: BeverageDecorator
{
    public ChocolateDecorator(IBeverage beverage) : base(beverage)
    {
    }

    public override decimal GetCost()
    {
        var cost = base.GetCost();
        return cost + 50m;
    }

    public override string GetDescription()
    {
        var description = base.GetDescription();
        return description + " chocolate";
    }

}