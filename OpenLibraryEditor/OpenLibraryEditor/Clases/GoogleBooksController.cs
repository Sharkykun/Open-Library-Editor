using Google.Apis.Books.v1;
using Google.Apis.Books.v1.Data;
using Google.Apis.Services;
using OpenLibraryEditor.DatosLibros;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.Clases
{
    /*
     - OPCIONAL: Añadir buscar más de 40 libros. Lanzaría varias consultas.
     */
    public class GoogleBooksController
    {
        private BooksService service;

        private const int MAX_QUERY_RESULT = 40;

        private Volumes bookCollection; //Lista de libros al realizar busqueda

        public Volumes BookCollection { get => bookCollection; set => bookCollection = value; }

        /// <summary>
        /// Instancia e inicia el servicio de Google Books.
        /// </summary>
        /// <param name="appName">Nombre de la app.</param>
        /// <param name="privateKey">Clave privada del usuario</param>
        public GoogleBooksController(string appName, string privateKey)
        {
            //service = new BooksService(
            //new BaseClientService.Initializer
            //{
            //    ApplicationName = "OpenDigiBook",
            //    ApiKey = "AIzaSyC9BJTVe8BN8bZGsf7dF4We3Bsz9lL6mPc",
            //});
            service = new BooksService(
            new BaseClientService.Initializer
            {
                ApplicationName = appName,
                ApiKey = privateKey,
            });
        }

        /// <summary>
        /// Busca libros por nombre o ISBN (both 10 or 13), y lo almacena en bookCollection.
        /// Si no encuentra nada, bookCollection será null.
        /// </summary>
        /// <param name="bookName">Nombre o ISBN del libro a buscar.</param>
        /// <param name="count">Número de libros máximos a buscar. Si -1, recogerá el máximo permitido por la API.</param>
        /// <param name="matureBooks">Marca si debe buscar o no libros para mayores de edad.</param>
        public void SearchBook(string bookName, int count, bool matureBooks)
        {
            try
            {
                //Crear Query para buscar libros
                var query = service.Volumes.List(bookName);
                if (count > 0) query.MaxResults = count;
                if (matureBooks) query.MaxAllowedMaturityRating = VolumesResource.ListRequest.MaxAllowedMaturityRatingEnum.MATURE;
                else query.MaxAllowedMaturityRating = VolumesResource.ListRequest.MaxAllowedMaturityRatingEnum.NotMature;

                var result = query.Execute();
                if (result != null && result.Items != null)
                {
                    bookCollection = result;
                }
                else
                    bookCollection = null;
            }
            catch (Google.GoogleApiException)
            {
                VentanaWindowsComun.MensajeError("La busqueda en Google Books falló.\nCompruebe que su clave privada es correcta\ny que ha escrito algo para poder buscar.");
                bookCollection = null;
            }
        }

        /// <summary>
        /// Convierte los datos de un libro de Google Books a un libro de esta app.
        /// </summary>
        /// <param name="volume">Libro de Google Books a convertir.</param>
        /// <returns>Libro convertido. Retorna excepción si el ISBN del libro ya existe en el listado.</returns>
        public static Libro ParseBook(Volume volume, bool sacarPersonas, bool sacarEditorial, bool sacarGeneros)
        {
            //Sacar ISBN y comprobar si existe
            //volInfo.PreviewLink para sacar el enlace del libro
            var volInfo = volume.VolumeInfo;
            string isbn13 = volInfo.IndustryIdentifiers.FirstOrDefault(p => p.Type == "ISBN_13").Identifier;
            string isbn10 = volInfo.IndustryIdentifiers.FirstOrDefault(p => p.Type == "ISBN_10").Identifier;

            if (Biblioteca.biblioteca.ListaLibro.Any(p => p.Isbn_13 == isbn13))
            {
                throw new Libro.IdRepetidoException("El ISBN del libro ya existe en la biblioteca.");
            }

            Libro book = new Libro();

            if (sacarPersonas && volInfo.Authors != null && volInfo.Authors.Count > 0)
            {
                //Sacar personas
                List<Autor> peopleList = new List<Autor>();

                foreach (var auth in volInfo.Authors)
                {
                    //Si existe lo añade. Si no, crea uno nuevo y lo añade.
                    Autor pers = Biblioteca.biblioteca.ListaAutor.FirstOrDefault(p => p.Nombre == auth);
                    if (pers == null)
                    {
                        pers = new Autor(auth);
                        Biblioteca.biblioteca.ListaAutor.Add(pers);
                    }

                    peopleList.Add(pers);
                }

                book.ListaAutor = peopleList;
            }

            if (sacarEditorial && !String.IsNullOrWhiteSpace(volInfo.Publisher))
            {

                //Sacar editorial
                List<Editorial> editorialList = new List<Editorial>();

                //Si existe lo añade. Si no, crea uno nuevo y lo añade.
                Editorial edi = Biblioteca.biblioteca.ListaEditorial.FirstOrDefault(p => p.Nombre == volInfo.Publisher);
                if (edi == null)
                {
                    edi = new Editorial(volInfo.Publisher);
                    Biblioteca.biblioteca.ListaEditorial.Add(edi);
                }

                editorialList.Add(edi);
                book.ListaEditorial = editorialList;
            }

            if (sacarGeneros && volInfo.Categories != null && volInfo.Categories.Count > 0)
            {
                //Sacar géneros
                List<Genero> generoLista = new List<Genero>();

                foreach (var cat in volInfo.Categories)
                {
                    //Si existe lo añade. Si no, crea uno nuevo y lo añade.
                    Genero gen = Biblioteca.biblioteca.ListaGenero.FirstOrDefault(p => p.Nombre == cat);
                    if (gen == null)
                    {
                        gen = new Genero(cat);
                        Biblioteca.biblioteca.ListaGenero.Add(gen);
                    }

                    generoLista.Add(gen);
                }

                book.ListaGenero = generoLista;
            }

            //Sacar datos de libro
            book.Isbn_10 = isbn10;
            book.Isbn_13 = isbn13;
            book.Titulo = volInfo.Title;
            book.Subtitulo = volInfo.Subtitle;
            book.Sinopsis = volInfo.Description;
            if(volInfo.PageCount != null)
                book.NumeroPaginas = (int)volInfo.PageCount;
            try
            {
                if (!String.IsNullOrWhiteSpace(volInfo.PublishedDate))
                    book.FechaPublicacion = DateTime.Parse(volInfo.PublishedDate);
            }
            catch (FormatException){; }

            if(volInfo.SeriesInfo != null)
                book.NumeroVolumen = 
                    Double.Parse(volInfo.SeriesInfo.BookDisplayNumber);
            if (volInfo.ImageLinks != null)
            {
                book.ImagenPortada = ControladorImagen.RUTA_LIBRO+isbn13+"_c.png";
                SaveImageFromURL(volInfo.ImageLinks.Thumbnail).Save(book.ImagenPortada);
            }
            if (volInfo.MaturityRating == "MATURE")
                book.MayorEdad = true;

            //Poner enlace a leer libro en enlace de referencia si tiene
            if (!String.IsNullOrWhiteSpace(volInfo.PreviewLink))
                book.EnlaceReferencia = volInfo.PreviewLink;

            return book;
        }

        /// <summary>
        /// Guarda la imagen de una URL como Bitmap.
        /// </summary>
        /// <param name="imageUrl">URL de imagen.</param>
        /// <returns>Bitmap que contiene la imagen descargada.</returns>
        public static Bitmap SaveImageFromURL(string imageUrl)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(imageUrl);
            Bitmap bitmap;
            bitmap = new Bitmap(stream);

            stream.Flush();
            stream.Close();
            client.Dispose();

            return bitmap;
        }

        /// <summary>
        /// Permite separar la descripción con saltos de línea, buscando siempre espacios en blanco.
        /// </summary>
        /// <param name="desc">String de descripción a separar.</param>
        /// <param name="charsPerLine">Nº de caracteres por línea.</param>
        /// <returns>Descripción separada.</returns>
        public string SplitDescription(string desc, int charsPerLine)
        {
            string newd = desc.ToString();
            int count = 0;
            for (int x = 0; x < newd.Length; ++x)
            {
                if (count >= charsPerLine && newd[x] == ' ')
                {
                    count = 0;
                    char[] ch = newd.ToCharArray();
                    ch[x] = (char)10;
                    newd = new string(ch);
                }
                else count++;
            }
            return newd;
        }
    }
}

