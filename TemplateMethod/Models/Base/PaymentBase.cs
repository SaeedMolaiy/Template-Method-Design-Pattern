using System;

namespace TemplateMethod.Models
{
    // The Abstract Class defines a template method that contains a skeleton of
    // some algorithm, composed of calls to (usually) abstract primitive
    // operations.
    //
    // Concrete subclasses should implement these operations, but leave the
    // template method itself intact.
    public abstract class PaymentBase
    {
        // The template method defines the skeleton of an algorithm.
        public void TemplateMethod()
        {
            var amount = CalculatePaymentAmount();

            var gateWayStatus = IsPaymentGatewayActive();

            if (gateWayStatus)
            {
                RedirectUserToPaymentGateway();
                PaymentGatewayResponse();
                SendTransactionStatusToUserWithSms();
                SendTransactionStatusToUserWithEmail();
            }
            else
            {
                Console.WriteLine("Gateway is not active");
            }
        }

        //base operations already have implementations. 
        protected int CalculatePaymentAmount()
        {
            Console.WriteLine("PaymentBase says: Im calculating the amount");
            return 1000;
        }

        //operations have to be implemented in subclasses.
        protected abstract bool IsPaymentGatewayActive();
        protected abstract void RedirectUserToPaymentGateway();
        protected abstract void PaymentGatewayResponse();


        // These are "hooks." Subclasses may override them, but it's not
        // mandatory since the hooks already have default (but empty)
        // implementation. Hooks provide additional extension points in some
        // crucial places of the algorithm.
        protected virtual void SendTransactionStatusToUserWithSms() { }
        protected virtual void SendTransactionStatusToUserWithEmail() { }
    }
}
