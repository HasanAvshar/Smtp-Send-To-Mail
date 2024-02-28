using System;
using System.Net;
using System.Net.Mail;

Console.Write("Enter recipient email address: ");
string recipientEmail = Console.ReadLine();

Console.Write("Enter email subject: ");
string subject = Console.ReadLine();

Console.Write("Enter email body: ");
string body = Console.ReadLine();

SendMail(recipientEmail, subject, body);

void SendMail(string recipientEmail, string subject, string body)
{
    MailMessage message = new MailMessage();
    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
    smtpClient.Port = 587;
    smtpClient.UseDefaultCredentials = false;
    smtpClient.Credentials = new NetworkCredential("hesenavs1@gmail.com", "nyvc brqn ttec pbsv");
    smtpClient.EnableSsl = true;

    message.From = new MailAddress("hesenavs1@gmail.com");
    message.To.Add(new MailAddress(recipientEmail));
    message.Subject = subject;
    message.Body = body;

    smtpClient.Send(message);
}
