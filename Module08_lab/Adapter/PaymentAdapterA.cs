namespace Module08_lab.Adapter;

public class PaymentAdapterA: IPaymentProcessor
{
    private readonly ExternalPaymentSystemA _system;

    public PaymentAdapterA(ExternalPaymentSystemA system)
    {
        _system = system;
    }


    public void ProcessPayment(double amount)
    {
        _system.MakePayment(amount);
    }

    public void RefundPayment(double amount)
    {
       _system.MakeRefund(amount);
    }
}