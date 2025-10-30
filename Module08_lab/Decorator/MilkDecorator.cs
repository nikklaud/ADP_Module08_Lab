namespace Module08_lab.Decorator;

public class MilkDecorator: BeverageDecorator
{
    public MilkDecorator(IBeverage beverage) : base(beverage)
    {
    }

    public override decimal GetCost()
    {
        var c = base.GetCost();
        return c + 10m;
    }

    public override string GetDescription()
    {
        var description = base.GetDescription();
        return description + " suhariks milk";
    }
}