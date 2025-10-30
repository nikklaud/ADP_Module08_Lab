namespace Module08_lab.Decorator;

public class BaseBeverage: IBeverage
{
    public decimal GetCost()
    {
        return 0.99m;
    }

    public string GetDescription()
    {
        return "Base Beverage, simple beverage for Abdurakhman";
    }
}