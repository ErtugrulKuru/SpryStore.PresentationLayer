﻿using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SpryStore.PresentationLayer.Models;

namespace SpryStore.PresentationLayer.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequestViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "hertugrulkuru@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);
            var bodyBuilder= new BodyBuilder();
            bodyBuilder.TextBody= model.Body;
            mimeMessage.Body=bodyBuilder.ToMessageBody();
            mimeMessage.Subject=model.Subject;
            SmtpClient client= new SmtpClient();
            client.Connect("smtp.gmail.com",587,false);
            client.Authenticate("hertugrulkuru@gmail.com", "kklhhijlshrkmkgj");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }
    }
}
