using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using proyecto_final_prog;
namespace proyecto_final_prog._III
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CPeajeVector OPeaje = new CPeajeVector();
        //private void gUARDARToolStripMenultem_Click(object sender, EventArgs e)
        //{
        //    OPeaje.Incrementar();
        //    OPeaje.GuardarElemento(Pla.Text, Mar.Text, (int)Mod.Value, Des.Text, Fec.Value);
        //    OPeaje.MostrarVector(Dgv);
        //}
        //private void totalPeajeDelDestinoElegidoToolStripMenu1tem_Click(object sender, EventArgs e)
        //{
        //    Salida1.Text = OPeaje.TotalPeajeDestino(Des.Text).ToString();
        //}
        //private void peajePromedioDeLaMarcaElegidaToolStripMenu1tem_Click(object sender, EventArgs e)
        //{
        //    Salida2.Text = OPeaje.PeajePromedioMarca(Mar.Text).ToString();
        //}
        //private void placaDelVeliiculoQuePagóElMayorPeajeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    label8.Text = OPeaje.PlacaMayorPeajeo();
        //}

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OPeaje.Incrementar();
            OPeaje.GuardarElemento(Pla.Text, Mar.Text, (int)Mod.Value, Des.Text, Fec.Value);
            OPeaje.MostrarVector(Dgv);
        }

        private void tOTALPEAJEDELDESTINOELEGIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salida1.Text = OPeaje.TotalPeajeDestino(Des.Text).ToString();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Salida2.Text = OPeaje.PeajePromedioMarca(Mar.Text).ToString();
        }

        private void pLACADELVEHICULOQUEPAGOMAYORPEAJEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label8.Text = OPeaje.PlacaMayorPeajeo();
        }

        private void Pla_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MostrarHora();
        }
        private void MostrarHora()
        {
           // labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void labelHora_TextChanged(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}