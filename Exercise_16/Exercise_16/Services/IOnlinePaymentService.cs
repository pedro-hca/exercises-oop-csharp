namespace Exercise_16.Services
{
    internal interface IOnlinePaymentService
    {
        public double PaymentFee(double amount);

        public double Interest(double amount, int mounths);
    }
}
