using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_prog._III
{
      public abstract class CVehiculo
        {
            #region ATRIBUTOS
            private string placa;
            private string marca;
            private int modelo;
            #endregion
            #region PROPIEDADES
            public string p_placa
            {
                get { return placa; }
                set { placa = value; }
            }
            public string p_marca
            {
                get { return marca; }
                set { marca = value; }
            }
            public int p_modelo
            {
                get { return modelo; }
                set { modelo = value; }
            }
            #endregion
            #region CONSTRUCTOR
            public CVehiculo()
            {
                p_placa = "SCZ-001";
                p_marca = "Toyota";
                p_modelo = 2009;
            }
            #endregion
            #region Metodos
            public void Guardar(string pla, string mar, int mod)
            {
                p_placa = pla;
                p_marca = mar;
                p_modelo = mod;
            }
            #endregion
        }
    }
