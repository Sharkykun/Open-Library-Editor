using ComponentFactory.Krypton.Toolkit;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibraryEditor.Metodos
{
    public class MetodosComunes
    {
        public static void MostrarOcultarContra(KryptonTextBox txt, bool bTrue, bool bFalse, IconPictureBox ipcbS, IconPictureBox ipcbH)
        {
            if (txt.UseSystemPasswordChar == bTrue)
            {
                txt.UseSystemPasswordChar = bFalse;
                txt.PasswordChar = '\0';
                ipcbH.Hide();
                ipcbS.Show();
            }
            else
                txt.PasswordChar = '●';
        }
        /*
         Código sacado de:https://docs.microsoft.com/es-es/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
         */
        public static bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
       


