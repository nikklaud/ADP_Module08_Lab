namespace Module08_lab.Adapter;

public class PaymentAdapterB: IPaymentProcessor
{
    private readonly ExternalPaymentSystemB _system;

    public PaymentAdapterB(ExternalPaymentSystemB system)
    {
        _system = system;
    }

    public void ProcessPayment(double amount)
    {
        _system.SendPayment(amount);
    }

    public void RefundPayment(double amount)
    {
        _system.SendPayment(amount);
    }
}