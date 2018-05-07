using System;

namespace Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Core.Mail.MailHelper mailHelper = new Core.Mail.MailHelper();
            mailHelper.Send("hede");

            Console.ReadLine();
        }
    }
}
