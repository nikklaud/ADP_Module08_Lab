namespace Module08_lab.Decorator;

public class CorricaDecorator: BeverageDecorator
{
    public CorricaDecorator(IBeverage beverage) : base(beverage)
    {
    }

    public override string GetDescription()
    {
        var description = base.GetDescription();
        return description + " corrica";
    }

    public override decimal GetCost()
    {
        var cost = base.GetCost();
        return cost + 6m;
    }
    
}