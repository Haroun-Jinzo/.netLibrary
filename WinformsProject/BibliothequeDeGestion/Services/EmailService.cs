using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

public class EmailService
{
    public void SendLateEmail(string toEmail, string bookTitle)
    {
        var smtp = new SmtpClient("smtp.gmail.com", 587)
        {
            Credentials = new NetworkCredential("votreemail@gmail.com", "motdepasse"),
            EnableSsl = true
        };

        smtp.Send(
            from: "bibliotheque@example.com",
            recipients: toEmail,
            subject: "Retard de livre",
            body: $"Veuillez retourner le livre: {bookTitle}"
        );
    }
}
