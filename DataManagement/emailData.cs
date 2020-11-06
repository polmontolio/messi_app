using System;
using System.Net.Mail;

namespace DataManagement
{
    public class emailData
    {

        public void sendEmail(string toemail, string subject, string body)
        {

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("darkcorePK@gmail.com");
                mail.To.Add(toemail);
                mail.Subject = subject;
                mail.Body = body;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("darkcorePK@gmail.com", "darkcore12345aA");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
