using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using NossoProjeto.Utils;
using NossoProjeto.Models;

namespace NossoProjeto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EnviarEmail(string nome, string email)
        {

            string From = "victorlima@uni9.edu.br";
            string body = "VOCÊ ENTROU EM CONTATO CONOSCO, EM BREVE RETORNAREMOS.";
           

            if (!string.IsNullOrEmpty(email))
            {

                Email mail = new Email();
                mail.setFrom(From);
                mail.setTo(email);
                mail.setFromName("Victor");
                mail.setSubject("Obrigado por entrar em contato!");
                mail.setBody(body);

                if (SendMail.EnviaEmail(mail))
                {
                    return Json(new { erro = false, message = "E-mail enviado." });
                }
                else
                {
                    return Json(new { erro = true, message = "E-mail não enviado." });
                }
            }



            return Json(new { erro = true, message = "E-mail não enviado." });

        }
    }
}