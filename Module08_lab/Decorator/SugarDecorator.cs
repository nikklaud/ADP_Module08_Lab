namespace Module08_lab.Decorator;

public class SugarDecorator: BeverageDecorator
{
    public SugarDecorator(IBeverage beverage) : base(beverage)
    {
    }

    public override decimal GetCost()
    {
        var cost = base.GetCost();
        return cost + 12m;
    }

    public override string GetDescription()
    {
        var description = base.GetDescription();
        return description + " sugar penka";
    }
}