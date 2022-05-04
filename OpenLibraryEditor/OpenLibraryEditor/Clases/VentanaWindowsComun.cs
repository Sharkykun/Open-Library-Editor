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
            return MiMessageBox.Show(ControladorIdioma.GetTexto("VWC_Borrar") +" "+ objetoNombre+"?",
                ControladorIdioma.GetTexto("VWC_Advertencia"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public static DialogResult MensajeGuardarObjeto(string objetoNombre)
        {
            return MiMessageBox.Show(ControladorIdioma.GetTexto("VWC_Guardar") +" "+ objetoNombre + "?",
                ControladorIdioma.GetTexto("VWC_Pregunta"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static DialogResult MensajeInformacion(string texto)
        {
            return MiMessageBox.Show(texto, ControladorIdioma.GetTexto("VWC_Informacion"), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult MensajeError(string mensaje)
        {
            return MiMessageBox.Show(mensaje, ControladorIdioma.GetTexto("VWC_Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult MensajeSalir(string mensaje)
        {
            return MiMessageBox.Show(mensaje, ControladorIdioma.GetTexto("VWC_Pregunta"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            if (diag.ShowDialog() == DialogResult.OK)
            {
                return diag.SelectedPath;
            }
            return "";
        }
    }
}
