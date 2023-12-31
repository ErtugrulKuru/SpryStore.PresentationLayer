﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SpryStore.DataAccessLayer.Concrete;
using SpryStore.EntityLayer.Concrete;

namespace SpryStore.PresentationLayer.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Inbox()
        {
            var context = new Context();
            var values = context.Messages.Where(x => x.ReceiverMail == "deneme1@gmail.com").ToList();
            return View(values);
        }

        public IActionResult Sendbox()
        {
            var context = new Context();
            var values = context.Messages.Where(x => x.SenderMail == "deneme1@gmail.com").ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            var context = new Context();
            message.SenderName = "Mustafa Kuru";
            message.SenderMail = "deneme1@gmail.com";
            message.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("Sendbox");
        }
    }
}
