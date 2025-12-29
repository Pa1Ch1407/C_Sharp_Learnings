using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles
{
    //Bad Way
    //class EmailService
    //{
    //    public void SendEmail(string msg)
    //    {
    //        Console.WriteLine("Sending Email: " + msg);
    //    }
    //}

    //class Notification
    //{
    //    private EmailService _emailService = new EmailService();
    //    private EmailService _smsServ = new EmailService();

    //    public void Send(string msg)
    //    {
    //        _emailService.SendEmail(msg);
    //        _smsServ.SendEmail(msg);
    //    }

    //}

    interface IMesService
    {
        void send(string message);
    }

    class EmailService : IMesService
    {
        public void send(string message)
        {
            Console.WriteLine("Email sent: " +message);
        }
    }

    class SmsService: IMesService
    {
        public void send(string message)
        {
            Console.WriteLine("Sms sent: " + message);
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            //RegularDis disCalculator = new RegularDis();
            //disCalculator.Calculate(10000);
            
        }
    }
}
