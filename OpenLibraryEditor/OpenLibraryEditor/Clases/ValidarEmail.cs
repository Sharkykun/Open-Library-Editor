using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.Clases
{
    public class ValidarEmail
    {
        public int Send(string emisor, string password, string receptor)
        {
            Random rnd = new Random();
            int numero = rnd.Next(100000, 1000000);
            MailMessage msg = new MailMessage();
            msg.To.Add(receptor);
            msg.Subject = "Correo de verificación";
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = "Bienvenido a Open Library Editor.\nSu código de verificación es:" + numero + ".";
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.From = new MailAddress(emisor);
            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential(emisor, password);
            client.Port = 587;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            try
            {
                client.Send(msg);
            }
            catch (Exception)
            {
                VentanaWindowsComun.MensajeError("No se pudo enviar el correo");
            }
            return numero;
        }
    }
}
