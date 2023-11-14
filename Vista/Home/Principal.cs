using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices; //arrastrar formulario
using System.Windows.Forms;
using Agm_Tools.Modulos;

namespace Agm_Tools
{
    public partial class Principal : Form
    {
        private Boolean showPanelVentas = false;
        private Boolean showPanelCalculadora = false;


        public Principal()
        {
            InitializeComponent();
            TogglePanels();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]  
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void TogglePanels()
        {
            if (showPanelVentas) { //Ventas
                panelVentas.Height = 64;
            }
            else
            {
                panelVentas.Height = 0;
            }
            if (showPanelCalculadora) //Calculadora
            {
                panelCalculadora.Height = 64;
            }
            else
            {
                panelCalculadora.Height = 0;
            }

            /*if (showPanelVentas) // Ventas
            {
                panelVentas.Height = 64;
            }
            else
            {
                panelVentas.Height = 0;
            }

            if (showPanelConsultas) // consultas, informe
            {
                panelConsultas.Height = 64;
            }
            else
            {
                panelConsultas.Height = 0;
            }*/
            

        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void panelMenuLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MainCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MainMaximizeBtn_Click(object sender, EventArgs e)
        {
            if  (WindowState == FormWindowState.Normal)
                 WindowState = FormWindowState.Maximized;
            else
                 WindowState = FormWindowState.Normal;          
        }
        private void MainMinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }





        private void label3_Click(object sender, EventArgs e) { }
        

       

        private void menuAlmacen_MouseClick(object sender, MouseEventArgs e)
        {
           // menuVentas.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void menuVentas_Click(object sender, EventArgs e)
        {
            showPanelVentas = !showPanelVentas;

            TogglePanels();
        }

        private void menuCalculadora_Click(object sender, EventArgs e)
        {
            showPanelCalculadora = !showPanelCalculadora;

            TogglePanels();
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panelEspaciado_Paint(object sender, PaintEventArgs e)
        {

        }



        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario = new Form();

            formulario = panel1.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panel1.Controls.Add(formulario);
                panel1.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Cliente>();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Calculadora>();
        }

         private void subMenuProductos_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<Productos>();
        }
    }
}
