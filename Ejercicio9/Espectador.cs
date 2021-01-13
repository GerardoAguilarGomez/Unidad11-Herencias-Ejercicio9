using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio9
{
    class Espectador
    {
        private int id;
        private string nombre;
        private int edad;
        private double dinero;
        private int fila;
        private int columna;
        #region Const
        public Espectador()
        {
            this.id = 0;
            this.nombre = "";
            this.edad = 0;
            this.dinero = 0;
            this.fila = 0;
            this.columna = 0;
        }

        public Espectador(int id)
        {
            this.id = id;
            this.nombre = "";
            this.edad = 0;
            this.dinero = 0;
            this.fila = 0;
            this.columna = 0;
        }

        public Espectador(int id,string nombre)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = 0;
            this.dinero = 0;
            this.fila = 0;
            this.columna = 0;
        }

        public Espectador(int id,string nombre,int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad =edad;
            this.dinero = 0;
            this.fila = 0;
            this.columna = 0;
        }

        public Espectador(int id,string nombre, int edad, double dinero)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
            this.fila = 0;
            this.columna = 0;
        }
        #endregion

        #region getters and setters
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Dinero { get => dinero; set => dinero = value; }
        public int Id { get => id; set => id = value; }
        public int Fila { get => fila; set => fila = value; }
        public int Columna { get => columna; set => columna = value; }
        #endregion
    }
}
