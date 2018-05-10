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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OLA MUNDO");
            MessageBox.Show("a soma e: "+(2+2));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomeDoUsuario = txnome.Text;
            string sobrenomeDoUsuario = txSobrenoma.Text;
            MessageBox.Show(nomeDoUsuario + "  " + sobrenomeDoUsuario);
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            double nota1 = 0;
            try
            {
                 nota1 = Convert.ToDouble(txtNota1.Text);
            }
            catch
            {
                MessageBox.Show("nota 1 deve conter numero");
                txtNota1.Focus();
                return;
            }
            double nota2;
            try
            {
                 nota2 = Convert.ToDouble(txtnota2.Text);
            }
            catch
            {
                MessageBox.Show("nota 2 deve conter numero");
                txtnota2.Focus();
                return;
            }
            double nota3;
            try
            {
                 nota3 = Convert.ToDouble(txtnota3.Text);
            }
            catch
            {
                MessageBox.Show("nota 3 deve conter numero");
                txtnota3.Focus();
                return;
            }
             double nota4 ;
            try
            {
                 nota4 = Convert.ToDouble(txtnoted4.Text);
            }
            catch
            {
                MessageBox.Show("nota 4 deve conter numero");
                txtnoted4.Focus();
                return;
            }

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            string txta=string.Format(
                "nota1:{0}\r\nNota2:{1}\r\nNota3:{2}\r\nNota4{3}",
                nota1,nota2,nota3,nota4,media);
            txtResultado.text=txta;
           // MessageBox.Show(string.Format9"media : {0:n}",media);
        }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try{
                int idade=Convert.ToInt32(txtIdade.Text);
                if(idade<0);{
                    MessageBox.Show("idade nao pode ser menor que 0 ");
                    txtIdade.Focus();
                    return;
                }
                if(idade>150){
                    MessageBox.Show("idade nao pode ser maior que 150");
                    txtIdade.Focus();
                    return;
                }
                catch{
                    MessageBox.Show("somente numero intiroi");
                    txtIdade.Focus();
                }

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        }
       
    }
}
