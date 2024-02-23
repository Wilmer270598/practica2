using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_prog._III
{
    public class CPeajeVector
    {
        #region "Atributos"
        CPeaje[] Vector = new CPeaje[3];
        int Vis;
        #endregion

        #region "Propiedades"
        public int PVis
        {
            get { return Vis; }
            set { Vis = value; }
        }
        #endregion
        #region "constructor"
        public CPeajeVector ()
            {
                PVis = -1;
            }
        #endregion
        #region "Metodos"
        public void Incrementar()
        {
            if (PVis == Vector.Length - 1)
                Array.Resize(ref Vector, Vector.Length + 1);
            PVis++;
        }
        public void GuardarElemento(string Pla, string Mar, int Mod, string Des, DateTime Fec)
        {
            Vector[PVis] = new CPeaje();
            int Pea = ObtenerPeaje(Des);
            Vector[PVis].Guardar(Des, Fec, Pea, Pla, Mar, Mod);
        }
        private int ObtenerPeaje(string Des)
        {
            Random ORan = new Random();
            switch (Des.ToUpper())
            {
                case "COCHABAMBA":
                    return ORan.Next(50, 100);
                case "SUCRE":
                    return ORan.Next(100, 150);
                case "BENI":
                    return ORan.Next(150, 200);
                default:
                    return ORan.Next(200, 250);
            }
        }

        public void MostrarVector(DataGridView Dgv) 
        {
              Dgv.RowCount = PVis + 1;
              for (int Vis1 = 0; Vis1 <= PVis; Vis1++)
              {
               Dgv[0, Vis1].Value = Vector[Vis1].p_placa;
               Dgv[1, Vis1].Value = Vector[Vis1].p_marca;
               Dgv[2, Vis1].Value = Vector[Vis1].p_modelo; 
               Dgv[3, Vis1].Value = Vector[Vis1].p_destino;
               Dgv[4, Vis1].Value = Vector[Vis1].p_fecha.ToShortDateString();
               Dgv[5, Vis1].Value = Vector[Vis1].p_peaje;
              }
        }
        public int TotalPeajeDestino(string DesEleg)
        {
            int Acu = 0;
            for (int Vis1 = 0; Vis1 <= PVis; Vis1++)
                if (Vector[Vis1].p_destino.ToUpper() == DesEleg.ToUpper())
                    Acu += Vector[Vis1].p_peaje;
            return Acu;
        }
        public double PeajePromedioMarca(string MarEleg)
        {
            int Acu = 0; int Con = 0; double Prom;
            for (int Vis1 = 0; Vis1 <= PVis; Vis1++)
                if (Vector[Vis1].p_marca.ToUpper() == MarEleg.ToUpper())
                {
                    Acu += Vector[Vis1].p_peaje;
                    Con++;
                }
            try
            {
                Prom = Acu / Con;
            }
            catch
            {
                Prom = 0;
            }
            return (double)Prom;
        }
        public string PlacaMayorPeajeo()
        {
            int PosMay = 0;
            for (int Vis1 = 1; Vis1 <= PVis; Vis1 ++)
              if (Vector[Vis1].p_peaje > Vector[PosMay].p_peaje)
                PosMay = Vis1;
            return Vector[PosMay].p_placa;
        }
        #endregion
    }
}



    

