using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace LeaveManagement.Web.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly string smtpServer;
        private readonly int smtPort;
        private readonly string fromEmailAddress;

        public EmailSender(string smtpServer,int smtPort,string fromEmailAddress)
        {
            this.smtpServer = smtpServer;
            this.smtPort = smtPort;
            this.fromEmailAddress = fromEmailAddress;
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage
            {
                From = new MailAddress(email),
                Subject=subject,
                Body=htmlMessage,
                IsBodyHtml=true
            };

            message.To.Add(new MailAddress(email));

            using (var client = new SmtpClient(smtpServer, smtPort))
                client.Send(message);

            return Task.CompletedTask;
        }
    }
}
