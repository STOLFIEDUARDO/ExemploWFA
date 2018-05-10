using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OLÁ MUNDO");
            MessageBox.Show("A soma é: " + (2 + 2));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            string nomeDoUsuario = txtNome.Text;
            string sobreNomeDoUsuario = txtSobrenome.Text;
            MessageBox.Show(nomeDoUsuario + " " + sobreNomeDoUsuario);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btMedia_Click(object sender, EventArgs e)
        {
            double nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0;
            try
            {
                nota1 = Convert.ToDouble(txtNota1.Text);
            }
            catch
            {
                MessageBox.Show("Nota 1 deve conter números reais");

                txtNota1.Focus();
                return;
            }
            try
            {
                nota2 = Convert.ToDouble(txtNota2.Text);
            }
            catch
            {
                MessageBox.Show("Nota 2 deve conter números reais");

                txtNota2.Focus();
                return;
            }
            try
            {
                nota3 = Convert.ToDouble(txtNota3.Text);
            }
            catch
            {
                MessageBox.Show("Nota 3 deve conter números reais");

                txtNota3.Focus();
                return;
            }
            try
            {
                nota4 = Convert.ToDouble(txtNota4.Text);
            }
            catch
            {
                MessageBox.Show("Nota 4 deve conter números reais");

                txtNota4.Focus();
                return;
            }




            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            string textao = string.Format("Nota 1: {0}\r\nNota 2: {1}\r\nNota 3: {2}\r\nNota 4: {3}\r\n\nMédia: {4}", nota1, nota2, nota3, nota4, media);
            txtResultado.Text = textao;



            // MessageBox.Show(string.Format("A Média é: {0:n}", media));





        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idade = Convert.ToInt32(txtIdade.Text);
                if (idade < 0)
                {
                    MessageBox.Show("Idade não Pode ser menor que 0");
                    txtIdade.Focus();
                    return;
                }
                if (idade > 150)
                {
                    MessageBox.Show("Idade não Pode ser maior que 150");
                    txtIdade.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Idade deve conter somente números inteiros");
                txtIdade.Focus();

            }

        }
    }

}