using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agm_Tools.Modulos
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbSubcategoria_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;
            ComboBox comboBox = (ComboBox)sender;
            string itemText = comboBox.GetItemText(comboBox.Items[e.Index]);

            Font normal = new Font(comboBox.Font, FontStyle.Regular);

            Brush brush = new SolidBrush(Color.Black);

            Font bold = new Font(comboBox.Font, FontStyle.Bold);

            e.DrawBackground();

            if (e.Index == 0 && e.Index == 15 && e.Index == 26 && e.Index == 36 && e.Index == 42 && e.Index == 49 && e.Index == 55 && e.Index == 60)
            {
                e.Graphics.DrawString(itemText, bold, brush, e.Bounds.X, e.Bounds.Y);
            }
            else
            {
                e.Graphics.DrawString(itemText, normal, brush, e.Bounds.X, e.Bounds.Y);
            }

            e.DrawFocusRectangle();

            normal.Dispose();
            brush.Dispose();      
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
