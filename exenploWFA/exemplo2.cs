using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exenploWFA
{
    public partial class exemplo2 : Form
    {
        public exemplo2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDataDeNacimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            int quantidadedeHoras = Convert.ToInt32(label1.Text);
            double ValorHora = Convert.ToDouble(textBox3.Text);


            string unidadeFeterativa = unidadeFeterativa.SerlectedValue.ToString();
            string cidade = cidade.Text.Trim();
            
            string bairo = txtBairro.Text.Trim();
            string logradouro = txtlgradouro.Text.Trim();
            string complemento = txtcomplemento.Text.Trim();
            string nomero = txtnome.Text.Trim();
            bool ehFemia = edfemia.checked;
            string dadadeNacsimento = txtidade.Text.Trim();
            int salario = 0;
            if(salario<100)
            {
                MessageBox.Show("Professdor de lol");
            }
            else if(salario<1000){
                MessageBox.Show("professor de fort");
            }
            else if(salario<10000){
                MessageBox.Show("professor de dota2");
            }
            else if(salario<500000){
               MessageBox.Show("professor junior de tibia");
            }
            else {
                MessageBox.Show("professor pleno tibia ");
            }
        }
    }
}
