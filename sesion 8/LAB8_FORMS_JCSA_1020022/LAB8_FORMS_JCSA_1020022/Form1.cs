using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB8_FORMS_JCSA_1020022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LABELTITULO_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void COMBOBOX_OPCIONES_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(COMBOBOX_OPCIONES.SelectedIndex) 
            {
                case 0:
                    MessageBox.Show("estamos en la opcion 1");
                    tabControl1.SelectedTab = tabPage1;
                    break;

                case 1:
                    MessageBox.Show("estamos en la opcion 2");
                    tabControl1.SelectedTab = tabPage2;
                    break;
                case 2:
                    MessageBox.Show("estamos en la opcion 3");
                    tabControl1.SelectedTab = tabPage3;
                    break;
                case 3:
                    MessageBox.Show("estamos en la opcion 4");
                    tabControl1.SelectedTab = tabPage4;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            int suma = 0;
            int i = 1;
            int n;
            n = Convert.ToInt32(TB_NumeroN.Text);
            do
            {
                suma += i;
                i++;
            }
            while (i <= n);
            LB_RESSUMATORIA.Text = "La suma de los números de 1 al N es:" + suma;
        }

        private void LB_RESSUMATORIA_Click(object sender, EventArgs e)
        {
        }

        private void BT_CALCULARFACTORIAL_Click(object sender, EventArgs e)
        {
            int fac = 1;
            int i = 1;
            int n;
            n = Convert.ToInt32(TB_NUMERONFACTORIAL.Text);
            do
            {
                fac *= i;
                i++;
            }
            while (i <= n);
            LB_RESFACTORIAL.Text = "El factorual del numero N es: " + fac;
        }

        private void BT_TABLAMULTIP_Click(object sender, EventArgs e)
        {
            int num, Tabla, Resultado;
            Tabla = int.Parse(TB_NUMEROMULTIP.Text);
            for (num = 1; num <= 10; num++)
            {
                Resultado = num * Tabla;
                LB_RESTABLASMILTIP.Items.Add(Tabla+ " x "+ num+ " = " + Resultado);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LB_RESTABLASMILTIP.Items.Clear();
            TB_NUMEROMULTIP.Clear();
            TB_NUMEROMULTIP.Focus();
        }

        private void BT_NUMEROPERFECT_Click(object sender, EventArgs e)
        {
            
            int sumaFactores = 0;
            int n;
            n = Convert.ToInt32(TB_NumeroPerfectoN.Text);
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sumaFactores += i;
                }
            }

            if (sumaFactores == n)
            {
                LB_RESNUMPERF.Text = $"El número {n} es perfecto.";
            }
            else
            {
                LB_RESNUMPERF.Text = $"El número {n} no es perfecto.";
            }
        }
    }
}
