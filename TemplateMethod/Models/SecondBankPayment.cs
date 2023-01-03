using System;

namespace TemplateMethod.Models
{
    // Concrete classes have to implement all abstract operations of the base
    // class. They can also override some operations with a default
    // implementation.
    public class SecondBankPayment : PaymentBase
    {
        protected override bool IsPaymentGatewayActive()
        {
            return true;
        }

        protected override void RedirectUserToPaymentGateway()
        {
            Console.WriteLine("Redirecting User to Second Bank Payment Gateway");
        }

        protected override void PaymentGatewayResponse()
        {
            Console.WriteLine("Second Bank Payment Was Success");
        }

        protected override void SendTransactionStatusToUserWithSms()
        {
            Console.WriteLine("Send Sms To User (Second Bank)");
        }
    }
}
