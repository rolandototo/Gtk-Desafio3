using System;
using System.Net.Mail;
using System.Net;
namespace GtkDesafio3
{
    public class SendAlertEmail
    {
        public void Send()
        {

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("TestCsharp.90@gmail.com");
            mail.To.Add("to_address");
            mail.Subject = "Advertencia!";
            mail.Body = "Intento de sospechoso de ingreso en el programa el dia " + DateTime.Today.ToString("d") + " a las " + DateTime.Now.ToString("hh:mm:ss") + " con la ip: " + GetIP();

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
        private string GetIP()
        {
            string strHostName = "";
            strHostName = System.Net.Dns.GetHostName();

            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);

            IPAddress[] addr = ipEntry.AddressList;

            return addr[addr.Length - 1].ToString();

        }
    }
}
