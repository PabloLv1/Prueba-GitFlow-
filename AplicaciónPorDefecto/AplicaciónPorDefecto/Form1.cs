using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicaciónPorDefecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vector = {textBox1.Text.};
            
        }

        void ordenamiento(int[] VectorEnviado)
        {
            int aux = 0;

            for(int i = 0; i< VectorEnviado.Length - 1; i++)
            {

                for (int j = 0; i < VectorEnviado.Length - 1; j++)
                {

                    if (VectorEnviado[j] > VectorEnviado[j+1])
                    {
                        aux = VectorEnviado[j];
                        VectorEnviado[j] = VectorEnviado[j + 1];
                        VectorEnviado[j + 1] = aux;

                    }

                }

            }
        }

        //********************************************************
        //********************************************************
        //********************************************************

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
