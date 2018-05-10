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
    public partial class Exemplo02 : Form
    {
        public Exemplo02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            int quantidadedeHoras = Convert.ToInt32(txtQntHoras.Text.Trim());
            string nome = txtNome.Text.Trim();
            double valorHora = Convert.ToDouble(txtValorHora.Text.Trim());

            string unidadeFederativa = cbUnidadeFederativa.SelectedItem.ToString();
            string cidade = txtCidade.Text.Trim();
            string bairro = txtBairro.Text.Trim();
            string logradouro = txtLogradouro.Text.Trim();
            string complemento = txtComplemento.Text.Trim();
            string numero = txtNumero.Text.Trim();
            bool ehFemea = rbFemea.Checked;
            string dataDeNascimento = dtpDataNascimento.Text;

            double salario = quantidadedeHoras * valorHora;
            if (salario < 1000)
            {
                MessageBox.Show("Professor de LOL: " + salario);
            }
            else if (salario < 10000)
            {
                MessageBox.Show("Professor de Fortnite");
            }
            else if (salario < 100000)
            {
                MessageBox.Show("Professor de Dota 2");
            }
            else if (salario < 500000)
            {
                MessageBox.Show("Mestre Junior de Tíbia");
            }
            else 
            {
                MessageBox.Show("Mestre Pleno de Tíbia");
            }


        }
    }
}
