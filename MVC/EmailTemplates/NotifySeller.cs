using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using NoteMarketPlace.Models;

namespace NoteMarketPlace.EmailTemplates
{
    public class NotifySeller
    {

        public static void InformingSeller(string SellerName, string EmailId, string BuyerName)
        {
            var fromEmail = new MailAddress("shaikhsaniya2604@gmail.com", "Notes Marketplace"); //need system email
            var toEmail = new MailAddress(EmailId);
            var fromEmailPassword = "Sahilkhan90326@";
            string subject = BuyerName + "  Wants to purchase your note";
            string msg = "Hello" + SellerName + "<br/>";
            msg += "We would like you to inform that," + BuyerName + " " +"Wants to purchase your notes. Please see Buyer Request tab and allow download access to Buyer if you have recived the payment from him/her";
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