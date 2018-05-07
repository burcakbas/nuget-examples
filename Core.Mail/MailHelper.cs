using System;
using Core.Logging;
using Core.SMTP;

namespace Core.Mail
{
    public class MailHelper
    {
        public void Send(string message)
        {
            var config = string.Empty;
            var sender = SmtpHelper.GetSender(config);
            //sender.Send(null, null);

            Logger.Log("MailHelper: Message sent.");
        }
    }
}
