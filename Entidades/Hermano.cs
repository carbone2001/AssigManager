using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Hermano
    {
        #region Atributos
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected string telefono;
        protected bool bautizado;
        protected bool estado;
        protected EPrivilegio privilegio;
        #endregion

        #region Propiedades
        public string Nombre { get { return this.nombre; } set { if (!Object.Equals(value, null) &&  value.Length<32) { this.nombre = value; } } }
        public string Apellido { get { return this.apellido;  } set { if (!Object.Equals(value, null) && value.Length < 32) { this.apellido = value; }  } }
        public int Edad { get { return this.edad; } set { if (!Object.Equals(null, value)) { this.edad = value; } } }
        public string Telefono { get { return this.telefono; } set { if (!Object.Equals(null, value)&&value.Length<12) { this.telefono = value; } } }
        public bool Bautizado { get { return this.bautizado; } set { this.bautizado = value; } }
        public bool Estado { get { return this.estado; } set { this.estado = value; } }
        public EPrivilegio Privilegio { get { return this.privilegio; } set { if (!Object.Equals(null, value)) { this.privilegio = value; } } }
        #endregion
        #region Propiedades
        public override string ToString()
        {
            return String.Format("{0} - {1} Telefono: {2} Edad: {3} Privilegio: {4} Bautizado: {5} Habilitado: {6}",this.Apellido,this.Nombre,this.Telefono,this.Edad,this.Privilegio.ToString(),this.BoolSiNo(this.Bautizado),this.BoolSiNo(this.Estado));
        }
        public static bool operator !=(Hermano a, Hermano b)
        {
            return !(a == b);
        }
        public static bool operator ==(Hermano a, Hermano b)
        {
            if (a.Apellido == b.Apellido && a.Nombre == b.Nombre && a.Edad == b.Edad && a.Telefono == b.Telefono)
                return true;
            return false;
        }
        public Hermano()
        {
            this.Apellido = "";
            this.Nombre = "";
            this.Edad = 0;
            this.Telefono = "";
            this.Bautizado = false;
            this.Estado = true;
            this.Privilegio = EPrivilegio.Publicador;
        }
        public Hermano(string apellido,string nombre,int edad, string telefono,bool bautizado,bool estado,EPrivilegio privilegio):this()
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Telefono = telefono;
            this.Bautizado = bautizado;
            this.Estado = estado;
            this.Privilegio = privilegio;
        }
        public override bool Equals(object obj)
        {
            if (obj is Hermano)
                return true;
            return false;
        }
        public string BoolSiNo(bool x)
        {
            if (x == true)
                return "SI";
            return "NO";
        }
        //public static int OrdenarPorNombre(Hermano a, Hermano b)
        #endregion


    }
}
