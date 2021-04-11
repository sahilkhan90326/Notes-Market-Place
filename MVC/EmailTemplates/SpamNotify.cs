using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace NoteMarketPlace.EmailTemplates
{
    public class SpamNotify
    {
        public static void Notify(String Membername, String SellerName, string NoteTitle)
        {
            var fromEmail = new MailAddress("shaikhsaniya2604@gmail.com", "Notes Marketplace"); //need system email
            var toEmail = new MailAddress("sahilkhan90326@gmail.com");
            var fromEmailPassword = "Sahilkhan90326@";

            string subject = Membername + " Reported an issue for " +  NoteTitle;


            string msg = "Hello Admins, <br/>";
            msg += "We want to inform you that, " + " " + Membername + " " + "Reported an issue for  "+ SellerName + "'s Note with  " + NoteTitle + "<br/>";
            msg += "Please look at the notes and take required actions " + "<br/>";
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