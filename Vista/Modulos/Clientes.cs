using System;
using System.Windows.Forms;

namespace Agm_Tools
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }



        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;

            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten números sin guiones", "validación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            CargarTodo();
        }

        private void CargarTodo()
        {
            ConexionSQL buscar = new ConexionSQL();
            dgvLista.DataSource = buscar.CargasTodos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionSQL actualizar = new ConexionSQL();

            actualizar.Actualizar(txtCuit.Text.Trim(), txtApellido.Text.Trim(), txtNombre.Text.Trim(), cmbTipoCons.Text.Trim(), txtdirec.Text.Trim(), txtTel.Text.Trim(), txtTel2.Text.Trim(), txtEmail.Text.Trim());

            CargarTodo();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            ConexionSQL buscar = new ConexionSQL();

            dgvLista.DataSource = buscar.Buscar(txtApellido.Text);
        }

        private void materialSwitch1_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void descripcionClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClienteEliminar_Click(object sender, EventArgs e)
        {
            ConexionSQL eliminar = new ConexionSQL();

            string cuit = dgvLista.CurrentRow.Cells[0].Value.ToString();

            eliminar.Eliminar(cuit);

            CargarTodo();
        }

        private void cmbTipoCons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClienteRegistrar_Click(object sender, EventArgs e)
        {
            ConexionSQL Registrar = new ConexionSQL();

            Registrar.Registrar(txtCuit.Text.Trim(), txtApellido.Text.Trim(), txtNombre.Text.Trim(), cmbTipoCons.Text.Trim(), txtdirec.Text.Trim(), txtTel.Text.Trim(), txtTel2.Text.Trim(), txtEmail.Text.Trim());

            CargarTodo();
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar)){
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar)){
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo números sin guiones, sin 0 ni 15", "validación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTel2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
                MessageBox.Show("Solo números sin guiones, sin 0 ni 15", "validación de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCuit.Text = dgvLista.Rows[dgvLista.CurrentCell.RowIndex].Cells[0].Value.ToString();
            txtApellido.Text = dgvLista.Rows[dgvLista.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtNombre.Text = dgvLista.Rows[dgvLista.CurrentCell.RowIndex].Cells[2].Value.ToString();
            cmbTipoCons.Text = dgvLista.Rows[dgvLista.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtdirec.Text = dgvLista.Rows[dgvLista.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtTel.Text = dgvLista.Rows[dgvLista.CurrentCell.RowIndex].Cells[5].Value.ToString();
            txtTel2.Text = dgvLista.Rows[dgvLista.CurrentCell.RowIndex].Cells[6].Value.ToString();
            txtEmail.Text = dgvLista.Rows[dgvLista.CurrentCell.RowIndex].Cells[7].Value.ToString();
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            ConexionSQL actualizar = new ConexionSQL();

            actualizar.Actualizar(txtCuit.Text.Trim(), txtApellido.Text.Trim(), txtNombre.Text.Trim(), cmbTipoCons.Text.Trim(), txtdirec.Text.Trim(), txtTel.Text.Trim(), txtTel2.Text.Trim(), txtEmail.Text.Trim());

            CargarTodo();
        }
    }
}
