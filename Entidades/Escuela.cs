using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Escuela
    {
        #region Atributos
        private List<Asignacion> listaAsignaciones;
        private List<Hermano> listaHermanos;
        private string nombreCongregacion;
        #endregion
        #region Propiedades
        public List<Hermano> ListaHermanos
        {
            get { return this.listaHermanos; }
            set { this.listaHermanos = value; }
        }
        public List<Asignacion> ListaAsignaciones
        {
            get { return this.listaAsignaciones; }
            set { this.listaAsignaciones = value; }
        }
        public string NombreCongregacion
        {
            get { return this.nombreCongregacion; }
            set { if (value.Length <= 30) { this.nombreCongregacion = value; } }
        }
        #endregion
        #region Propiedades

        ///Hermanos
        public static bool operator !=(Escuela e, Hermano h)
        {
            return !(e == h);
        }
        public static bool operator ==(Escuela e,Hermano h)
        {
            foreach(Hermano x in e.ListaHermanos)
            {
                if (x == h)
                    return true;
            }
            return false;
        }
        public static Escuela operator +(Escuela e,Hermano h)
        {
            if(e!=h)
            {
                e.ListaHermanos.Add(h);
            }
            return e;
        }
        public static Escuela operator -(Escuela e, Hermano h)
        {
            if (e == h)
            {
                e.ListaHermanos.Remove(h);
            }
            return e;
        }

        ///Asignaciones

        public static bool operator !=(Escuela e, Asignacion a)
        {
            return !(e == a);
        }
        public static bool operator ==(Escuela e, Asignacion a)
        {
            foreach (Asignacion x in e.ListaAsignaciones)
            {
                if (x == a)
                    return true;
            }
            return false;
        }
        public static Escuela operator +(Escuela e, Asignacion a)
        {
            if (e != a)
            {
                e.ListaAsignaciones.Add(a);
            }
            return e;
        }
        public static Escuela operator -(Escuela e, Asignacion a)
        {
            if (e == a)
            {
                e.ListaAsignaciones.Remove(a);
            }
            return e;
        }
        public Escuela()
        {
            this.listaAsignaciones = new List<Asignacion>();
            this.listaHermanos = new List<Hermano>();
            this.NombreCongregacion = "Nombre no definido";

        }
        public Escuela(string nombre):this()
        {
            this.NombreCongregacion = nombre;
        }

        #endregion


    }
}
