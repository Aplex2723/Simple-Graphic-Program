using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Login
{
    public partial class background : Form
    {
        public background()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Estas seguro que quieres salir?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Application.Exit();
                //Some task…  
            }
            if (res == DialogResult.Cancel)
            {
                //Some task…  
            }
            
        }

        private void Btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            max.Visible = true;
            mini.Visible = false;
        }

        private void Max_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            max.Visible = false;
            mini.Visible = true;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (sidebar.Width == 187 )
            {
                sidebar.Width = 61;
                texttop.Hide();
                btnlogout.Hide();
                panelcontenedor.Location = new Point(64, 33);
            }
            else
            {
                sidebar.Width = 187;
                texttop.Show(); 
                btnlogout.Show();
                panelcontenedor.Location = new Point(190, 33);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SteamMexico ss = new SteamMexico();
            this.Hide();
            ss.ShowDialog();
        }

        private void texttop_Click(object sender, EventArgs e)
        {

        }

        private void Grafica_Click(object sender, EventArgs e)
        {

        }

        private void TextGrafica_Click(object sender, EventArgs e)
        {


        }

        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Abrirformhija(object formhija)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();

        }

        private void TextGrafica_MouseClick(object sender, MouseEventArgs e)
        {
            Abrirformhija(new grafica());
        }

        private void TextPerso_MouseClick(object sender, MouseEventArgs e)
        {
            Abrirformhija(new personal());
        }

        private void TextCompras_Click(object sender, EventArgs e)
        {
            Abrirformhija(new compras());
        }

        private void TextPerso_Click(object sender, EventArgs e)
        {

        }
    }
}