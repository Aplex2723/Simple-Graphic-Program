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
    public partial class SteamMexico : Form
    {
        public SteamMexico()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Textusuario_Enter(object sender, EventArgs e)
        {
            if (textusuario.Text == "USUARIO")
            {
                textusuario.Text = "";
                textusuario.ForeColor = Color.LightGray;

            }
        }

        private void Textusuario_Leave(object sender, EventArgs e)
        {
            if (textusuario.Text == "")
            {
                textusuario.Text = "USUARIO";
                textusuario.ForeColor = Color.Gray;
            }
        }

        private void Btncerrar_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Btnminimizar_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void Textcontra_Enter(object sender, EventArgs e)
        {
            if (textcontra.Text == "CONTRASEÑA")
            {
                textcontra.Text = "";
                textcontra.ForeColor = Color.LightGray;
                textcontra.PasswordChar = '*';
            }
        }

        private void Textcontra_Leave(object sender, EventArgs e)
        {
            if (textcontra.Text == "")
            {
                textcontra.Text = "CONTRASEÑA";
                textcontra.ForeColor = Color.Gray;

            }
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {

            String contraseña = "1";
            String usuario = "Aplex27";

            String user = textusuario.Text;
            String password = textcontra.Text;
            if (user.Equals(usuario)) {
                if (password.Equals(contraseña))
                {
                    background gui = new background();
                    this.Hide();
                    gui.ShowDialog();
                    
                }
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña incorrectos, pruba intentarlo nuevamente");
            }

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void SteamMexico_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


    }
}
