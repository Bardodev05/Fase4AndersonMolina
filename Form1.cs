using System;
using System.Windows.Forms;

namespace Fase4NombreApellido
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string contrasenaIngresada = txtContrasena.Text;

            // Verificar si está vacío
            if (string.IsNullOrWhiteSpace(contrasenaIngresada))
            {
                MessageBox.Show("Por favor ingrese la contraseña.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si la contraseña está en minúsculas
            if (contrasenaIngresada == "unad")
            {
                MessageBox.Show("La contraseña debe estar en MAYÚSCULAS.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Verificar si la contraseña es incorrecta
            if (contrasenaIngresada != "UNAD")
            {
                MessageBox.Show("Contraseña incorrecta.\n\nAsegúrese de ingresar:\n- En mayúsculas\n- Sin espacios al inicio o al final",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si la contraseña es correcta
            MessageBox.Show("¡Contraseña correcta! Accediendo al sistema...", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Abrir el formulario principal
            frmPrincipal principal = new frmPrincipal();
            principal.Show();

            // Ocultar el formulario actual
            this.Hide();
        }
    }
}