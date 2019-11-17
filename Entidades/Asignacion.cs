using System;
using System.Text;
using Hermanos;
namespace Entidades
{
    [Serializable]
    public class Asignacion
    {
        #region Atributos
        private Hermano hermano;
        private Hermano ayudante;
        private EAsignacion asignacion;
        private int aspectoOratoria;
        private DateTime semana;
        private bool rechazada;
        private char escuela;
        #endregion
        #region Propiedades
        public Hermano Hermano { get { return this.hermano; } set { this.hermano = value; } }
        public Hermano Ayudante { get { return this.ayudante; } set { this.ayudante = value; } }
        public int AspectoOratoria { get { return this.aspectoOratoria; } set { this.aspectoOratoria = value; } }
        public EAsignacion Asignacion_ { get { return this.asignacion; } set { this.asignacion = value; } }
        public DateTime Semana { get { return this.semana; } set { this.semana = value; } }
        public char Escuela { get { return this.escuela; } set { if (Char.ToUpper(value) == 'A' || Char.ToUpper(value) == 'B') { this.escuela = Char.ToUpper(value); } } }
        public bool Rechazada { get { return this.rechazada; } set { this.rechazada = value; } }
        #endregion
        #region Propiedades
        public override string ToString()
        {
            string ayudante;
            if (Object.Equals(this.Ayudante, null))
            {
                ayudante = "Sin ayudante";
            }
            else
            {
                ayudante = String.Format("{0} - {1}", this.Ayudante.Apellido, this.Ayudante.Nombre);
            }
            return String.Format("{0} - {1}  | Ayudante: {2} | {3} | Aspecto: {4} | Escuela: {5} | Semana: {6} | Rechazada: {7}", hermano.Apellido, hermano.Nombre, ayudante, this.MostrarAsignacion(), this.AspectoOratoria, this.Escuela, this.MostrarSemana(), this.MostrarRechazo());

        }
        private string MostrarSemana()
        {
            StringBuilder m = new StringBuilder();
            DateTime aux = this.Semana;
            aux = aux.AddDays(7);
            m.AppendFormat("{0}/{1} - {2}/{3}", this.Semana.Day, this.Semana.Month, aux.Day, aux.Month);
            return m.ToString();
        }
        private string MostrarAsignacion()
        {
            switch (this.Asignacion_)
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
        public Asignacion() {}
        public Asignacion(Hermano hermano, Hermano ayudante, EAsignacion asignacion, int aspectoOratoria, DateTime semana, char escuela):this()
        {
            this.Escuela = escuela;
            this.ayudante = ayudante;
            this.asignacion = asignacion;
            this.aspectoOratoria = aspectoOratoria;
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
            if (a.Hermano == b.Hermano && a.Semana.Year == b.Semana.Year && a.Semana.Month == b.Semana.Month && a.Semana.Day == b.Semana.Day)
                return true;
            return false;
        }
        private string MostrarRechazo()
        {
            if (Rechazada == true)
                return "SI";
            return "NO";
        }
        public static int OrdenarPorFechaAsc(Asignacion a, Asignacion b)
        {
            if (a.Semana > b.Semana)
                return 1;
            if (a.Semana < b.Semana)
                return -1;
            return 0;
        }
        public static int OrdenarPorFechaDesc(Asignacion a, Asignacion b)
        {
            return OrdenarPorFechaAsc(a, b) * (-1);
        }
        
        #endregion

    }
}
