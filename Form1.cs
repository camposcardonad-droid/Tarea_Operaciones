namespace EjercicioOperaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbOperaciones.Items.Add("Suma");
            this.cmbOperaciones.Items.Add("Resta");
            this.cmbOperaciones.Items.Add("Division");
            this.cmbOperaciones.Items.Add("Multiplicacion");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (this.cmbOperaciones.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una operacion.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(this.txtNum1.Text) || string.IsNullOrWhiteSpace(this.txtNum2.Text))
            {
                MessageBox.Show("Debes ingresar numeros.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                double num1 = double.Parse(this.txtNum1.Text);
                double num2 = double.Parse(this.txtNum2.Text);
                double resultado = 0;
                string operacion = this.cmbOperaciones.SelectedItem.ToString();
                switch (operacion)
                {
                    case "Suma":
                        resultado = num1 + num2;
                        break;
                    case "Resta":
                        resultado = num1 - num2;
                        break;
                    case "Division":
                        if (num2 == 0)
                        {
                            MessageBox.Show("No se puede dividir entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        resultado = num1 / num2;
                        break;
                    case "Multiplicacion":
                        resultado = num1 * num2;
                        break;
                }
                this.txtResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Solamente son validos numeros", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
