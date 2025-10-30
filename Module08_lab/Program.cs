
using Module08_lab.Decorator;

namespace Module08_lab;

internal class Program
{
    private static void Main(string[] args)
    {
        IBeverage coffe = new BaseBeverage();
        Console.WriteLine($"{coffe.GetDescription()}  {coffe.GetCost()}");

        while (true)
        {
            Console.WriteLine("Do you want to add Milk, Sugar, Chocolate or Corrica?");
            var input = Console.ReadLine();
            switch (input)
            {
                case "milk":
                    coffe = new MilkDecorator(coffe);
                    Console.WriteLine($"{coffe.GetDescription()}  {coffe.GetCost()}");
                    break;
                case "sugar":
                    coffe = new SugarDecorator(coffe);
                    Console.WriteLine($"{coffe.GetDescription()}  {coffe.GetCost()}");
                    break;
                case "chocolate":
                    coffe = new ChocolateDecorator(coffe);
                    Console.WriteLine($"{coffe.GetDescription()}  {coffe.GetCost()}");
                    break;
                case "corrica":
                    coffe = new CorricaDecorator(coffe);
                    Console.WriteLine($"{coffe.GetDescription()}  {coffe.GetCost()}");
                    break;
                case "exit":
                    return;
                default:
                    Console.WriteLine("Invalid input, please try again");
                    break;
            }
        }
    }
}