using System;
using System.Net;
using System.Net.Mail;

public class sendEmail
{
    public static bool Send(string to, string subject, string body)
    {
        try
        {
            MailMessage message = new MailMessage("DarkCode.ir@gmail.com", to);
            message.Body = body;
            message.Subject = subject;
            message.IsBodyHtml = true;
            NetworkCredential mailAuthentication = new NetworkCredential("DarkCode.ir@gmail.com", "0480902542");
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
            mailClient.EnableSsl = true;
            mailClient.UseDefaultCredentials = false;
            mailClient.Credentials = mailAuthentication;
            mailClient.Send(message);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    //public static void sendsms(string to, string Message)
    //{
    //    var sender = "1000596446";
    //    var receptor = to;
    //    var message = Message;
    //    var api = new Kavenegar.KavenegarApi("4D317A62644B6F367A4F4D78316C7669696B6B68767175314854525032314C63766B4E4F33514E7868526B3D");
    //    api.Send(sender, receptor, message);
    //}

}