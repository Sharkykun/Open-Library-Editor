using OpenLibraryEditor.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.Clases
{
    public class EnvioEmail
    {

        public int Send(string emisor, string password, string receptor)
        {
            Random rnd = new Random();
            int numero = rnd.Next(100000, 1000000);
            MailMessage msg = new MailMessage();
            msg.To.Add(receptor);
            msg.Subject = ControladorIdioma.GetTexto("Mail_Subject");
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = "<html lang='es' xmlns='http://www.w3.org/1999/xhtml'>" +
                "<head>" +
                    "<meta http-equiv='Content-Type' content='text/html; charset=UTF-8'/>" +
                    "<meta http-equiv='X-UA-Compatible' content='IE=edge'>" +
                    "<meta name='viewport' content='width=device-width, initial-scale=1.0'>" +
                    "<title>" + ControladorIdioma.GetTexto("Main_TTFormTitulo") + "</title>" +
                "</head>" +
                "<body style='margin: 0; background-color: #040564;'>" +
                    "<center class='wrapper' style='width: 100%; table-layout:fixed; background-color: #040564;'>" +
                        "<table class='main' width='100%' style='border-spacing:0; background-color: #E7F3FE; margin: 0 auto; width: 100%; max-width: 600px; font-family: sans-serif;font-size: medium; color: #040564;'>" +
                            "<tr><td height='12' style='background-color:#89CDFA; padding: 0;'></td></tr>" +
                            "<tr>" +
                                "<td style='padding: 0;'>" +
                                    "<table width='100%' style='border-spacing:0;'>" +
                                        "<tr>" +
                                            "<td class='dosColumnas' style='padding: 0; text-align: center;'>" +
                                                "<table class='columna' style='border-spacing:0; display: inline-block; vertical-align: middle;'>" +
                                                    "<tr><td style='padding: 0;'><img src='cid:LogoID' alt='Logo' width='150' title='Logo' style='border: 0; margin: 10px;'></td></tr>" +
                                                "</table>" +
                                                "<table class='columna' style='border-spacing:0; display: inline-block; vertical-align: middle;'>" +
                                                    "<tr><td style='padding: 0;'>" +
                                                        "<h2 style='text-align: center; color:#040564;'>" + ControladorIdioma.GetTexto("Mail_Bienvenido") + "</h2>" +
                                                        "<h1 style='color: #000096; font-weight: bold;'>" + ControladorIdioma.GetTexto("Main_TTFormTitulo") + "</h1></td></tr>" +
                                                "</table>" +
                                             "</td>" +
                                         "</tr>" +
                                    "</table>" +
                                "</td>" +
                            "</tr>" +
                            "<tr><td height='12' style='background-color:#89CDFA; padding: 0;'></td></tr>" +
                            "<tr>" +
                                "<td style='padding: 0;'>" +
                                    "<table width='100%' style='border-spacing:0;'>" +
                                        "<tr>" +
                                            "<td style='padding: 0;'>" +
                                                "<h3 style='text-align: center; color:#000096 ;'>" + ControladorIdioma.GetTexto("Mail_Body") + "</h3>" +
                                                "<p style= 'text-align: center; font-weight: bold;'>" + numero + "</p>" +
                                            "</td>" +
                                        "</tr>" +
                                    "</table>" +
                                "</td>" +
                            "</tr>" +
                            "<tr>" +
                                "<td style='padding: 0;'>" +
                                    "<table width='100%' style='border-spacing:0;'>" +
                                        "<tr>" +
                                            "<td class='pie' style='background-color: #89CDFA; padding: 0;'>" +                                              
                                                "<p style='text-align: center; font-weight: bold; font-size:14px' margin:5px>" + ControladorIdioma.GetTexto("Mail_foot") + "</p>"+
                                            "</td>" +
                                        "</tr>" +
                                    "</table>" +
                                "</td>" +
                            "</tr>" +
                        "</table>" +
                    "</center>" +
                "</body>" +
            "</html>";

            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(msg.Body, null, "text/html");

            //Add Image
            LinkedResource emailImage = new LinkedResource("LogoFinalSmall.png");
            emailImage.ContentId = "LogoID";

            //Add the Image to the Alternate view
            htmlView.LinkedResources.Add(emailImage);

            //Add view to the Email Message
            msg.AlternateViews.Add(htmlView);
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
                VentanaWindowsComun.MensajeError("Mail_Error");
            }
            return numero;
        }

        public static void RegistrarUsuario(string emisor, string password, string receptor, string nombreUsu, string contraUsu, string tipoUsu, string personaRegistradora)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(receptor);
            msg.Subject = personaRegistradora+ControladorIdioma.GetTexto("Mail_PerRegistradora");
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = "<html lang='es' xmlns='http://www.w3.org/1999/xhtml'>" +
                "<head>" +
                    "<meta http-equiv='Content-Type' content='text/html; charset=UTF-8'/>" +
                    "<meta http-equiv='X-UA-Compatible' content='IE=edge'>" +
                    "<meta name='viewport' content='width=device-width, initial-scale=1.0'>" +
                    "<title>" + ControladorIdioma.GetTexto("Main_TTFormTitulo") + "</title>" +
                "</head>" +
                "<body style='margin: 0; background-color: #040564;'>" +
                    "<center class='wrapper' style='width: 100%; table-layout:fixed; background-color: #040564;'>" +
                        "<table class='main' width='100%' style='border-spacing:0; background-color: #E7F3FE; margin: 0 auto; width: 100%; max-width: 600px; font-family: sans-serif;font-size: medium; color: #040564;'>" +
                            "<tr><td height='12' style='background-color:#89CDFA; padding: 0;'></td></tr>" +
                            "<tr>" +
                                "<td style='padding: 0;'>" +
                                    "<table width='100%' style='border-spacing:0;'>" +
                                        "<tr>" +
                                            "<td class='dosColumnas' style='padding: 0; text-align: center;'>" +
                                                "<table class='columna' style='border-spacing:0; display: inline-block; vertical-align: middle;'>" +
                                                    "<tr><td style='padding: 0;'><img src='cid:LogoID' alt='Logo' width='150' title='Logo' style='border: 0; margin: 10px;'></td></tr>" +
                                                "</table>" +
                                                "<table class='columna' style='border-spacing:0; display: inline-block; vertical-align: middle;'>" +
                                                    "<tr><td style='padding: 0;'>" +
                                                        "<h2 style='text-align: center; color:#040564;'>" + ControladorIdioma.GetTexto("Mail_Bienvenido") + "</h2>" +
                                                        "<h1 style='color: #000096; font-weight: bold;'>" + ControladorIdioma.GetTexto("Main_TTFormTitulo") + "</h1></td></tr>" +
                                                "</table>" +
                                             "</td>" +
                                         "</tr>" +
                                    "</table>" +
                                "</td>" +
                            "</tr>" +
                            "<tr><td height='12' style='background-color:#89CDFA; padding: 0;'></td></tr>" +
                            "<tr>" +
                                "<td style='padding: 0;'>" +
                                    "<table width='100%' style='border-spacing:0;'>" +
                                        "<tr>" +
                                            "<td style='padding: 0;'>" +
                                                "<h3 style='text-align: center; color:#000096 ;'>" + ControladorIdioma.GetTexto("Mail_DatosAcceso") + "</h3>" +
                                                "<p style= 'text-align: center;'>"+ControladorIdioma.GetTexto("Adm_NombreUsu") +"<strong>"+ nombreUsu + "</strong></p>" +
                                                "<p style= 'text-align: center;'>" + ControladorIdioma.GetTexto("Reg_Contra") + "<strong>" + contraUsu + "</strong></p>" +
                                                "<p style= 'text-align: center;'>" + ControladorIdioma.GetTexto("Adm_Tipo") + "<strong>" + tipoUsu + "</strong></p>" +
                                                "<p style= 'text-align: center; font-size:12px;'>" + ControladorIdioma.GetTexto("Mail_CambieContra") + "</p>" +
                                            "</td>" +
                                        "</tr>" +
                                    "</table>" +
                                "</td>" +
                            "</tr>" +
                            "<tr>" +
                                "<td style='padding: 0;'>" +
                                    "<table width='100%' style='border-spacing:0;'>" +
                                        "<tr>" +
                                            "<td class='pie' style='background-color: #89CDFA; padding: 0;'>" +
                                                "<p style='text-align: center; font-weight: bold; font-size:14px' margin:5px>" + ControladorIdioma.GetTexto("Mail_foot") + "</p>" +
                                            "</td>" +
                                        "</tr>" +
                                    "</table>" +
                                "</td>" +
                            "</tr>" +
                        "</table>" +
                    "</center>" +
                "</body>" +
            "</html>";

            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(msg.Body, null, "text/html");

            //Add Image
            LinkedResource emailImage = new LinkedResource("LogoFinalSmall.png");
            emailImage.ContentId = "LogoID";

            //Add the Image to the Alternate view
            htmlView.LinkedResources.Add(emailImage);

            //Add view to the Email Message
            msg.AlternateViews.Add(htmlView);
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
                VentanaWindowsComun.MensajeError("Mail_Error");
            }
        }
        public static void RecuperarPassword(string emisor, string password, string receptor, string contraNueva, string nombreUsuario)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(receptor);
            msg.Subject = ControladorIdioma.GetTexto("Mail_Recuperar");
            msg.SubjectEncoding = Encoding.UTF8;
            msg.Body = "<html lang='es' xmlns='http://www.w3.org/1999/xhtml'>" +
                "<head>" +
                    "<meta http-equiv='Content-Type' content='text/html; charset=UTF-8'/>" +
                    "<meta http-equiv='X-UA-Compatible' content='IE=edge'>" +
                    "<meta name='viewport' content='width=device-width, initial-scale=1.0'>" +
                    "<title>" + ControladorIdioma.GetTexto("Main_TTFormTitulo") + "</title>" +
                "</head>" +
                "<body style='margin: 0; background-color: #040564;'>" +
                    "<center class='wrapper' style='width: 100%; table-layout:fixed; background-color: #040564;'>" +
                        "<table class='main' width='100%' style='border-spacing:0; background-color: #E7F3FE; margin: 0 auto; width: 100%; max-width: 600px; font-family: sans-serif;font-size: medium; color: #040564;'>" +
                            "<tr><td height='12' style='background-color:#89CDFA; padding: 0;'></td></tr>" +
                            "<tr>" +
                                "<td style='padding: 0;'>" +
                                    "<table width='100%' style='border-spacing:0;'>" +
                                        "<tr>" +
                                            "<td class='dosColumnas' style='padding: 0; text-align: center;'>" +
                                                "<table class='columna' style='border-spacing:0; display: inline-block; vertical-align: middle;'>" +
                                                    "<tr><td style='padding: 0;'><img src='cid:LogoID' alt='Logo' width='150' title='Logo' style='border: 0; margin: 10px;'></td></tr>" +
                                                "</table>" +
                                                "<table class='columna' style='border-spacing:0; display: inline-block; vertical-align: middle;'>" +
                                                    "<tr><td style='padding: 0;'>" +
                                                        "<h2 style='text-align: center; color:#040564;'>" + ControladorIdioma.GetTexto("Mail_saludo") +"</h2>" +
                                                        "<h1 style='color: #000096; font-weight: bold;'>" + nombreUsuario+ "</h1></td></tr>" +
                                                "</table>" +
                                             "</td>" +
                                         "</tr>" +
                                    "</table>" +
                                "</td>" +
                            "</tr>" +
                            "<tr><td height='12' style='background-color:#89CDFA; padding: 0;'></td></tr>" +
                            "<tr>" +
                                "<td style='padding: 0;'>" +
                                    "<table width='100%' style='border-spacing:0;'>" +
                                        "<tr>" +
                                            "<td style='padding: 0;'>" +
                                                "<h3 style='text-align: center; color:#000096 ;'>" + ControladorIdioma.GetTexto("Mail_NuevaContra") + "</h3>" +
                                                "<p style= 'text-align: center;'><strong>" + contraNueva + "</strong></p>" +
                                                "<p style= 'text-align: center; font-size:12px;'>" + ControladorIdioma.GetTexto("Mail_CambieContra") + "</p>" +
                                            "</td>" +
                                        "</tr>" +
                                    "</table>" +
                                "</td>" +
                            "</tr>" +
                            "<tr>" +
                                "<td style='padding: 0;'>" +
                                    "<table width='100%' style='border-spacing:0;'>" +
                                        "<tr>" +
                                            "<td class='pie' style='background-color: #89CDFA; padding: 0;'>" +
                                                "<p style='text-align: center; font-weight: bold; font-size:14px' margin:5px>" + ControladorIdioma.GetTexto("Mail_foot") + "</p>" +
                                            "</td>" +
                                        "</tr>" +
                                    "</table>" +
                                "</td>" +
                            "</tr>" +
                        "</table>" +
                    "</center>" +
                "</body>" +
            "</html>";

            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(msg.Body, null, "text/html");

            //Add Image
            LinkedResource emailImage = new LinkedResource("LogoFinalSmall.png");
            emailImage.ContentId = "LogoID";

            //Add the Image to the Alternate view
            htmlView.LinkedResources.Add(emailImage);

            //Add view to the Email Message
            msg.AlternateViews.Add(htmlView);
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
                VentanaWindowsComun.MensajeError("Mail_Error");
            }
        }
    }
}
