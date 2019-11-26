using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NossoProjeto.Models
{
    public class Email
    {
        private string From;
        private string From_Name;
        private string To;
        private string Smtp_UserName;
        private string Smtp_Password;
        private string Config_Set;
        private string Host;
        private int    Port;
        private string Subject;
        private string Body;

        public Email()
        {
            this.Smtp_UserName = "victorlima@uni9.edu.br";
            this.Smtp_Password = "vitorsal123";
            this.Port = 587;
            this.Config_Set = "ConfigSet";
            this.Host = "smtp.gmail.com";
        }

        public void setFrom(string from)
        {
            this.From = from;
        }

        public void setFromName(string fromname)
        {
            this.From_Name = fromname;
        }

        public void setTo(string to)
        {
            this.To = to;
        }

        public void setSubject(string subject)
        {
            this.Subject = subject;
        }

        public void setBody(string body)
        {
            this.Body = body;
        }

        public string getFrom()
        {
            return this.From;
        }

        public string getFromName()
        {
            return this.From_Name;
        }

        public string getTo()
        {
            return this.To;
        }

        public string getSubject()
        {
            return this.Subject;
        }

        public string getBody()
        {
            return this.Body;
        }

        public string getConfigSet()
        {
            return this.Config_Set;
        }

        public string getHost()
        {
            return this.Host;
        }

        public int getPort()
        {
            return this.Port;
        }

        public string GetSmtp_UserName()
        {
            return this.Smtp_UserName;
        }

        public string GetSmtp_Password()
        {
            return this.Smtp_Password;
        }

    }
}