using System;
using System.Windows.Forms;

namespace CarlosLucas
{
    public partial class CarlosLucas_Ejercicio1_Form : Form
    {
        public CarlosLucas_Ejercicio1_Form()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            //IntereseslistBox.Items.Add("1");
            CalcularIntereses();
        }

        private void CalcularIntereses()
        {
            int capital;
            double intereses;
            int t;
            double Tasainteres = 0.015;

            DateTime fecha = FechaDepositodateTimePicker.Value;

            if (Cant200radioButton.Checked)
            {
                capital = 200000;
                for (int i = 0; i < 12; i++)
                {
                    t = i + 1;
                    intereses = (capital * Tasainteres * t);
                    IntereseslistBox.Items.Add("El mes de:" + fecha.AddMonths(i).ToString("MMMM") + " genero: " + intereses.ToString("###,###") + " Lps");

                }
            }

        }
    }
}
