﻿using MySql.Data.MySqlClient;
using OpenLibraryEditor.Clases;
using OpenLibraryEditor.DatosLibros;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenLibraryEditor.BaseDatos
{
    public class ConversorRegistro
    {
        public static Autor RegistroAAutor(MySqlDataReader registro)
        {
            Autor a = new Autor(registro["nombreAutor"].ToString(),
                registro["alias"].ToString(),
                registro["nombreOcupacion"].ToString(),
                DateTime.Parse(registro["fechaNacimiento"].ToString()),
                DateTime.Parse(registro["fechaDefuncion"].ToString()),
                registro["enlaceReferencia"].ToString(),
                registro["comentario"].ToString(),
                null);
            if(registro["imagen"].GetType() != typeof(System.DBNull))
                a.ImagenTemp = (byte[])registro["imagen"];
            a.ListaIdCompartido.Add(ConexionBD.IdBD+"-"+registro["idAutor"].ToString());
            return a;
        }

        public static Editorial RegistroAEditorial(MySqlDataReader registro)
        {
            Editorial e = new Editorial(registro["nombreEditorial"].ToString(),
                registro["comentario"].ToString(),
                null);
            if (registro["imagen"].GetType() != typeof(System.DBNull))
                e.ImagenTemp = (byte[])registro["imagen"];
            e.Imagen = ControladorImagen.RUTA_EDITORIAL + e.IdEditorial;
            e.ListaIdCompartido.Add(ConexionBD.IdBD + "-" + registro["idEditorial"].ToString());
            return e;
        }

        public static Genero RegistroAGenero(MySqlDataReader registro)
        {
            Genero g = new Genero(registro["nombreGenero"].ToString(),
                registro["comentario"].ToString());
            g.ListaIdCompartido.Add(ConexionBD.IdBD + "-" + registro["idGenero"].ToString());
            return g;
        }

        public static InfoUsuarioBD RegistroAUsuarioInfo(MySqlDataReader registro)
        {
            return new InfoUsuarioBD(registro["nombreUsuario"].ToString(),
                registro["correoUsuario"].ToString(),
                registro["tipoUsuario"].ToString());
        }

        public static Libro RegistroALibro(MySqlDataReader registro)
        {
            Libro libro = new Libro(registro["titulo"].ToString());
            libro.Isbn_13 = registro["isbn13"].ToString();
            libro.Subtitulo = registro["subtitulo"].ToString();
            libro.TituloAlternativo = registro["tituloAlternativo"].ToString();
            libro.Sinopsis = registro["sinopsis"].ToString();
            libro.NumeroPaginas = int.Parse(registro["numeroPaginas"].ToString());
            libro.FechaPublicacion = DateTime.Parse(registro["fechaPublicacion"].ToString());
            libro.FechaAdicionBD = DateTime.Parse(registro["fechaAdicionBD"].ToString());
            libro.Edicion = int.Parse(registro["edicion"].ToString());
            libro.NumeroVolumen = double.Parse(registro["numeroVolumen"].ToString());
            libro.Idioma = registro["idioma"].ToString();
            libro.IdiomaOriginal = registro["idiomaOriginal"].ToString();
            libro.Isbn_10 = registro["isbn10"].ToString();
            libro.NombreTipo = registro["nombreTipoLibro"].ToString();
            libro.MayorEdad = bool.Parse(registro["mayorEdad"].ToString());
            libro.NumeroCapitulos = int.Parse(registro["numeroCapitulos"].ToString());
            libro.EnlaceReferencia = registro["enlaceReferencia"].ToString();
            libro.ListaIdCompartido.Add(ConexionBD.IdBD + "-" + registro["idLibro"].ToString());
            libro.ImagenPortada = ControladorImagen.RUTA_EDITORIAL + libro.IdLibro+"_c";
            libro.ImagenContraportada = ControladorImagen.RUTA_EDITORIAL + libro.ImagenContraportada+ "_b";
            if (registro["imagenPortada"].GetType() != typeof(System.DBNull))
                libro.PortadaTemp = (byte[])registro["imagenPortada"];
            if (registro["imagenContraportada"].GetType() != typeof(System.DBNull))
                libro.ContraportadaTemp = (byte[])registro["imagenContraportada"];
            return libro;
        }

        public static void RegistroAUsuarioLibro(MySqlDataReader registro, Libro libro)
        {
            libro.Puntuacion = Double.Parse(registro["puntuacion"].ToString());
            libro.VecesLeido = int.Parse(registro["vecesLeido"].ToString());
            libro.TiempoLectura = TimeSpan.Parse(registro["tiempoLectura"].ToString());
            libro.FechaComienzo = DateTime.Parse(registro["fechaComienzo"].ToString());
            libro.FechaTerminado = DateTime.Parse(registro["fechaTerminado"].ToString());
            libro.Comentario = registro["comentario"].ToString();
            libro.CapituloActual = int.Parse(registro["capituloActual"].ToString());
            libro.EstadoLectura = registro["estadoLectura"].ToString();
            libro.Ocultar = bool.Parse(registro["ocultar"].ToString());
            libro.Favorito = bool.Parse(registro["favorito"].ToString());
        }
    }
}
