using common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace bll
{
    public static class ManegerSendEMail
    {
        public static void sendEmail(SendEmail sendEmail)
        {
           
             var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("bniantshalem@gmail.com", "bintsh123"),
                EnableSsl = true,
            };


            
            var mailMessage = new MailMessage
            {
                From = new MailAddress("bniantshalem@gmail.com"),
                Subject = sendEmail.Massage,
                Body = "<h1>" + sendEmail.Sub + "</h1>",
                IsBodyHtml = true,
            };
            mailMessage.To.Add(sendEmail.Address);

            smtpClient.Send(mailMessage);
        }
    }
}
