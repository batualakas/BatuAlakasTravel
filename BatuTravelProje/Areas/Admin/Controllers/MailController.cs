﻿using BatuTravelProje.Models;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;


namespace BatuTravelProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "batualakasproje@gmail.com");


            mimeMessage.From.Add(mailboxAddressFrom);
            MailboxAddress mailboxAddressTo=new MailboxAddress("User", mailRequest.ReceiverMail);

            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody=mailRequest.Body;
            mimeMessage.Body=bodyBuilder.ToMessageBody();

            mimeMessage.Subject = mailRequest.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            //deneme kısmı bu şifreyi gmail kısmından aldım "cptduhfcuiuddbrl" orjinal şifre 123batu123 yoksa mail gönderme işlemi olmuyo
            client.Authenticate("batualakasproje", "cptduhfcuiuddbrl");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}
// mail geldi başarılı 
//batualakasproje@gmail.com