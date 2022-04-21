using FontAwesome.Sharp;
using FontAwesome.Sharp.Material;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.DatosLibros;
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
    public partial class FrmMenuPrincipal : Form
    {
        private string idioma;
        private MaterialButton botonActual;
        private MaterialSplitButton toolSeleccionado;
        private Panel bordeIzqBoton;
        private Form formHijoActual;

        private int altoPantalla;
        private int anchoPantalla;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
           
            bordeIzqBoton = new Panel();
            bordeIzqBoton.Size = new Size(7, 45);
            PanMenuMain.Controls.Add(bordeIzqBoton);
            //Quitar borde del formulario y evitar el parpadeo y permitir redimensionar
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            anchoPantalla = Screen.FromHandle(this.Handle).WorkingArea.Width;
            altoPantalla = Screen.FromHandle(this.Handle).WorkingArea.Height;
            this.MaximumSize = new Size(anchoPantalla,altoPantalla);

            //Quitar el texto del borde para que simule que no hay, pero se nota
            //this.Text = String.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (ControladorIdioma.idioma.Equals("Strings_fr_FR"))
                LlLogIn.Location = new Point(30,168);
            else if (ControladorIdioma.idioma.Equals("Strings_en_US"))
                LlLogIn.Location = new Point(88, 168);
            else
                LlLogIn.Location = new Point(65, 168);
          
            IdiomaTexto();
        }
        #region texto segun idioma seleccionado
        private void IdiomaTexto()
        {
            ToolTipMain.SetToolTip(this.AciFotoUsuario, ControladorIdioma.GetTexto("Main_TTFotoUsuario"));
            LlLogIn.Text = ControladorIdioma.GetTexto("Main_LinkSesion");
            ToolTipMain.SetToolTip(this.LlLogIn, ControladorIdioma.GetTexto("Main_TTLink"));
            MBtnMiBiblioteca.Text= ControladorIdioma.GetTexto("Main_MiBiblioteca");
            ToolTipMain.SetToolTip(this.MBtnMiBiblioteca, ControladorIdioma.GetTexto("Main_MiBiblioteca"));
            MBtnAutores.Text = ControladorIdioma.GetTexto("Main_Autores");
            ToolTipMain.SetToolTip(this.MBtnAutores, ControladorIdioma.GetTexto("Main_TTAutores"));
            MBtnTítulos.Text = ControladorIdioma.GetTexto("Main_Titulos");
            ToolTipMain.SetToolTip(this.MBtnTítulos, ControladorIdioma.GetTexto("Main_TTTitulos"));
            MBtnGeneros.Text = ControladorIdioma.GetTexto("Main_Generos");
            ToolTipMain.SetToolTip(this.MBtnGeneros, ControladorIdioma.GetTexto("Main_TTGeneros"));
            MBtnSeries.Text = ControladorIdioma.GetTexto("Main_Series");
            ToolTipMain.SetToolTip(this.MBtnSeries, ControladorIdioma.GetTexto("Main_TTSeries"));
            MBtnEditoriales.Text = ControladorIdioma.GetTexto("Main_Editoriales");
            ToolTipMain.SetToolTip(this.MBtnEditoriales, ControladorIdioma.GetTexto("Main_TTEditoriales"));
            MBtnTags.Text = ControladorIdioma.GetTexto("Main_Tags");
            ToolTipMain.SetToolTip(this.MBtnTags, ControladorIdioma.GetTexto("Main_TTTags"));
            MBtnBuscar.Text = ControladorIdioma.GetTexto("Main_Buscar");
            ToolTipMain.SetToolTip(this.MBtnBuscar, ControladorIdioma.GetTexto("Main_TTBuscar"));
            MBtnConfiguracion.Text = ControladorIdioma.GetTexto("Main_Confi");
            ToolTipMain.SetToolTip(this.MBtnConfiguracion, ControladorIdioma.GetTexto("Main_TTConfi"));
            MBtnSalir.Text = ControladorIdioma.GetTexto("Main_Salir");
            ToolTipMain.SetToolTip(this.MBtnSalir, ControladorIdioma.GetTexto("Main_TTSalir"));
            BtnAniadirLibroMsb.Text = ControladorIdioma.GetTexto("Main_NuevoLibro");
            BtnModificarLibroMsb.Text = ControladorIdioma.GetTexto("Main_Modificar");
            BtnBorrarLibroMsb.Text = ControladorIdioma.GetTexto("Main_Eliminar");
            BtnAutoresMsb.Text = ControladorIdioma.GetTexto("Main_Autores");
            BtnGenerosMsb.Text = ControladorIdioma.GetTexto("Main_Generos");
            BtnSeriesMsb.Text = ControladorIdioma.GetTexto("Main_Series");
            BtnEditorialesMsb.Text = ControladorIdioma.GetTexto("Main_Editoriales");
            BtnTagsMsb.Text = ControladorIdioma.GetTexto("Main_Tags");
            ToolTipMain.SetToolTip(this.PcbLogoMain, ControladorIdioma.GetTexto("Main_TTLogo"));
            ToolTipMain.SetToolTip(this.LblTituloMain, ControladorIdioma.GetTexto("Main_TTFormTitulo"));
            ToolTipMain.SetToolTip(this.MBtnMinimizarMain, ControladorIdioma.GetTexto("Main_TTMinimizar"));
            ToolTipMain.SetToolTip(this.MBtnMaximizarMain, ControladorIdioma.GetTexto("Main_TTMaximizar"));
            ToolTipMain.SetToolTip(this.MBtnRestaurarMain, ControladorIdioma.GetTexto("Main_TTRestaurar"));
            ToolTipMain.SetToolTip(this.MBtnCerrarMain, ControladorIdioma.GetTexto("Main_TTCerrar"));
        }
        #endregion
        #region Colores boton seleccionado
        private void BotonActivo(object senderBtn, Color color)
        {
            if (senderBtn!=null)
            {
                DesactivarBoton();
                //Boton
                botonActual = (MaterialButton)senderBtn;
                botonActual.ForeColor = color;
                botonActual.TextAlign = ContentAlignment.MiddleCenter;
                botonActual.IconColor = color;
                botonActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonActual.ImageAlign = ContentAlignment.MiddleRight;
                //Borde izquierdo
                bordeIzqBoton.BackColor = color;
                bordeIzqBoton.Location = new Point(0, botonActual.Location.Y);
                bordeIzqBoton.Visible = true;
                bordeIzqBoton.BringToFront();
            }
        }
        private void BotonActivoTool(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactivarBoton();
                toolSeleccionado = (MaterialSplitButton)senderBtn;
                toolSeleccionado.ForeColor = color;
                toolSeleccionado.IconColor = color;
            }
        }

        private void DesactivarBoton()
        {
            if (botonActual != null)
            {
                botonActual.ForeColor = Color.Gainsboro;
                botonActual.TextAlign = ContentAlignment.MiddleLeft;
                botonActual.IconColor = Color.Gainsboro;
                botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
            if (toolSeleccionado!=null)
            {
                toolSeleccionado.ForeColor = Color.Gainsboro;
                toolSeleccionado.IconColor = Color.Gainsboro;
            }
        }
     
        //Estructura colores
        private struct Colores
        {
            public static Color colorBiblioteca = Color.FromArgb(239, 184, 16);
            public static Color colorSubmenu = Color.FromArgb(0, 201, 142);
            public static Color colorBuscar = Color.FromArgb(249, 88, 155);
            public static Color colorConfi = Color.FromArgb(164, 204, 255);
            public static Color colorTool = Color.FromArgb(164, 204, 255);
        }
        private void ResetColores()
        {
            DesactivarBoton();
            bordeIzqBoton.Visible = false;
        }

        #endregion
        #region Abrir formularios hijos
        private void AbrirFormularios(Form fhijo)
        {
            if (formHijoActual != null)
            {
                formHijoActual.Close();
            }
            formHijoActual = fhijo;
            fhijo.TopLevel = false;
            fhijo.FormBorderStyle=FormBorderStyle.None;
            fhijo.Dock=DockStyle.Fill;
            this.DoubleBuffered = true;
            PanFormHijos.Controls.Add(fhijo);
            PanFormHijos.Tag = fhijo;
            fhijo.BringToFront();
            fhijo.Show();

        }
        #endregion
        #region Botones menu lateral
        private void MBtnMiBiblioteca_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmMiBiblioteca());
            BotonActivo(sender, Colores.colorBiblioteca);
        }
        private void MBtnAutores_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmMisAutores());
            BotonActivo(sender, Colores.colorSubmenu);
        }
        private void MBtnTitulos_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmMisTitulos());
            BotonActivo(sender, Colores.colorSubmenu);
        }
        private void MBtnGeneros_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmMisGeneros());
            BotonActivo(sender, Colores.colorSubmenu);
        }
        private void MBtnSeries_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmMisSeries());
            BotonActivo(sender, Colores.colorSubmenu);
        }
        private void MBtnEditoriales_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmMisEditoriales());
            BotonActivo(sender, Colores.colorSubmenu);
        }
        private void MBtnTags_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmMisTags());
            BotonActivo(sender, Colores.colorSubmenu);
        }
        private void MBtnBuscar_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmBuscar());
            BotonActivo(sender, Colores.colorBuscar);
        }
        private void MBtnConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new FrmConfiguracion());
            BotonActivo(sender, Colores.colorConfi);
        }

        #endregion
        #region botones tool
        private void BtnAniadirLibroMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmLibros al = new FrmLibros(new Libro());
            al.FormBorderStyle=FormBorderStyle.None;
            al.ShowDialog();
            BotonActivoTool(sender,Colores.colorBiblioteca);
        }
        private void BtnModificarLibroMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            //FrmLibros al = new FrmLibros(libroSeleccionado);
            //al.FormBorderStyle = FormBorderStyle.None;
            //al.ShowDialog();
            BotonActivoTool(sender, Colores.colorBiblioteca);
        }
        private void BtnBorrarLibroMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            BotonActivoTool(sender,Colores.colorBiblioteca);
        }
        private void BtnAutoresMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmAutores autores = new FrmAutores(true);
            autores.FormBorderStyle = FormBorderStyle.None;
            autores.ShowDialog();
            BotonActivoTool(sender,Colores.colorBiblioteca);
        }
        private void BtnGenerosMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmGeneros generos = new FrmGeneros(true);
            generos.FormBorderStyle = FormBorderStyle.None;
            generos.ShowDialog();
            BotonActivoTool(sender,Colores.colorBiblioteca);
        }
        private void BtnSeriesMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmSeries series = new FrmSeries(true);
            series.FormBorderStyle = FormBorderStyle.None;
            series.ShowDialog();
            BotonActivoTool(sender,Colores.colorBiblioteca);
        }
        private void BtnEditorialesMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmEditoriales editoriales = new FrmEditoriales(true);
            editoriales.FormBorderStyle = FormBorderStyle.None;
            editoriales.ShowDialog();
            BotonActivoTool(sender,Colores.colorBiblioteca);
        }
        private void BtnTagsMsb_ButtonClick(object sender, EventArgs e)
        {
            ResetColores();
            FrmTags tags = new FrmTags(true);
            tags.FormBorderStyle = FormBorderStyle.None;
            tags.ShowDialog();
            BotonActivoTool(sender,Colores.colorBiblioteca);
        }
        #endregion
        #region Botones minimizar, maximizar, restaurar, redimensionar y salir
        //Para saber el tamaño y la posicion inicial de la pantalla y poder restaurarla en el centro de la pantalla
        private int lx, ly;
        private int sw, sh;
        private void MBtnRestaurar_Click(object sender, EventArgs e)
        {
            MBtnMaximizarMain.Visible = true;
            MBtnRestaurarMain.Visible = false;
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void MBtnMinimizarMain_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void MBtnMaximizarMain_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            MBtnMaximizarMain.Visible = false;
            MBtnRestaurarMain.Visible = true;
            //this.WindowState = FormWindowState.Maximized;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        protected override void OnPaint(PaintEventArgs e) // you can safely omit this method if you want
        {
            e.Graphics.FillRectangle(Brushes.Navy, Superior);
            e.Graphics.FillRectangle(Brushes.Navy, Izquierda);
            e.Graphics.FillRectangle(Brushes.Navy, Derecha);
            e.Graphics.FillRectangle(Brushes.Navy, Inferior);
        }

        //método para poder redimensionar el formulario sin borde
        private const int
            IZQUIERDA = 10,
            DERECHA = 11,
            SUPERIOR = 12,
            SUPERIORIZQDA = 13,
            SUPERIORDCHA = 14,
            INFERIOR = 15,
            INFERIORIZQDA = 16,
            INFERIORDCHA = 17;

        private const int MARGEN = 10;
        Rectangle Superior { get { return new Rectangle(0, 0, this.ClientSize.Width, MARGEN); } }
        Rectangle Izquierda { get { return new Rectangle(0, 0, MARGEN, this.ClientSize.Height); } }
        Rectangle Inferior { get { return new Rectangle(0, this.ClientSize.Height - MARGEN, this.ClientSize.Width, MARGEN); } }
        Rectangle Derecha { get { return new Rectangle(this.ClientSize.Width - MARGEN, 0, MARGEN, this.ClientSize.Height); } }

        Rectangle SupIzqda { get { return new Rectangle(0, 0, MARGEN, MARGEN); } }
        Rectangle SupDcha { get { return new Rectangle(this.ClientSize.Width - MARGEN, 0, MARGEN, MARGEN); } }
        Rectangle InfIzqda { get { return new Rectangle(0, this.ClientSize.Height - MARGEN, MARGEN, MARGEN); } }
        Rectangle InfDcha { get { return new Rectangle(this.ClientSize.Width - MARGEN, this.ClientSize.Height - MARGEN, MARGEN, MARGEN); } }


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == 0x84) // WM_NCHITTEST
            {
                var cursor = this.PointToClient(Cursor.Position);

                if (SupIzqda.Contains(cursor)) message.Result = (IntPtr)SUPERIORIZQDA;
                else if (SupDcha.Contains(cursor)) message.Result = (IntPtr)SUPERIORDCHA;
                else if (InfIzqda.Contains(cursor)) message.Result = (IntPtr)INFERIORIZQDA;
                else if (InfDcha.Contains(cursor)) message.Result = (IntPtr)INFERIORDCHA;

                else if (Superior.Contains(cursor)) message.Result = (IntPtr)SUPERIOR;
                else if (Izquierda.Contains(cursor)) message.Result = (IntPtr)IZQUIERDA;
                else if (Derecha.Contains(cursor)) message.Result = (IntPtr)DERECHA;
                else if (Inferior.Contains(cursor)) message.Result = (IntPtr)INFERIOR;
            }
        }


        #endregion
        #region cerrar formulario
        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            string mensaje = Clases.ControladorIdioma.GetTexto("ShowDialogCerrar");
            
            DialogResult boton = MessageBox.Show(mensaje, "Open Library Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (boton == DialogResult.Yes)
            {
                //Guardar datos en la base de datos local
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
        private void MBtnCerrarMain_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MBtnSalir_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
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
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
