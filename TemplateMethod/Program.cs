using System;
using TemplateMethod.Models;

namespace TemplateMethod
{
    internal class Program
    {
        // The client code calls the template method to execute the algorithm.
        // Client code does not have to know the concrete class of an object it
        // works with, as long as it works with objects through the interface of
        // their base class.
        static void Main(string[] args)
        {
            PaymentBase firstBankPayment = new FirstBankPayment();
            PaymentBase secondBankPayment = new SecondBankPayment();

            Console.WriteLine("<---First Bank--->");
            firstBankPayment.TemplateMethod();
            Console.WriteLine("<------------->");

            Console.WriteLine("<---Second Bank--->");
            secondBankPayment.TemplateMethod();
            Console.WriteLine("<------------->");

            Console.ReadKey();
        }
    }
}
