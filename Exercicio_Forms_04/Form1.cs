using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Forms_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] valores = {100, 50, 20, 10, 2, 5};
        int[] quantiNotas = new int[6];
        private void button2_Click(object sender, EventArgs e)
        {
            int saque = int.Parse(textBox1.Text);
            if (saque == 1 || saque == 3)
            {
                MessageBox.Show("Valores não permitidos");
            }
            else
            {
                //Verificação se o saque é valor impar
                if (saque % 2 != 0) //aqui se for impar !=
                {
                    quantiNotas[5] = 1;
                    saque -= 5;
                }
                    for (int i = 0; i < valores.Length - 1; i++)
                    {
                        quantiNotas[i] = saque / valores[i];
                        // restou - saque - (quantiNotas * 100)
                        saque = saque % valores[i]; //% pega o resto do valor
                    }
                }
            lbl100.Text = quantiNotas[0].ToString();
            lbl50.Text = quantiNotas[1].ToString();
            lbl20.Text = quantiNotas[2].ToString();
            lbl10.Text = quantiNotas[3].ToString();
            lbl2.Text = quantiNotas[4].ToString();
            lbl5.Text = quantiNotas[5].ToString();    
        }
    }
}
