namespace Module08_lab.Adapter;

public class InternalPaymentProcessor: IPaymentProcessor
{
    public void ProcessPayment(double amount)
    {
        throw new NotImplementedException();
    }

    public void RefundPayment(double amount)
    {
        throw new NotImplementedException();
    }
}