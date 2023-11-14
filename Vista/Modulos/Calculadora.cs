using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Agm_Tools
{
    public partial class Calculadora : Form
    {
     
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCorteCalcular_Click(object sender, EventArgs e)
        {
            double AnchoPliego = Convert.ToDouble(anchoPliego.Text);  
            double AltoPliego = Convert.ToDouble(altoPliego.Text);    
            double AnchoCorte = Convert.ToDouble(anchoCorte.Text);    
            double AltoCorte = Convert.ToDouble(altoCorte.Text);      
            double Copias = Convert.ToDouble(copias.Text);

            double posibilidadesAncho = AnchoPliego / AnchoCorte;
            double posibilidadesAlto = AltoPliego / AltoCorte;
            double cantCopias = posibilidadesAncho * posibilidadesAlto;
            double pliegosUsados = Copias / cantCopias;

         

            if (Copias < 0)
            {
                MessageBox.Show("Ingrese una cantidad válida de copias.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Redondeo resultados
            posibilidadesAncho = Math.Floor(posibilidadesAncho);
            posibilidadesAlto = Math.Floor(posibilidadesAlto);
            cantCopias = Math.Floor(cantCopias);
            pliegosUsados = Math.Ceiling(pliegosUsados);


            string tipoCorte;
            if (posibilidadesAncho >= posibilidadesAlto)
            {
                tipoCorte = "Corte Horizontal";
            }
            else
            {
                tipoCorte = "Corte Vertical";
            }

            txtCortesVerticales.Text = posibilidadesAncho.ToString();
            txtCortesHorizontales.Text = posibilidadesAlto.ToString();
            txtCantPliegosObtenidos.Text = cantCopias.ToString();
            txtPliegosUsados.Text = pliegosUsados.ToString();
            txtTipoCorte.Text = tipoCorte;
        }

        private void toggleClientesInfo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblPredeterminado_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chMedida4.CheckState == CheckState.Checked)
            {
                chMedida2.CheckState = CheckState.Unchecked;
                chMedida3.CheckState = CheckState.Unchecked;
                chMedida1.CheckState = CheckState.Unchecked;
                chMedida5.CheckState = CheckState.Unchecked;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (chMedida3.CheckState == CheckState.Checked)
            {
                chMedida2.CheckState = CheckState.Unchecked;
                chMedida1.CheckState = CheckState.Unchecked;
                chMedida4.CheckState = CheckState.Unchecked;
                chMedida5.CheckState = CheckState.Unchecked;
            }
        }

        private void iconPictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblAltoPliego_Click(object sender, EventArgs e)
        {

        }

        private void lblAltoCorte_Click(object sender, EventArgs e)
        {

        }

        private void lblCortePerzonalizado_Click(object sender, EventArgs e)
        {

        }

        private void lblAnchoCorte_Click(object sender, EventArgs e)
        {

        }

        private void lblAnchoPliego_Click(object sender, EventArgs e)
        {

        }

        private void MostrarGrafico_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculoPredeterminado_Click(object sender, EventArgs e)
        {
            double AnchoPliego  = 0;
            double AltoPliego   = 0;
            double AnchoCorte   = 0;
            double AltoCorte    = 0;
            double PredCopias = Convert.ToDouble(predCopias.Text);

            // checkbox de medidas de pliego está seleccionado
            if (chMedida1.Checked)
            {
                AnchoPliego  = 59;
                AltoPliego   = 82;
            }
            else if (chMedida2.Checked)
            {
                AnchoPliego  = 63;
                AltoPliego   = 88;
            }
            else if (chMedida3.Checked)
            {
                AnchoPliego  = 65;
                AltoPliego   = 95;
            }
            else if (chMedida4.Checked)
            {
                AnchoPliego  = 72;
                AltoPliego   = 102;
            }
            else if (chMedida5.Checked)
            {
                AnchoPliego  = 82;
                AltoPliego   = 118;
            }
          
            // checkbox de medidas de corte está seleccionado
            if (chA4.Checked)
            {
                AnchoCorte  = 21;
                AltoCorte   = 29.7;
            }
            else if (chA3.Checked)
            {
                AnchoCorte  = 29.7;
                AltoCorte   = 42;
            }
            else if (chA3Plus.Checked)
            {
                AnchoCorte  = 33;
                AltoCorte   = 47;
            }


            if (PredCopias < 0)
            {
                MessageBox.Show("Ingrese una cantidad válida de copias.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            double posibilidadesAncho = AnchoPliego / AnchoCorte;
            double posibilidadesAlto = AltoPliego / AltoCorte;
            double cantCopias = posibilidadesAncho * posibilidadesAlto;           
            double pliegosUsados = PredCopias / cantCopias;

            // Redondeo resultados
            posibilidadesAncho = Math.Floor(posibilidadesAncho);
            posibilidadesAlto = Math.Floor(posibilidadesAlto);
            cantCopias = Math.Floor(cantCopias);
            pliegosUsados = Math.Ceiling(pliegosUsados);
            string tipoCorte;
 
            if (posibilidadesAncho >= posibilidadesAlto)
            {
                tipoCorte = "Corte Horizontal";
            }
            else
            {
                tipoCorte = "Corte Vertical";
            }

            txtCortesVerticales.Text = posibilidadesAncho.ToString();
            txtCortesHorizontales.Text = posibilidadesAlto.ToString();
            txtCantPliegosObtenidos.Text = cantCopias.ToString();
            txtPliegosUsados.Text = pliegosUsados.ToString();
            txtTipoCorte.Text = tipoCorte;           
        }

        private void chMedida1_CheckedChanged(object sender, EventArgs e)
        {
            if (chMedida1.CheckState == CheckState.Checked)
            {
                chMedida2.CheckState = CheckState.Unchecked;
                chMedida3.CheckState = CheckState.Unchecked;
                chMedida4.CheckState = CheckState.Unchecked;
                chMedida5.CheckState = CheckState.Unchecked;
            }
        }

        private void chMedida2_CheckedChanged(object sender, EventArgs e)
        {
            if (chMedida2.CheckState == CheckState.Checked)
            {
                chMedida1.CheckState = CheckState.Unchecked;
                chMedida3.CheckState = CheckState.Unchecked;
                chMedida4.CheckState = CheckState.Unchecked;
                chMedida5.CheckState = CheckState.Unchecked;
            }
        }

        private void chMedida5_CheckedChanged(object sender, EventArgs e)
        {
            if (chMedida5.CheckState == CheckState.Checked)
            {
                chMedida2.CheckState = CheckState.Unchecked;
                chMedida3.CheckState = CheckState.Unchecked;
                chMedida4.CheckState = CheckState.Unchecked;
                chMedida1.CheckState = CheckState.Unchecked;
            }
        }

        private void chA4_CheckedChanged(object sender, EventArgs e)
        {
            if (chA4.CheckState == CheckState.Checked)
            {
                chA3.CheckState = CheckState.Unchecked;
                chA3Plus.CheckState = CheckState.Unchecked;
            }
        }

        private void chA3_CheckedChanged(object sender, EventArgs e)
        {
            if (chA3.CheckState == CheckState.Checked)
            {
                chA4.CheckState = CheckState.Unchecked;
                chA3Plus.CheckState = CheckState.Unchecked;
            }
        }

        private void chA3Plus_CheckedChanged(object sender, EventArgs e)
        {
            if (chA3Plus.CheckState == CheckState.Checked)
            {
                chA3.CheckState = CheckState.Unchecked;
                chA4.CheckState = CheckState.Unchecked;
            }
        }
    }
}
