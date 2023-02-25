using System;
using System.Windows.Forms;

namespace CarlosLucas
{
    public partial class CarlosLucas_Ejercicio3_Form : Form
    {
        public CarlosLucas_Ejercicio3_Form()
        {
            InitializeComponent();
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            CrearNumeracion();
        }

        private void CrearNumeracion()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    NumeracionlistBox.Items.Add("Carlos Lucas");

                }
                else if (i % 3 == 0)
                {
                    NumeracionlistBox.Items.Add("Carlos");

                }
                else if (i % 5 == 0)
                {
                    NumeracionlistBox.Items.Add("Lucas");
                }
                else
                {
                    NumeracionlistBox.Items.Add(i);
                }

            }
        }
    }
}
