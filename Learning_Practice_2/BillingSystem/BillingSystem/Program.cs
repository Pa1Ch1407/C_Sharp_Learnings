using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem
{
    class Program
    {
        static void Main()
        {
            double amount = 1000;

            // ref: apply discount modifies original amount
            ApplyDiscount(ref amount);
            Console.WriteLine("After Discount: " + amount);

            // out: calculate total and tax
            double total, tax;
            CalculateBill(amount, out total, out tax);
            Console.WriteLine($"Total: {total}, Tax: {tax}");

            // in: display details (read-only)
            PrintBill(in total);

            // optional: send email receipt
            SendReceipt("pavan.kasyap@gmail.com");  // uses default message
            SendReceipt("pavan.kasyap@gmail.com", "Thank you for shopping!");

            // overloading: multiple payment options
            PayBill(500);
            PayBill(500, "Credit Card");
        }
        static void ApplyDiscount(ref double amount)
        {
            amount -= amount * 0.1;  // 10% discount
        }
        static void CalculateBill(double amount, out double total, out double tax)
        {
            tax = amount * 0.18;     // 18% GST
            total = amount + tax;
        }
        static void PrintBill(in double total)
        {
            Console.WriteLine($"Final Payable Amount: {total}");
        }
        static void SendReceipt(string email, string message = "Your order is confirmed.")
        {
            Console.WriteLine($"Email sent to {email}: {message}");
        }
        static void PayBill(double amount)
        {
            Console.WriteLine($"Paid ₹{amount} in cash.");
        }
        static void PayBill(double amount, string method)
        {
            Console.WriteLine($"Paid ₹{amount} using {method}.");
        }
    }
}
