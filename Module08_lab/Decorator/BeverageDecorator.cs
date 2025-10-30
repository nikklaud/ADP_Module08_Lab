namespace Module08_lab.Decorator;

public abstract class BeverageDecorator: IBeverage
{
    private readonly IBeverage _beverage;

    protected BeverageDecorator(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public virtual decimal GetCost()
    {
        return _beverage.GetCost();
    }

    public virtual string GetDescription()
    {
        return _beverage.GetDescription();
    }
}