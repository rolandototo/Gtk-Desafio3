using System;
using System.Net;
using System.Net.Mail;

namespace Desafio3
{
    public class SendAlertEmail
    {
        public void Send()
        {

            string Emailorigen = "testcsharp001@gmail.com";
            string Emaildestino = "testcsharp001@gmail.com";
            string contraseña = "adminCsharp";
            //YWRtaW5Dc2hhcnA=
            string GetIP()
            {
                string strHostName = "";
                strHostName = System.Net.Dns.GetHostName();

                IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);

                IPAddress[] addr = ipEntry.AddressList;

                return addr[addr.Length - 1].ToString();

            }
            MailMessage mess = new MailMessage(Emailorigen, Emaildestino, "Se Ha Destectado Una Amenaza", "<p>Intento de sospechoso de ingreso en el programa el dia " + DateTime.Today.ToString("d") + " a las " + DateTime.Now.ToString("hh:mm:ss") + " con la ip: " + GetIP() + "<p>");

            mess.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(Emailorigen, contraseña);

            client.Send(mess);
            client.Dispose();

        }
    }
}
