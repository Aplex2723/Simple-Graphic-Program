using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Login
{
    public partial class compras : Form
    {
        CN_Prductos objetoCN = new CN_Prductos();
        public compras()
        {
            InitializeComponent();
        }

        private void dataClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void MostrarProductos()
        {
            dataClientes.DataSource = objetoCN.MostrarProd();
        }

        private void compras_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }
    }
}
