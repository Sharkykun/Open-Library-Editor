using OpenLibraryEditor.BaseDatos;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.DatosLibros;
using OpenLibraryEditor.Metodos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenLibraryEditor.Forms
{
    public partial class FrmRegistro : Form
    {
        #region atributos
        private bool isOk;

        public bool IsOk { get => isOk; set => isOk = value; }
        #endregion
        #region constructor y load
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            IdiomaTexto();
            TxtUrlReg.Focus();
        }
        #endregion
        #region idioma
        private void IdiomaTexto()
        {
            TTRegistro.SetToolTip(this.PcbLogoRegistro, ControladorIdioma.GetTexto("Main_TTLogo"));
            LblTituloFrm.Text = ControladorIdioma.GetTexto("Reg_TituloForm");
            this.Text= ControladorIdioma.GetTexto("Reg_TituloForm");
            TTRegistro.SetToolTip(this.LblTituloFrm, ControladorIdioma.GetTexto("Reg_TituloForm"));
            LblUrlReg.Text = ControladorIdioma.GetTexto("Reg_Url");
            TTRegistro.SetToolTip(this.TxtUrlReg, ControladorIdioma.GetTexto("Reg_TTUrl"));
            LblNombreReg.Text = ControladorIdioma.GetTexto("Reg_Nombre");
            TTRegistro.SetToolTip(this.TxtNombreReg, ControladorIdioma.GetTexto("Reg_TTNombre"));
            LblMailReg.Text = ControladorIdioma.GetTexto("Reg_Email");
            TTRegistro.SetToolTip(this.TxtMailReg, ControladorIdioma.GetTexto("Reg_TTEmail"));
            LblContraReg.Text = ControladorIdioma.GetTexto("Reg_Contra");
            TTRegistro.SetToolTip(this.KTxtContraReg, ControladorIdioma.GetTexto("Reg_TTContra"));
            LblContra1Reg.Text = ControladorIdioma.GetTexto("Reg_Contra1");
            TTRegistro.SetToolTip(this.KTxtContra1Reg, ControladorIdioma.GetTexto("Reg_TTContra1"));
            GBtnRegistrarme.Text = ControladorIdioma.GetTexto("Reg_BtnRegistro");
            TTRegistro.SetToolTip(this.GBtnRegistrarme, ControladorIdioma.GetTexto("Reg_BtnRegistro"));
            TTRegistro.SetToolTip(this.IpcbMostrarContraReg, ControladorIdioma.GetTexto("Reg_TTMostrarContra"));
            TTRegistro.SetToolTip(this.IpcbOcultarContra1Reg, ControladorIdioma.GetTexto("Reg_TTMostrarContra"));
            TTRegistro.SetToolTip(this.IpcbOcultarContraReg, ControladorIdioma.GetTexto("Reg_TTOcultarContra"));
            TTRegistro.SetToolTip(this.IpcbOcultarContra1Reg, ControladorIdioma.GetTexto("Reg_TTOcultarContra"));
            TTRegistro.SetToolTip(this.MBtnCerrarRegistro, ControladorIdioma.GetTexto("Cerrar"));
        }
        #endregion
        #region mostrar/ocultar password
        private void IpcbMostrarContraReg_Click(object sender, EventArgs e)
        {
            MetodosComunes.MostrarOcultarContra(KTxtContraReg, true, false, IpcbOcultarContraReg, IpcbMostrarContraReg);
        }
        private void IpcbOcultarContraReg_Click(object sender, EventArgs e)
        {
            MetodosComunes.MostrarOcultarContra(KTxtContraReg, false, true, IpcbMostrarContraReg, IpcbOcultarContraReg);
        }
        private void IpcbMostrarContra1Reg_Click(object sender, EventArgs e)
        {
            MetodosComunes.MostrarOcultarContra(KTxtContra1Reg, true, false, IpcbOcultarContra1Reg, IpcbMostrarContra1Reg);
        }

        private void IpcbOcultarContra1Reg_Click(object sender, EventArgs e)
        {
            MetodosComunes.MostrarOcultarContra(KTxtContra1Reg,false,true,IpcbMostrarContra1Reg,IpcbOcultarContra1Reg);

        }
        #endregion
        #region registro
        int numero = 0;
        private void GBtnRegistrarme_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TxtUrlReg.Text) &&
                !String.IsNullOrWhiteSpace(TxtNombreReg.Text) &&
                !String.IsNullOrWhiteSpace(TxtMailReg.Text) &&
                !String.IsNullOrWhiteSpace(KTxtContra1Reg.Text) &&
                !String.IsNullOrWhiteSpace(KTxtContraReg.Text))
            {
                if (MetodosComunes.EsEmailValido(TxtMailReg.Text))
                {
                    if (KTxtContra1Reg.Text == KTxtContraReg.Text)
                    {
                        //Obtener puerto en la url, si se especifica
                        string[] s = TxtUrlReg.Text.Split(':');
                        string url = s[0];
                        string p = s.Length == 2 ? s[1] : "3306";
                        int puerto;
                        if (!int.TryParse(p, out puerto))
                            puerto = 3306;

                        ConexionBD.EstablecerConexion(url, "ole_register", "ole123Ole", puerto.ToString());
                        if (ConexionBD.AbrirConexion())
                        {
                            if (LecturaBD.SelectUsuarioCorreo(TxtMailReg.Text) == 0)
                            {
                                DialogResult result = DialogResult.No;
                                do
                                {
                                    EnvioEmail mail = new EnvioEmail();
                                    numero = mail.Send("openlibraryeditor@gmail.com", "bjsxjerndlfahkqe", TxtMailReg.Text);

                                    if (numero == 0)
                                    {
                                        VentanaWindowsComun.MensajePregunta(ControladorIdioma.GetTexto("VWC_ReenviarMail"));
                                    }
                                } while (result == DialogResult.Yes);
                                FrmVerificacionMail verificar = new FrmVerificacionMail(numero);
                                verificar.FormBorderStyle = FormBorderStyle.None;
                                verificar.ShowDialog();
                                if (verificar.MailVerificado)
                                {
                                    //Crear usuario con ole_register
                                    ConexionBD.CrearUsuarioComunBD(TxtNombreReg.Text, KTxtContraReg.Text, TxtNombreReg.Text);
                                    EscrituraBD.InsertUsuario(new InfoUsuarioBD(TxtNombreReg.Text,
                                            TxtMailReg.Text,
                                            "Usuario"), KTxtContraReg.Text);
                                    ConexionBD.CerrarConexion();

                                    //Iniciar sesion y menu principal
                                    ConexionBD.EstablecerConexion(url, ConexionBD.ANTENOMBRE_USUARIO_BD +
                                        TxtNombreReg.Text, KTxtContraReg.Text, puerto.ToString());
                                    if (ConexionBD.AbrirConexion())
                                    {
                                        ConexionBD.IdBD = LecturaBD.SelectObtenerIdBD();
                                        ConexionBD.CerrarConexion();
                                        FrmLogin.ObtenerInfoBD(TxtNombreReg.Text, TxtUrlReg.Text, puerto);
                                        FrmMenuPrincipal mainMenu = new FrmMenuPrincipal();
                                        mainMenu.Show();
                                        isOk = true;
                                        this.Close();
                                    }
                                    else
                                        VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorLogin"));
                                }
                            }
                            else
                                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("VWC_ErrorMail"));
                        }
                        else
                            VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexion"));
                        ConexionBD.CerrarConexion();
                    }
                    else
                        VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("Reg_ContraNoCoincide"));
                }
                else
                    VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("MailNoValido"));
            }
            else
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("Log_Error4"));
        }
#endregion
        #region cerrar
        private void MBtnCerrarRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region mover formulario
        //Para poder mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            //Para poder mover el formulario por la pantalla
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}

