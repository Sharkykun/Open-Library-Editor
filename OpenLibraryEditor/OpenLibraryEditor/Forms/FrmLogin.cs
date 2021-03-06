using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using FontAwesome;
using FontAwesome.Sharp;
using OpenLibraryEditor.BaseDatos;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.DatosLibros;
using OpenLibraryEditor.Metodos;

namespace OpenLibraryEditor.Forms
{
    public partial class FrmLogin : Form
    {
        #region atributos
        private int contador = 0;
        #endregion
        #region contructor y load, Cargar metodos iniciales
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Cargar configuración local.
            //Si no existe, cargar valores por defecto.
            UsuarioDatos.configuracionUsuario = UsuarioDatos.CargarJson();
            Biblioteca.biblioteca = Biblioteca.CargarJson();
            ControladorIdioma.idioma = UsuarioDatos.configuracionUsuario.IdiomaIntefaz;

            //Generar carpetas si no existen
            Directory.CreateDirectory(ControladorImagen.RUTA_LIBRO);
            Directory.CreateDirectory(ControladorImagen.RUTA_EDITORIAL);
            Directory.CreateDirectory(ControladorImagen.RUTA_PERSONA);

            TimerAparecer.Start();
            this.Opacity = 0.0;
            IdiomaTexto();
            RecordarUsuario();
        }
        #endregion
        #region aparecer formulario
        private void TimerAparecer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            contador += 1;
            if (contador == 50)
                TimerAparecer.Stop();
        }
        #endregion
        #region Metodos propios
        public static void ObtenerInfoBD(string nombreUsuario, string url, int puerto)
        {
            if (ConexionBD.AbrirConexion())
            {
                UsuarioDatos.configuracionUsuario.InfoUsuarioActual = LecturaBD.SelectUsuario(nombreUsuario);
                ConexionBD.CerrarConexion();
                UsuarioDatos.configuracionUsuario.BDActual = new InfoBaseDatos("Base de datos Actual",url,puerto);
                UsuarioDatos.configuracionUsuario.EsAdministrador = UsuarioDatos.configuracionUsuario.InfoUsuarioActual.TipoUsuario == "Administrador";
            }
        }
        private void RecordarUsuario()
        {
            if (!String.IsNullOrWhiteSpace(UsuarioDatos.configuracionUsuario.RecordarUrl))
            {
                KTxtUrl.Text = UsuarioDatos.configuracionUsuario.RecordarUrl;
                KTxtNombre.Text = UsuarioDatos.configuracionUsuario.RecordarUsuario;
                KTxtContra.Text = UsuarioDatos.configuracionUsuario.RecordarContr;
                IpcbOcultarContra_Click(null, null);
                KTxtNombre.StateCommon.Content.Color1 = Color.Black;
                KTxtContra.StateCommon.Content.Color1 = Color.Black;
                KTxtUrl.StateCommon.Content.Color1 = Color.Black;
                ToggleConectado.Checked = true;
            }
            else
                Reset(KTxtUrl, KTxtNombre, KTxtContra);
        }

        //Método para cambiar el idioma de la aplicación
        private void IdiomaTexto()
        {
            TTLogin.SetToolTip(this.PcbLogo, ControladorIdioma.GetTexto("Log_TTLogo"));
            this.Text=ControladorIdioma.GetTexto("Login");
            BtnSpain.Text = ControladorIdioma.GetTexto("Log_BtnSpain");
            BtnUsa.Text = ControladorIdioma.GetTexto("Log_BtnUSA");
            BtnFrancia.Text = ControladorIdioma.GetTexto("Log_BtnFrancia");
            KTxtUrl.Text = ControladorIdioma.GetTexto("Log_Url");
            TTLogin.SetToolTip(this.KTxtUrl, ControladorIdioma.GetTexto("Log_TTUrl"));
            KTxtNombre.Text = ControladorIdioma.GetTexto("Log_Nombre");
            TTLogin.SetToolTip(this.KTxtNombre, ControladorIdioma.GetTexto("Log_TTNombre"));
            KTxtContra.Text = ControladorIdioma.GetTexto("Log_Contra");
            TTLogin.SetToolTip(this.KTxtContra, ControladorIdioma.GetTexto("Log_TTContra"));
            LblSesionIniciada.Text = ControladorIdioma.GetTexto("Log_LblConectado");
            TTLogin.SetToolTip(this.ToggleConectado, ControladorIdioma.GetTexto("Log_TTSesion"));
            LlblRecuperar.Text = ControladorIdioma.GetTexto("Log_LlRecuperar");
            TTLogin.SetToolTip(this.LlblRecuperar, ControladorIdioma.GetTexto("Log_TTOlvidado"));
            GBtnRegistro.Text = ControladorIdioma.GetTexto("Log_BtnRegistrarse");
            TTLogin.SetToolTip(this.GBtnRegistro, ControladorIdioma.GetTexto("Log_BtnRegistrarse"));
            GBtnEntrar.Text = ControladorIdioma.GetTexto("Log_BtnEntrar");
            TTLogin.SetToolTip(this.GBtnEntrar, ControladorIdioma.GetTexto("Log_BtnEntrar"));
            GBtnSinConexion.Text = ControladorIdioma.GetTexto("Log_BtnInvitado");
            TTLogin.SetToolTip(this.GBtnSinConexion, ControladorIdioma.GetTexto("Log_BtnInvitado"));
            GBtnCrearBD.Text = ControladorIdioma.GetTexto("Log_BtnCrearBD");
            TTLogin.SetToolTip(this.GBtnCrearBD, ControladorIdioma.GetTexto("Log_BtnTTCrearBD"));
            TTLogin.SetToolTip(this.IpcbMostrarContra, ControladorIdioma.GetTexto("Reg_TTMostrarContra"));
            TTLogin.SetToolTip(this.IpcbOcultarContra, ControladorIdioma.GetTexto("Reg_TTOcultarContra"));
            TTLogin.SetToolTip(this.MBtnCerrarLogin, ControladorIdioma.GetTexto("Main_Salir"));
        }
        

        private void MostrarMainEntrar(KryptonTextBox text1, KryptonTextBox text2, KryptonTextBox text3, string s1, string s2, string s3,
          string e1, string e2, string e3, string e4)
        {
            if (text1.Text != s1)
            {
                if (text2.Text != s2)
                {
                    if (text3.Text != s3)
                    {
                        //UsuarioDatos.configuracionUsuario.BDActual;
                        //ClaseDatosUsuario user = new ClaseDatosUsuario();
                        //var validLogin = user.Metodo(TxtUrlDataBase.Text, TxtUserStart.Text, TxtPassStart.Text);
                        //if (validLogin == true)
                        //{
                        //    FrmMainMenu mainMenu = new FrmMainMenu();
                        //    mainMenu.Show();
                        //    this.Hide();
                        //}
                        ////para probarlo
                        //if (KTxtUrl.Text.Equals("Hola") && KTxtNombre.Text.Equals("Yolanda") && KTxtContra.Text.Equals("Yolanda"))
                        //{
                        //    FrmMenuPrincipal mainMenu = new FrmMenuPrincipal();
                        //    mainMenu.Show();
                        //    this.Hide();
                        //}
                        //else
                        //{
                        //    MsgError(e1);
                        //    KTxtNombre.Clear();
                        //    KTxtContra.Clear();
                        //}
                    }
                    else
                        MsgError(e2);
                }
                else
                    MsgError(e3);
            }
            else
                MsgError(e4);
        }
        private void MsgError(string msg)
        {
            LblError.Text = "     " + msg;
            LblError.Visible = true;
        }
       
        #endregion
        #region Mostrar/Ocultar password
        private void IpcbOcultarContra_Click(object sender, EventArgs e)
        {
            MetodosComunes.MostrarOcultarContra(KTxtContra, false, true, IpcbMostrarContra, IpcbOcultarContra);
        }

        private void IpcbMostrarContra_Click(object sender, EventArgs e)
        {
            MetodosComunes.MostrarOcultarContra(KTxtContra,true,false,IpcbOcultarContra, IpcbMostrarContra);
        }
        #endregion
        #region PlaceHolder KryptonTextBox
        //Quitar el placeHolder de los KryptonTextBox al entrar en ellos
        private void PlaceholderOff(KryptonTextBox txt, string s)
        {
            txt.StateCommon.Back.Color1 = Color.WhiteSmoke;

            if (txt.Text == s ||
                !String.IsNullOrWhiteSpace(UsuarioDatos.configuracionUsuario.RecordarUrl))
            {
                if (txt.Text == s)
                    txt.Text = "";
                txt.StateCommon.Content.Color1 = Color.Black;
            }
        }
        //Quitar el placeHolder de los KryptonTextBox de contraseña al entrar en el
        private void PlaceholderContraOff(KryptonTextBox txt, string s)
        {
            txt.StateCommon.Back.Color1 = Color.WhiteSmoke;
            IpcbMostrarContra.BackColor = Color.WhiteSmoke;
            IpcbOcultarContra.BackColor = Color.WhiteSmoke;
            if (txt.Text == s ||
                !String.IsNullOrWhiteSpace(UsuarioDatos.configuracionUsuario.RecordarUrl))
            {
                if (txt.Text == s)
                    txt.Text = "";
                txt.StateCommon.Content.Color1 = Color.Black;
                txt.UseSystemPasswordChar = true;
            }
        }

        //Volver a poner el placeholder al salir del control
        private void PlaceholderOn(KryptonTextBox txt, string s)
        {
            txt.StateCommon.Back.Color1 = Color.Gainsboro;
            IpcbMostrarContra.BackColor = Color.Gainsboro;
            IpcbOcultarContra.BackColor = Color.Gainsboro;
            if (txt.Text == "")
            {
                txt.Text = s;
                txt.StateCommon.Content.Color1 = Color.DimGray;
                txt.UseSystemPasswordChar = false;
            }
        }
        private void Reset(KryptonTextBox txt1, KryptonTextBox txt2, KryptonTextBox txt3)
        {
            PlaceholderOn(txt1, ControladorIdioma.GetTexto("Log_Url"));
            PlaceholderOn(txt2, ControladorIdioma.GetTexto("Log_Nombre"));
            PlaceholderOn(txt3, ControladorIdioma.GetTexto("Log_Contra"));
            txt3.UseSystemPasswordChar = false;
            txt1.StateCommon.Content.Color1 = Color.DimGray;
            txt2.StateCommon.Content.Color1 = Color.DimGray;
            txt3.StateCommon.Content.Color1 = Color.DimGray;
            LlblRecuperar.Focus();
        }
        private void KTxtUrl_Enter(object sender, EventArgs e)
        {
            PlaceholderOff(KTxtUrl, ControladorIdioma.GetTexto("Log_Url"));
        }

        private void KTxtUrl_Leave(object sender, EventArgs e)
        {
            PlaceholderOn(KTxtUrl, ControladorIdioma.GetTexto("Log_Url"));
        }
        private void KTxtNombre_Enter(object sender, EventArgs e)
        {
            PlaceholderOff(KTxtNombre, ControladorIdioma.GetTexto("Log_Nombre"));
        }

        private void KTxtNombre_Leave(object sender, EventArgs e)
        {
            PlaceholderOn(KTxtNombre, ControladorIdioma.GetTexto("Log_Nombre"));
        }

        private void KTxtContra_Enter(object sender, EventArgs e)
        {
            PlaceholderContraOff(KTxtContra, ControladorIdioma.GetTexto("Log_Contra"));
        }

        private void KTxtContra_Leave(object sender, EventArgs e)
        {
            PlaceholderOn(KTxtContra, ControladorIdioma.GetTexto("Log_Contra"));
        }
        #endregion
        #region botones 
        private void GBtnRegistro_Click(object sender, EventArgs e)
        {
            FrmRegistro registro = new FrmRegistro();
            registro.ShowDialog();
            if (registro.IsOk)
            {
                this.Hide();
            }
        }
        private void GBtnEntrar_Click(object sender, EventArgs e)
        {
            //MostrarMainEntrar(KTxtUrl, KTxtNombre, KTxtContra, ControladorIdioma.GetTexto("Log_Url"),
            //       ControladorIdioma.GetTexto("Log_Nombre"), ControladorIdioma.GetTexto("Log_Contra"), ControladorIdioma.GetTexto("Log_Error1"),
            //       ControladorIdioma.GetTexto("Log_Error2"), ControladorIdioma.GetTexto("Log_Error3"), ControladorIdioma.GetTexto("Log_Error4"));
            
            //Obtener puerto en la url, si se especifica
            string[] s = KTxtUrl.Text.Split(':');
            string url = s[0];
            string p = s.Length == 2 ? s[1] : "3306";
            int puerto;
            if (!int.TryParse(p, out puerto))
                puerto = 3306;

            ConexionBD.EstablecerConexion(url, 
                ConexionBD.ANTENOMBRE_USUARIO_BD + KTxtNombre.Text,
                KTxtContra.Text, puerto.ToString());
            if (ConexionBD.AbrirConexion())
            {
                ConexionBD.IdBD = LecturaBD.SelectObtenerIdBD();
                ConexionBD.CerrarConexion();
                ObtenerInfoBD(KTxtNombre.Text, KTxtUrl.Text, puerto);
                if (ToggleConectado.Checked)
                {
                    UsuarioDatos.configuracionUsuario.RecordarUrl = KTxtUrl.Text;
                    UsuarioDatos.configuracionUsuario.RecordarUsuario = KTxtNombre.Text;
                    UsuarioDatos.configuracionUsuario.RecordarContr = KTxtContra.Text;
                    UsuarioDatos.configuracionUsuario.GuardarJson();
                }
                else
                {
                    UsuarioDatos.configuracionUsuario.RecordarUrl = "";
                    UsuarioDatos.configuracionUsuario.RecordarUsuario = "";
                    UsuarioDatos.configuracionUsuario.RecordarContr = "";
                    UsuarioDatos.configuracionUsuario.GuardarJson();
                }
                FrmMenuPrincipal mainMenu = new FrmMenuPrincipal();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                VentanaWindowsComun.MensajeError(ControladorIdioma.GetTexto("ErrorConexion"));
                ConexionBD.Conexion = null;
            }
        }

        private void GBtnSinConexion_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();
            menu.Show();
            this.Hide();
        }
        private void GBtnCrearBD_Click(object sender, EventArgs e)
        {
            FrmCrearBD bd=new FrmCrearBD();
            bd.FormBorderStyle=FormBorderStyle.None;
            bd.ShowDialog();
            if (bd.IsOk)
            {
                bd.Close();
                //Entrar a la app con las credenciales especificadas antes
                FrmMenuPrincipal menu = new FrmMenuPrincipal();
                menu.Show();
                this.Hide();
            }
        }

        private void LlblRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRecuperarContra recuperar = new FrmRecuperarContra();
            recuperar.FormBorderStyle = FormBorderStyle.None;
            recuperar.ShowDialog();
        }
        #endregion
        #region Cambiar idioma
        private void BtnSpain_Click(object sender, EventArgs e)
        {
            UsuarioDatos.configuracionUsuario.IdiomaIntefaz = "Strings_es_ES";
            UsuarioDatos.configuracionUsuario.GuardarJson();
            ControladorIdioma.idioma = "Strings_es_ES";
            IdiomaTexto();
            RecordarUsuario();
        }
        private void BtnUsa_Click(object sender, EventArgs e)
        {
            UsuarioDatos.configuracionUsuario.IdiomaIntefaz = "Strings_en_US";
            UsuarioDatos.configuracionUsuario.GuardarJson();
            ControladorIdioma.idioma = "Strings_en_US";
            IdiomaTexto();
            RecordarUsuario();
        }
        private void BtnFrancia_Click(object sender, EventArgs e)
        {
            UsuarioDatos.configuracionUsuario.IdiomaIntefaz = "Strings_fr_FR";
            UsuarioDatos.configuracionUsuario.GuardarJson();
            ControladorIdioma.idioma = "Strings_fr_FR";
            IdiomaTexto();
            RecordarUsuario();
        }
        #endregion
        #region cerrar
        private void MBtnCerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        private void ToggleConectado_CheckedChanged(object sender, EventArgs e)
        {
            //if (ToggleConectado.Checked)
            //{
            //    RecordarUsuario();
            //}
            //else
            //{
            //    //IdiomaTexto();
            //    UsuarioDatos.configuracionUsuario.RecordarUrl = "";
            //    UsuarioDatos.configuracionUsuario.RecordarUsuario = "";
            //    UsuarioDatos.configuracionUsuario.RecordarContr = "";
            //    Reset(KTxtUrl, KTxtNombre, KTxtContra);
            //}
            
        }

        #region Mover formulario por la pantalla

        //Para poder mover el formulario por la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            //Para poder mover el formulario por la pantalla
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}

