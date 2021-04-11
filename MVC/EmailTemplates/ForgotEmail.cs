using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using NoteMarketPlace.Models;

namespace NoteMarketPlace.EmailTemplates
{
    public class ForgotEmail
    {

        public static void SendOtpToEmail(Users u, string  otp)
        {
            var fromEmail = new MailAddress("shaikhsaniya2604@gmail.com", "Notes Marketplace"); //need system email
            var toEmail = new MailAddress(u.EmailId);
            var fromEmailPassword = "Sahilkhan90326@"; // Replace with actual password
            string subject = "New Temporary password has been created for you";
            string msg = "Hello,<br/>";
            msg += "We have generated a new password for you. <br/>";
            msg += "Password: " + otp;
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