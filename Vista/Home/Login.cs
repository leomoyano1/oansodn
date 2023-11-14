using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //arrastrar formulario
using Microsoft.Data.SqlClient;


namespace Agm_Tools
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconPictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            NewLogin();
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario"){
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == ""){
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "******"){
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == ""){
                txtPassword.Text = "******";
                txtPassword.ForeColor = Color.Silver;
                
            }
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            //imagen ocultar va al frente
            ocultar.BringToFront();
            //mostrar contraseña
            txtPassword.PasswordChar = '*';

        }

        private void ocultar_Click(object sender, EventArgs e)
        {
            mostrar.BringToFront();
            txtPassword.PasswordChar = '\0';
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void NewLogin()
        {
            ConexionSQL conexionSQL = new ConexionSQL();
                Principal main = new Principal();

            if(conexionSQL.Login(txtUsuario.Text, txtPassword.Text)) {
                main.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
        }
    }  
}