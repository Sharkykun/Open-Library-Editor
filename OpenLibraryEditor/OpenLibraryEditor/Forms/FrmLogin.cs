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
using ComponentFactory.Krypton.Toolkit;
using FontAwesome;
using FontAwesome.Sharp;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.DatosLibros;
using OpenLibraryEditor.Metodos;

namespace OpenLibraryEditor.Forms
{
    public partial class FrmLogin : Form
    {
        private int contador = 0;
        
        public FrmLogin()
        {
            InitializeComponent();
        }
        #region Cargar metodos iniciales
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //Cargar configuración local.
            //Si no existe, cargar valores por defecto.
            UsuarioDatos.configuracionUsuario = UsuarioDatos.CargarJson();
            ControladorIdioma.idioma = UsuarioDatos.configuracionUsuario.IdiomaIntefaz;

            TimerAparecer.Start();
            this.Opacity = 0.0;
            IdiomaTexto();
        }
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
       
        #region Metodos propios
        //Método para cambiar el idioma de la aplicación
        private void IdiomaTexto()
        {
            TTLogin.SetToolTip(this.PcbLogo, ControladorIdioma.GetTexto("Log_TTLogo"));
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
            BtnRegistrarse.Text = ControladorIdioma.GetTexto("Log_BtnRegistrarse");
            TTLogin.SetToolTip(this.BtnRegistrarse, ControladorIdioma.GetTexto("Log_BtnRegistrarse"));
            BtnEntrar.Text = ControladorIdioma.GetTexto("Log_BtnEntrar");
            TTLogin.SetToolTip(this.BtnEntrar, ControladorIdioma.GetTexto("Log_BtnEntrar"));
            BtnInvitado.Text = ControladorIdioma.GetTexto("Log_BtnInvitado");
            TTLogin.SetToolTip(this.BtnInvitado, ControladorIdioma.GetTexto("Log_BtnInvitado"));
            TTLogin.SetToolTip(this.IpcbMostrarContra, ControladorIdioma.GetTexto("Reg_TTMostrarContra"));
            TTLogin.SetToolTip(this.IpcbOcultarContra, ControladorIdioma.GetTexto("Reg_TTOcultarContra"));
            TTLogin.SetToolTip(this.MBtnCerrarLogin, ControladorIdioma.GetTexto("Main_Salir"));
        }
        //Quitar el placeHolder de los KryptonTextBox al entrar en ellos
        private void PlaceholderOff(KryptonTextBox txt, string s)
        {
            txt.StateCommon.Back.Color1 = Color.WhiteSmoke;

            if (txt.Text == s)
            {
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
            if (txt.Text == s)
            {
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
        private void MostrarMainEntrar(KryptonTextBox text1, KryptonTextBox text2, KryptonTextBox text3, string s1, string s2, string s3,
          string e1, string e2, string e3, string e4)
        {
            if (text1.Text != s1)
            {
                if (text2.Text != s2)
                {
                    if (text3.Text != s3)
                    {
                        //ClaseDatosUsuario user = new ClaseDatosUsuario();
                        //var validLogin = user.Metodo(TxtUrlDataBase.Text, TxtUserStart.Text, TxtPassStart.Text);
                        //if (validLogin == true)
                        //{
                        //    FrmMainMenu mainMenu = new FrmMainMenu("spanish");
                        //    mainMenu.Show();
                        //    this.Hide();
                        //}
                        //para probarlo
                        if (KTxtUrl.Text.Equals("Hola") && KTxtNombre.Text.Equals("Yolanda") && KTxtContra.Text.Equals("Yolanda"))
                        {
                            FrmMenuPrincipal mainMenu = new FrmMenuPrincipal();
                            mainMenu.Show();
                            this.Hide();
                        }
                        else
                        {
                            MsgError(e1);
                            KTxtNombre.Clear();
                            KTxtContra.Clear();
                        }
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
        #region botones 
        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            FrmRegistro registro = new FrmRegistro();
            registro.ShowDialog();
            //if (BtnRegistrarse.Text.Equals(Idiomas.Strings_es_ES.Log_BtnRegistrarse))
            //{
            //    FrmRegistro registro = new FrmRegistro("spanish");
            //    //signIn.Text = languages.Strings_es_ES.FrmTittle_SignIn;
            //    registro.ShowDialog();
            //}
            //else if(BtnRegistrarse.Text.Equals(Idiomas.Strings_en_US.Log_BtnRegistrarse))
            //{
            //    FrmRegistro registro = new FrmRegistro("english");
            //    //signIn.Text = languages.Strings_en_US.FrmTittle_SignIn;
            //    registro.ShowDialog();
            //}
            //else
            //{
            //    FrmRegistro registro = new FrmRegistro("french");
            //    //signIn.Text = languages.Strings_en_US.FrmTittle_SignIn;
            //    registro.ShowDialog();
            //}
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            MostrarMainEntrar(KTxtUrl, KTxtNombre, KTxtContra, ControladorIdioma.GetTexto("Log_Url"),
                    ControladorIdioma.GetTexto("Log_Nombre"), ControladorIdioma.GetTexto("Log_Contra"), ControladorIdioma.GetTexto("Log_Error1"),
                    ControladorIdioma.GetTexto("Log_Error2"), ControladorIdioma.GetTexto("Log_Error3"), ControladorIdioma.GetTexto("Log_Error4"));
            //if (BtnSpain.Text.Equals(Idiomas.Strings_es_ES.Log_BtnSpain))
            //{
            //    MostrarMainEntrar(KTxtUrl, KTxtNombre, KTxtContra, Idiomas.Strings_es_ES.Log_Url,
            //        Idiomas.Strings_es_ES.Log_Nombre, Idiomas.Strings_es_ES.Log_Contra, Idiomas.Strings_es_ES.Log_Error1,
            //        Idiomas.Strings_es_ES.Log_Error2, Idiomas.Strings_es_ES.Log_Error3, Idiomas.Strings_es_ES.Log_Error4);
            //}
            //else if (BtnSpain.Text.Equals(Idiomas.Strings_en_US.Log_BtnSpain))
            //{
            //    MostrarMainEntrar(KTxtUrl, KTxtNombre, KTxtContra, Idiomas.Strings_en_US.Log_Url,
            //        Idiomas.Strings_en_US.Log_Nombre, Idiomas.Strings_en_US.Log_Contra, Idiomas.Strings_en_US.Log_Error1,
            //        Idiomas.Strings_en_US.Log_Error2, Idiomas.Strings_en_US.Log_Error3, Idiomas.Strings_en_US.Log_Error4);
            //}
            //else
            //{
            //    MostrarMainEntrar(KTxtUrl, KTxtNombre, KTxtContra, Idiomas.Strings_fr_FR.Log_Url,
            //        Idiomas.Strings_fr_FR.Log_Nombre, Idiomas.Strings_fr_FR.Log_Contra, Idiomas.Strings_fr_FR.Log_Error1,
            //        Idiomas.Strings_fr_FR.Log_Error2, Idiomas.Strings_fr_FR.Log_Error3, Idiomas.Strings_fr_FR.Log_Error4);
            //}
        }
       
        private void BtnInvitado_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menu = new FrmMenuPrincipal();//no hace falta pasarle el idioma
            menu.Show();
            this.Hide();

            Persona testA = new Persona(0,
                "pepe",
                "el gafas",
                "Escritor",
                new DateTime(),
                new DateTime(),
                "",
                "",
                "");
            BaseDatos.ConexionBD.CrearBD("localhost","root","metrica123","3306");
            BaseDatos.ConexionBD.AbrirConexion();
            BaseDatos.EscrituraBD.InsertOcupacion("Escritor");
            BaseDatos.EscrituraBD.InsertAutor(testA);
            testA.Nombre = "Jose";
            BaseDatos.EscrituraBD.UpdateAutor(testA);
            BaseDatos.EscrituraBD.DeleteAutor(testA);
            //BaseDatos.EscrituraBD.UpdateOcupacion("Escritor", "Escritor/a");
            //BaseDatos.EscrituraBD.DeleteOcupacion("Escritor/a");
            BaseDatos.ConexionBD.CerrarConexion();
        }
        #endregion
        #region Cambiar idioma
        private void BtnSpain_Click(object sender, EventArgs e)
        {
            UsuarioDatos.configuracionUsuario.IdiomaIntefaz = "Strings_es_ES";
            UsuarioDatos.configuracionUsuario.GuardarJson();
            ControladorIdioma.idioma = "Strings_es_ES";
            IdiomaTexto();
            Reset(KTxtUrl, KTxtNombre, KTxtContra);
        }
        private void BtnUsa_Click(object sender, EventArgs e)
        {
            UsuarioDatos.configuracionUsuario.IdiomaIntefaz = "Strings_en_US";
            UsuarioDatos.configuracionUsuario.GuardarJson();
            ControladorIdioma.idioma = "Strings_en_US";
            IdiomaTexto();
            Reset(KTxtUrl, KTxtNombre, KTxtContra);
        }

        private void BtnFrancia_Click(object sender, EventArgs e)
        {
            UsuarioDatos.configuracionUsuario.IdiomaIntefaz = "Strings_fr_FR";
            UsuarioDatos.configuracionUsuario.GuardarJson();
            ControladorIdioma.idioma = "Strings_fr_FR";
            IdiomaTexto();
            Reset(KTxtUrl, KTxtNombre, KTxtContra);

        }
        #endregion

        #region PlaceHolder KryptonTextBox
        private void KTxtUrl_Enter(object sender, EventArgs e)
        {
            PlaceholderOff(KTxtUrl, ControladorIdioma.GetTexto("Log_Url"));
            //if (BtnSpain.Text.Equals(Idiomas.Strings_es_ES.Log_BtnSpain))
            //    PlaceholderOff(KTxtUrl, Idiomas.Strings_es_ES.Log_Url);
            //else if (BtnSpain.Text.Equals(Idiomas.Strings_en_US.Log_BtnSpain))
            //    PlaceholderOff(KTxtUrl, Idiomas.Strings_en_US.Log_Url);
            //else
            //    PlaceholderOff(KTxtUrl, Idiomas.Strings_fr_FR.Log_Url);
        }

        private void KTxtUrl_Leave(object sender, EventArgs e)
        {
            PlaceholderOn(KTxtUrl, ControladorIdioma.GetTexto("Log_Url"));
            //if (BtnSpain.Text.Equals(Idiomas.Strings_es_ES.Log_BtnSpain))
            //    PlaceholderOn(KTxtUrl, Idiomas.Strings_es_ES.Log_Url);
            //else if (BtnSpain.Text.Equals(Idiomas.Strings_en_US.Log_BtnSpain))
            //    PlaceholderOn(KTxtUrl, Idiomas.Strings_en_US.Log_Url);
            //else
            //    PlaceholderOn(KTxtUrl, Idiomas.Strings_fr_FR.Log_Url);
        }


        private void KTxtNombre_Enter(object sender, EventArgs e)
        {
            PlaceholderOff(KTxtNombre, ControladorIdioma.GetTexto("Log_Nombre"));
            //if (BtnSpain.Text.Equals(Idiomas.Strings_es_ES.Log_BtnSpain))
            //    PlaceholderOff(KTxtNombre, Idiomas.Strings_es_ES.Log_Nombre);
            //else if (BtnSpain.Text.Equals(Idiomas.Strings_en_US.Log_BtnSpain))
            //    PlaceholderOff(KTxtNombre, Idiomas.Strings_en_US.Log_Nombre);
            //else
            //    PlaceholderOff(KTxtNombre, Idiomas.Strings_fr_FR.Log_Nombre);
        }

        private void KTxtNombre_Leave(object sender, EventArgs e)
        {
            PlaceholderOn(KTxtNombre, ControladorIdioma.GetTexto("Log_Nombre"));
            //if (BtnSpain.Text.Equals(Idiomas.Strings_es_ES.Log_BtnSpain))
            //    PlaceholderOn(KTxtNombre, Idiomas.Strings_es_ES.Log_Nombre);
            //else if (BtnSpain.Text.Equals(Idiomas.Strings_en_US.Log_BtnSpain))
            //    PlaceholderOn(KTxtNombre, Idiomas.Strings_en_US.Log_Nombre);
            //else
            //    PlaceholderOn(KTxtNombre, Idiomas.Strings_fr_FR.Log_Nombre);
        }

        private void KTxtContra_Enter(object sender, EventArgs e)
        {
            PlaceholderContraOff(KTxtContra, ControladorIdioma.GetTexto("Log_Contra"));
            //if (BtnSpain.Text.Equals(Idiomas.Strings_es_ES.Log_BtnSpain))
            //    PlaceholderContraOff(KTxtContra, Idiomas.Strings_es_ES.Log_Contra);
            //else if (BtnSpain.Text.Equals(Idiomas.Strings_en_US.Log_BtnSpain))
            //    PlaceholderContraOff(KTxtContra, Idiomas.Strings_en_US.Log_Contra);
            //else
            //    PlaceholderContraOff(KTxtContra, Idiomas.Strings_fr_FR.Log_Contra);
        }

        private void KTxtContra_Leave(object sender, EventArgs e)
        {
            PlaceholderOn(KTxtContra, ControladorIdioma.GetTexto("Log_Contra"));
            //if (BtnSpain.Text.Equals(Idiomas.Strings_es_ES.Log_BtnSpain))
            //    PlaceholderOn(KTxtContra, Idiomas.Strings_es_ES.Log_Contra);
            //else if (BtnSpain.Text.Equals(Idiomas.Strings_en_US.Log_BtnSpain))
            //    PlaceholderOn(KTxtContra, Idiomas.Strings_en_US.Log_Contra);
            //else
            //    PlaceholderOn(KTxtContra, Idiomas.Strings_fr_FR.Log_Contra);
        }
        #endregion

        private void MBtnCerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

