using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Asignacion
    {
        #region Atributos
        private Hermano hermano;
        private EAsignacion asignacion;
        private DateTime semana;
        private bool rechazada;
        private char escuela;
        #endregion
        #region Propiedades
        public Hermano Hermano { get { return this.hermano; } }
        public EAsignacion Asignacion_ { get { return this.asignacion; } }
        public DateTime Semana { get { return this.semana; } }
        public char Escuela { get { return this.escuela; } set { if (Char.ToUpper(value)  == 'A' || Char.ToUpper(value) == 'B') { this.escuela = Char.ToUpper(value); } } }
        public bool Rechazada { get { return this.rechazada; } set { this.rechazada = value; } }
        #endregion
        #region Propiedades
        public override string ToString()
        {
            return String.Format("Hermano: {0} - {1}\nAsignacion: {2}\nEscuela: {3}\nSemana: {4} Rechazada: {5}", hermano.Apellido, hermano.Apellido, this.MostrarAsignacion(), this.Escuela,this.MostrarSemana(),this.MostrarRechazo());
            
        }
        private string MostrarSemana()
        {
            StringBuilder m = new StringBuilder();
            DateTime aux = this.Semana;
            aux = aux.AddDays(7);
            m.AppendFormat("{0}/{1} - {2}/{3}",this.Semana.Day,this.Semana.Month,aux.Day,aux.Month);
            return m.ToString();
        }
        private string MostrarAsignacion()
        {
            switch(this.Asignacion_)
            {
                case EAsignacion.Lectura:
                    return "Lectura";
                case EAsignacion.Discurso:
                    return "Discurso";
                case EAsignacion.Primera_Conversacion:
                    return "Primera Conversacion";
                case EAsignacion.Primera_Revisita:
                    return "Primera Revisita";
                case EAsignacion.Segunda_Revisita:
                    return "Segunda Revisita";
                case EAsignacion.Tercera_Revisita:
                    return "Tercera Revisita";
                case EAsignacion.Cuarta_Revisita:
                    return "Cuarta Revisita";
                case EAsignacion.Curso_Biblico:
                    return "Curso Biblico";
                default:
                    return "Asignacion No Definida";
            }
        }
        public Asignacion(Hermano hermano,EAsignacion asignacion,DateTime semana,char escuela)
        {
            this.Escuela = escuela;
            this.asignacion = asignacion;
            this.semana = semana;
            this.hermano = hermano;
            this.Rechazada = false;
        }
        public static bool operator !=(Asignacion a, Asignacion b)
        {
            return !(a == b);
        }
        public static bool operator ==(Asignacion a, Asignacion b)
        {
            if (a.Hermano == b.Hermano && a.Semana == b.Semana)
                return true;
            return false;
        }
        private string MostrarRechazo()
        {
            if (Rechazada == true)
                return "SI";
            return "NO";
        }
        #endregion

    }
}
