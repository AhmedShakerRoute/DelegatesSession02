using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesSession02.MultiCastDelegate
{
    public delegate void NotifyDelegate(string message);
    internal class Notification
    {
        public static void SendEmail(string message)
        {
            Console.WriteLine($"  [Email] Sending: {message}");
        }
        public static void SendSMS(string message)
        {
            Console.WriteLine($"  [SMS] Sending: {message}");
        }
        public static void SendPush(string message)
        {
            Console.WriteLine($"  [Push] Sending: {message}");
        }
        
    }
}
