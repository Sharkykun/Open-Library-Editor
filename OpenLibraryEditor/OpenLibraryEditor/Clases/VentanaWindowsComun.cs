using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibraryEditor.Clases
{
    public static class VentanaWindowsComun
    {
        public const string FILTRO_IMAGEN = "PNG files (*.png)|*.png" +
                   "|JPG files (*.jpg)|*.jpg" +
                   "|BMP files (*.bmp)|*.bmp";
        public const string FILTRO_TODO = "All files (*.*)|*.*";

        public static DialogResult MensajeBorrarObjeto(string objetoNombre)
        {
            return MessageBox.Show("¿Quieres borrar "+objetoNombre+"?",
                "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public static DialogResult MensajeGuardarObjeto(string objetoNombre)
        {
            return MessageBox.Show("¿Quieres guardar " + objetoNombre + "?",
                "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public static DialogResult MensajeInformacion(string texto)
        {
            return MessageBox.Show(texto, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult MensajeError(string mensaje)
        {
            return MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static string GetRutaFichero(string filter)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = filter;
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    return openFileDialog.FileName;
                }
            }
            return "";
        }

        public static string GetRutaCarpeta()
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return diag.SelectedPath;
            }
            return "";
        }
    }
}
