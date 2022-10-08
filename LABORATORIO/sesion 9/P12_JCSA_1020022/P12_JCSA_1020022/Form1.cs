using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P12_JCSA_1020022
{
    public partial class Form1 : Form
    {
        int N;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = 0;
            int B = 0;  
            int C = 0;
            int i = 0;
            string resultado = "";
            try
            {
                //lectura del numero
                N = Convert.ToInt32(textBox1.Text);
                //serie de fibonacci
                A = 0;
                B = 1;
                C = 0;
                i = 2;
                resultado = "";
                if (N>0)
                {
                    //si
                    resultado = Convert.ToString(A);
                    if (N > 1)
                    {
                        //si
                        resultado = resultado +", "+ Convert.ToString(B);
                            while (i < N)
                            {
                                C = A + B;
                                resultado = resultado + ", " + Convert.ToString(C);
                                A = B;
                                B = C;
                                i = i + 1;
                            }
                        label3.Text = resultado;
                    }
                        else
                        {
                            //no
                            label3.Text = resultado;
                        }
                    }
                    else
                    {
                        //no
                        label3.Text = resultado;
                    }

                
            }
            catch (Exception err)
            {
                MessageBox.Show("Debe ingresar un numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Console.WriteLine(err);
            }
        }
    }
}
