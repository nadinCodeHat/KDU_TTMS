using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace KDU_Time_Table_Management_System
{
    internal class Email
    {
        //private static void Main()
        //{
        //    Execute().Wait();
        //}

        static async Task Execute()
        {
            var apiKey = Environment.GetEnvironmentVariable("SENDGRID_API_KEY");
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("36-ce-002@kdu.ac.lk", "AMRNVB Pethiyagoda");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("36-se-0002@kdu.ac.lk", "NS Madushanka");
            var plainTextContent = "and easy to do anywhere, even with C#";
            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
