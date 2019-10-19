using System;
using System.Collections.Generic;
using System.Text;
using Hermanos;
namespace EntidadesInformes
{
    public class Informe
    {
        #region Campos
        private Hermano hermano;
        private DateTime fecha;
        private int publicaciones;
        private int videos;
        private byte horas;
        private int revisitas;
        private int cursosBiblicos;
        private string comentarios;
        #endregion

        #region Propiedades
        public string Comentarios
        {
            get { return this.Comentarios; }
            set { if(value.Length < 64) { this.comentarios = value; } }
        }
        public byte Horas
        {
            get { return this.horas; }
            set { if (value >= 0 && value < 255) { this.horas = value; } }
        }
        public int Mes { get { return this.fecha.Month; } set { if (value > 0 && value <= 12) { this.fecha.AddMonths(value); } } }
        public int Año { get { return this.fecha.Year; } set { if (value > 0 && value <= 12) { this.fecha.AddYears(value); } } }

        #endregion
        #region Metodos

        public Informe(Hermano hermano,DateTime fecha,int publicaciones,int videos,byte horas,int revisitas,int cursosBiblicos,string comentarios)
        {
            this.hermano = hermano;
            this.Mes = fecha.Month;
            this.Año = fecha.Year;
            this.publicaciones = publicaciones;
            this.videos = videos;
            this.Horas = horas;
            this.revisitas = revisitas;
            this.cursosBiblicos = cursosBiblicos;
            this.Comentarios = comentarios;
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendFormat("Nombre: {0}",this.hermano.MostrarNombreApellido());
            str.AppendFormat("Mes: {0}", this.Mes);
            str.AppendFormat("Año: {0}", this.Año);
            str.AppendFormat("Publicaciones: {0}", this.publicaciones);
            str.AppendFormat("Videos: {0}", this.videos);
            str.AppendFormat("Horas: {0}", this.Horas);
            str.AppendFormat("Revisitas: {0}", this.revisitas);
            str.AppendFormat("Cursos Biblicos: {0}", this.cursosBiblicos);
            return str.ToString();
        }
        public static int OrdenarPorHoras(Informe a,Informe b)
        {
            if (a.Horas == b.Horas)
                return 0;
            if (a.Horas < b.Horas)
                return -1;
            return 1;
        }
        public static int OrdenarPorFecha(Informe a, Informe b)
        {
            if (a.fecha == b.fecha)
                return 0;
            if (a.fecha < b.fecha)
                return -1;
            return 1;
        }
        #endregion

    }
}
