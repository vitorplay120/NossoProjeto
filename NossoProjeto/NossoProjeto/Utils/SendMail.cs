using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using NossoProjeto.Models;

namespace NossoProjeto.Utils
{
    public static class SendMail
    {

        public static bool EnviaEmail(Email email)
        {

            try
            {
                MailMessage message = new MailMessage();
                message.IsBodyHtml = true;
                message.From = new MailAddress(email.getFrom(), email.getFromName());
                message.To.Add(new MailAddress(email.getTo()));
                message.Subject = email.getSubject();
                message.Body = email.getBody();

                message.Headers.Add("X-SES-CONFIGURATION-SET", email.getConfigSet());

                using (var client = new System.Net.Mail.SmtpClient(email.getHost(), email.getPort()))
                {                    
                    client.Credentials = new NetworkCredential(email.GetSmtp_UserName(),email.GetSmtp_Password());
                    client.EnableSsl = true;

                    
                    try
                    {
                        client.Send(message);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }


            }
            catch(Exception e)
            {
                return false;
            }


            return true;
        }

    }
}