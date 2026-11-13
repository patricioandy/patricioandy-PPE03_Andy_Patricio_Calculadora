using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        // Variables globales de la calculadora
        private double primerNumero = 0;
        private double segundoNumero = 0;
        private double resultado = 0;
        private string operacion = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // 1. Evento unificado para los botones de números (0 al 9) y el punto decimal (.)
        private void BotonNumero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            // Si la pantalla tiene solo "0", lo reemplazamos; de lo contrario, concatenamos
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = boton.Text;
            }
            else
            {
                txtPantalla.Text += boton.Text;
            }
        }

        // 2. Evento para los botones de operaciones (+, -, ×, ÷)
        private void BotonOperacion_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            // Validar que exista un número válido en pantalla antes de guardar el operador
            if (!double.TryParse(txtPantalla.Text, out primerNumero))
            {
                MessageBox.Show("Por favor, ingrese un número válido antes de seleccionar una operación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            operacion = boton.Text;
            txtPantalla.Clear();
        }

        // 3. Evento para el botón de resultado (=)
        private void btnIgual_Click(object sender, EventArgs e)
        {
            // Evitar operaciones incompletas si no hay un operador previo
            if (string.IsNullOrEmpty(operacion))
            {
                MessageBox.Show("No hay ninguna operación pendiente por realizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el segundo número ingresado sea correcto
            if (!double.TryParse(txtPantalla.Text, out segundoNumero))
            {
                MessageBox.Show("Por favor, ingrese un segundo número válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Realizar la operación matemática correspondiente
            switch (operacion)
            {
                case "+":
                    resultado = primerNumero + segundoNumero;
                    break;

                case "-":
                    resultado = primerNumero - segundoNumero;
                    break;

                case "×":
                    resultado = primerNumero * segundoNumero;
                    break;

                case "÷":
                    // Control estricto de división por cero
                    if (segundoNumero == 0)
                    {
                        MessageBox.Show("No es posible dividir para cero.", "Error matemático", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    resultado = primerNumero / segundoNumero;
                    break;
            }

            // Mostrar el resultado final en la pantalla y resetear el operador
            txtPantalla.Text = resultado.ToString();
            operacion = "";
        }

        // 4. Botón de limpieza total (AC / C)
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            primerNumero = 0;
            segundoNumero = 0;
            resultado = 0;
            operacion = "";
        }

        // 5. Botón de retroceso / borrado de último dígito (btnBorrar)
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length > 0)
            {
                txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1);

                // Si borramos todo o solo queda un signo menos, dejamos la pantalla en "0"
                if (txtPantalla.Text == "" || txtPantalla.Text == "-")
                {
                    txtPantalla.Text = "0";
                }
            }
        }
    }
}
