using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Pelicula
    {
        private string titulo;
        private int duracion;
        private int edad_minima;
        private string director;

        #region cons
        public Pelicula()
        {
            this.titulo = "";
            this.duracion = 0;
            this.edad_minima = 0;
            this.director = "";
        }

        public Pelicula(string titulo)
        {
            this.titulo = titulo;
            this.duracion = 0;
            this.edad_minima = 0;
            this.director = "";
        }

        public Pelicula(string titulo, int duracion) : this(titulo)
        {
            this.duracion = duracion;
            this.edad_minima = 0;
            this.director = "";
        }

        public Pelicula(string titulo, int duracion, int edad_minima) : this(titulo, duracion)
        {
            this.edad_minima = edad_minima;
            this.director = "";
        }

        public Pelicula(string titulo, int duracion, int edad_minima, string director) : this(titulo, duracion, edad_minima)
        {
            this.director = director;
        }
        #endregion

        #region getters

        public string Titulo { get => titulo; set => titulo = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public int Edad_minima { get => edad_minima; set => edad_minima = value; }
        public string Director { get => director; set => director = value; }
        #endregion
    }
}
