using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class grafica : Form
    {
        public grafica()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Termporizador.Stop();

            this.Grafico.Series["Chartline"].Points.AddXY("LUNES", 10);
            this.Grafico.Series["Chartline"].Points.AddXY("MARTES", 20);
            this.Grafico.Series["Chartline"].Points.AddXY("MIERCOLES", 40);
            this.Grafico.Series["Chartline"].Points.AddXY("JUEVEZ", 5);
            this.Grafico.Series["Chartline"].Points.AddXY("VIERNES", 32);

        }
    }
}
