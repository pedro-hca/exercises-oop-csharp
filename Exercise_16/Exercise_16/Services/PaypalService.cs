namespace Exercise_16.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }

        public double Interest(double amount, int mounths)
        {
            return amount * 0.01 * mounths;
        }
    }
}
