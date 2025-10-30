namespace Module08_lab.Adapter;

public static class PaymentServiceFactory
{
    public static IPaymentProcessor PaymentProcessor(string paymentSystem)
    {
        switch (paymentSystem)
        {
            case "A":
                return new PaymentAdapterA(new ExternalPaymentSystemA());
            case "B":
                return new PaymentAdapterB(new ExternalPaymentSystemB());
            default:
                throw new NotSupportedException($"Payment system {paymentSystem} not supported");
        }
    }
}