using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRJPesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void btnPesoIdeal_Click(object sender, EventArgs e)
        {
            try
            {
                double altura = 0, pesoIdeal = 0;
                altura = double.Parse(txtAltura.Text);
                if (cmbSexo.Text == "F")
                {
                    pesoIdeal = (62.7 * altura) - 44.7;
                    MessageBox.Show(txtNome.Text + " seu peso ideal é: " + pesoIdeal.ToString() + " Kg",
                        "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbSexo.Text == "M")
                {

                    pesoIdeal = (72.7 * altura) - 58;
                    MessageBox.Show(txtNome.Text + " seu peso ideal é: " + pesoIdeal.ToString() + " Kg",
                       "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Escolha o sexo", "Peso Ideal", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Verifique os valores informados", "Peso Ideal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAltura.Clear();
            cmbSexo.Text = "";
            txtNome.Focus();
        }
    }
}
