using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Cine
    {
        private string pelicula;
        private double precio_entrada;
        
        #region cons
        public Cine()
        {
            this.pelicula = "";
            this.precio_entrada = 0;
        }

        public Cine(string pelicula)
        {
            this.pelicula = pelicula;
        }

        public Cine(string pelicula, int precio)
        {
            this.pelicula = pelicula;
            this.precio_entrada = precio;
        }
        #endregion

        #region getters
        public string Pelicula { get => pelicula; set => pelicula = value; }
        public double Precio_entrada { get => precio_entrada; set => precio_entrada = value; }
        #endregion

    }
}
