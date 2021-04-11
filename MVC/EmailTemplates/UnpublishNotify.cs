using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using NoteMarketPlace.Models;

namespace NoteMarketPlace.EmailTemplates
{
    public class UnpublishNotify
    {
        public static void UnPublishing(string SellerName, string NoteTitle, string Remarks, string Email)
        {
            var fromEmail = new MailAddress("shaikhsaniya2604@gmail.com", "Notes Marketplace"); //need system email
            var toEmail = new MailAddress(Email);
            var fromEmailPassword = "Sahilkhan90325@";
            string subject = "Sorry! We need to remove your notes from our portal";

            string msg = "Hello" + " " + SellerName + "<br/>";
            msg += "We want to inform you that, " + " " + NoteTitle + " " + "has been removed from the portal.<br/>";
            msg += "Please find our remarks as below -<br/>";
            msg += Remarks;
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