using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estadistica
{
    public partial class Form1 : Form
    {
        estadistica objestadistica = new estadistica();
   
        public Form1()
           
        {
            InitializeComponent();
        }

        private void btbmediaaritmetica_Click(object sender, EventArgs e)
        {
            //split => dividi una cadena en base a un delimitador (patron) y devuelve una matriz 
            lblrespuesta_serie.Text = "X=" + objestadistica.media(txtserie.Text.Split (','));

        }
    }
}
