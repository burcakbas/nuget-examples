using Core.Logging;
using FluentEmail.Smtp;

namespace Core.SMTP
{
    public class SmtpHelper
    {
        public static SmtpSender GetSender(string config)
        {
            //configuration codes here

            Logger.Log("SmtpHelper: Configuring and setting sender object.");
            return new SmtpSender();
        }
    }
}
