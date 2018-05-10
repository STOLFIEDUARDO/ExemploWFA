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
    public partial class Exemplo03 : Form
    {
        public Exemplo03()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (rbSomar.Checked)
            {
                somar();
            }
        }
        public void somar()
        {
            int quantidade1 = Convert.ToInt32(nUDqnt1.Value);
            double valor1 = Convert.ToDouble(mtbValor1.Text);

            int quantidade2 = Convert.ToInt32(nUDqnt2.Value);
            double valor2 = Convert.ToDouble(mtbValor2.Text);

            int quantidade3 = Convert.ToInt32(nUDqnt3.Value);
            double valor3 = Convert.ToDouble(mtbValor3.Text);

            double total = (quantidade1 * valor1) +
            (quantidade2 * valor2) + (quantidade3 * valor3);
            MessageBox.Show("Soma: " + total);
        
        }
    }
}
