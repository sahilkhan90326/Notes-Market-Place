using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using NoteMarketPlace.Models;

namespace NoteMarketPlace.EmailTemplates
{
    public class InformBuyer
    {
            public static void InformingBuyer(string BuyerName, string EmailId, string SellerName)
            {
                var fromEmail = new MailAddress("shaikhsaniya2604@gmail.com", "Notes Marketplace"); //need system email
                var toEmail = new MailAddress(EmailId);
                var fromEmailPassword = "Sahilkhan90326@";
                string subject = SellerName + "Allows you to Download a note";
                string msg = "Hello" + " "+ BuyerName + "<br/>";
                msg += "We would like you to inform that," + " "+  SellerName + " "+"Allows you to Download a note" + "<br/>";
                msg += "<br/><br/>Regards,<br/>";
                msg += "NotesMarketPlace";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)
                };
                using (var message = new MailMessage(fromEmail, toEmail)
                {
                    Subject = subject,
                    Body = msg,
                    IsBodyHtml = true
                })
                    smtp.Send(message);
            }
        }
}