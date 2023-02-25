using System;
using System.Windows.Forms;

namespace CarlosLucas
{
    public partial class CarlosLucas_Menu_Form : Form
    {
        public CarlosLucas_Menu_Form()
        {
            InitializeComponent();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarlosLucas_Ejercicio1_Form E1Form = new CarlosLucas_Ejercicio1_Form();
            E1Form.MdiParent = this;
            E1Form.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarlosLucas_Ejercicio2_Form E2Form = new CarlosLucas_Ejercicio2_Form();
            E2Form.MdiParent = this;
            E2Form.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarlosLucas_Ejercicio3_Form E3Form = new CarlosLucas_Ejercicio3_Form();
            E3Form.MdiParent = this;
            E3Form.Show();
        }
    }
}
