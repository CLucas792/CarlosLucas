using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlosLucas
{
    public partial class CarlosLucas_Ejercicio2_Form : Form
    {
        public CarlosLucas_Ejercicio2_Form()
        {
            InitializeComponent();
        }
        double Subtotal = 0;
        double Descuento = 0;
        double Total = 0;
        int num = 1;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void Ingresarbutton_Click(object sender, EventArgs e)
        {
            if (ArticulotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(ArticulotextBox, "Ingrse la descripcion del articulo");
                return;
            }
            errorProvider1.Clear();

            if (PreciotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(PreciotextBox, "Ingrese el precio del articulo");
                return;
            }
            errorProvider1.Clear();

            if (CantidadtextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CantidadtextBox, "Ingrese la cantidad de articulo");
                return;
            }
            errorProvider1.Clear();

            Subtotal += await SubtotalizarAsync(Convert.ToDouble(CantidadtextBox.Text), Convert.ToDouble(PreciotextBox.Text));
            Descuento = await DescuentoAsync(Subtotal);
            Total = Subtotal - Descuento;
            num++;
            SubtotaltextBox.Text = Subtotal.ToString();
            DescuentotextBox.Text = Descuento.ToString();
            TotaltextBox.Text = Total.ToString();

            FacturadataGridView.Rows.Add(NItemtextBox.Text, ArticulotextBox.Text, PreciotextBox.Text, CantidadtextBox.Text);

            LimpiarControles();
            NItemtextBox.Text = num.ToString();
        }

        private void LimpiarControles()
        {

            ArticulotextBox.Clear();
            PreciotextBox.Clear();
            CantidadtextBox.Clear();
        }

        private async Task<double> SubtotalizarAsync(double Cant, double Precio)
        {
            double Subtotal = await Task.Run(() =>
            {
                return Cant * Precio;
            });
            return Subtotal;
        }

        private async Task<double> DescuentoAsync(double Subtotal)
        {
            double Descuento = await Task.Run(() =>
            {
                return Subtotal * 0.15;
            });
            return Descuento;
        }

        private void FacturadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PreciotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(PreciotextBox, "Ingrese valores numericos");

            }
            else
            {
                e.Handled = false;
                errorProvider1.Clear();

            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CantidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                errorProvider1.SetError(CantidadtextBox, "Ingrese valores numericos");

            }
            else
            {
                e.Handled = false;
                errorProvider1.Clear();

            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
