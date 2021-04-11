using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using NoteMarketPlace.Models;

namespace NoteMarketPlace.EmailTemplates
{
    public class EmailVerification
    {
        public static void SendVerifyLinkEmail(Users user, string activationlink)
        {
            var fromEmail = new MailAddress("shaikhsaniya2604@gmail.com", "Notes Marketplace"); //need system email
            var toEmail = new MailAddress(user.EmailId);
            var fromEmailPassword = "Sahilkhan90326@"; // Replace with actual password
            string subject = "Notes Marketplace - Email Verification";
            string msg = "Hello " + user.FirstName + " " + user.LastName + "<br/>";
            msg += "<br/>Thank you for signing up with us.Please click on below link to verify your email address and to do login.<br/>";
            msg += "<a href='" + activationlink + "'> Click To VerifyEmail</a>";
            msg += "<br/><br/>Regards,<br/>";
            msg += "Notes Marketplace";

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