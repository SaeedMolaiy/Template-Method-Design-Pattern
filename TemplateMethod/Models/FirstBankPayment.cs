using System;

namespace TemplateMethod.Models
{
    // Concrete classes have to implement all abstract operations of the base
    // class. They can also override some operations with a default
    // implementation.
    public class FirstBankPayment : PaymentBase
    {
        protected override bool IsPaymentGatewayActive()
        {
            return true;
        }

        protected override void RedirectUserToPaymentGateway()
        {
            Console.WriteLine("Redirecting User to First Bank Payment Gateway");
        }

        protected override void PaymentGatewayResponse()
        {
            Console.WriteLine("First Bank Payment Was Success");
        }
    }
}
