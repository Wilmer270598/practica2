using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_prog._III
{
   public sealed class CPeaje:CVehiculo,ITamaño,IColor
    {
        #region ATRIBUTOS
        private string Destino;
        private DateTime Fecha;
        private int Peaje;
        #endregion
        #region PROPIEDADES
        public string p_destino
        {
            get { return Destino; }
            set { Destino = value; }
        }
        public DateTime p_fecha
        {
            get { return Fecha; }
            set { Fecha = value; }

        }
        public int p_peaje
        {
            get { return Peaje; }
            set { Peaje = value; }
        }
        #endregion
        #region CONSTRUCTOR
        public CPeaje()
        {
            p_destino = "COCHABAMBA";
            p_fecha = DateTime.Today;
            p_peaje = 50;
        }
        #endregion
        #region METODOS
        public void Guardar(string Des, DateTime Fec, int Pea, string Pla, string Mar, int Mod)
        {
            p_destino = Des;
            p_fecha = Fec;
            p_peaje = Pea;
            p_placa = Pla;
            p_marca = Mar;
            p_modelo = Mod;
        }
        public void Chico() { }
        public void Mediano() { }
        public void Grande() { }
        public void Verde() { }
        public void Rojo() { }
        public void Azul() { }

        #endregion
    }
}
