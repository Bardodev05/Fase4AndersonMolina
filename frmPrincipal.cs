using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Fase4NombreApellido
{
    public partial class frmPrincipal : Form
    {
        private ArbolBinario arbol;

        public frmPrincipal()
        {
            InitializeComponent();
            arbol = new ArbolBinario();
            pnlArbol.Paint += PnlArbol_Paint; 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(txtValor.Text.Trim());
                if (!arbol.Existe(valor))
                {
                    arbol.Insertar(valor);
                    ActualizarRecorridos();
                }
                else
                {
                    MessageBox.Show("El valor ya existe en el árbol.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtValor.Clear();
                txtValor.Focus();
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtValor.Clear();
                txtValor.Focus(); // Enfocar el TextBox
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(txtValor.Text.Trim());
                if (arbol.Existe(valor))
                {
                    MessageBox.Show($"El valor {valor} sí existe en el árbol.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"El valor {valor} NO existe en el árbol.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ingrese un número entero válido.", "Dato no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ActualizarRecorridos()
        {
            LimpiarPaneles();

            var preorden = arbol.Preorden().Split(' ');
            var inorden = arbol.Inorden().Split(' ');
            var postorden = arbol.Postorden().Split(' ');

            AgregarNodosAlPanel(flowPreorden, preorden);
            AgregarNodosAlPanel(flowInorden, inorden);
            AgregarNodosAlPanel(flowPostorden, postorden);

            pnlArbol.Invalidate(); // Redibujar árbol
        }

        private void LimpiarPaneles()
        {
            flowPreorden.Controls.Clear();
            flowInorden.Controls.Clear();
            flowPostorden.Controls.Clear();
        }

        private void AgregarNodosAlPanel(FlowLayoutPanel panel, string[] valores)
        {
            panel.Controls.Clear();
            panel.AutoScroll = true; // Habilitar scroll automático

            foreach (var valor in valores)
            {
                if (string.IsNullOrEmpty(valor)) continue;

                Label lbl = new Label
                {
                    Text = valor,
                    AutoSize = true, // Ajusta el tamaño automáticamente
                    Margin = new Padding(2),
                    Padding = new Padding(3),
                    BackColor = Color.LightBlue,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };

                panel.Controls.Add(lbl);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            // Evento de clic en los botones de recorrido (opcional)
        }

        private void PnlArbol_Paint(object sender, PaintEventArgs e)
        {
            Nodo raiz = arbol.Raiz;
            if (raiz == null)
            {
                e.Graphics.Clear(pnlArbol.BackColor);
                using (Font font = new Font("Arial", 9))
                using (Brush brush = new SolidBrush(Color.Gray))
                {
                    string mensaje = "Árbol vacío";
                    SizeF size = e.Graphics.MeasureString(mensaje, font);
                    float x = (pnlArbol.Width - size.Width) / 2;
                    float y = (pnlArbol.Height - size.Height) / 2;
                    e.Graphics.DrawString(mensaje, font, brush, x, y);
                }
                return;
            }

            List<NodoPosicionado> nodos = ObtenerPosicionesPorNiveles(arbol.Raiz, pnlArbol.Width, pnlArbol.Height);

            // Calcular tamaño necesario y asignarlo para el scroll
            int maxY = 0;
            foreach (var np in nodos)
            {
                DibujarConexion(e.Graphics, np);
                DibujarNodo(e.Graphics, np, 20);

                if (np.Y > maxY)
                    maxY = np.Y;
            }

            pnlArbol.AutoScrollMinSize = new Size(0, maxY + 80); // Ajusta para dejar espacio
        }


        private List<NodoPosicionado> ObtenerPosicionesPorNiveles(Nodo raiz, int anchoPanel, int altoPanel)
        {
            List<NodoPosicionado> resultado = new List<NodoPosicionado>();
            Queue<(Nodo nodo, int nivel, int x)> cola = new Queue<(Nodo, int, int)>();

            int espacioPorNivel = anchoPanel / 8;
            cola.Enqueue((raiz, 0, anchoPanel / 2));

            while (cola.Count > 0)
            {
                var (nodo, nivel, x) = cola.Dequeue();
                int y = 30 + nivel * 60;

                resultado.Add(new NodoPosicionado(nodo, x, y));

                int desplazamiento = espacioPorNivel / (int)Math.Pow(2, nivel);
                if (nivel == 4) desplazamiento += 20; // Incrementar espacio en el nivel 4
                if (nivel < 4)
                {
                    if (nodo.Izquierda != null)
                        cola.Enqueue((nodo.Izquierda, nivel + 1, Math.Max(30, x - desplazamiento)));
                    if (nodo.Derecha != null)
                        cola.Enqueue((nodo.Derecha, nivel + 1, Math.Min(anchoPanel - 30, x + desplazamiento)));
                }
            }

            return resultado;
        }


        private void DibujarConexion(Graphics g, NodoPosicionado np)
        {
            if (np.Nodo.Izquierda != null)
            {
                var hijo = BuscarNodo(np.Nodo.Izquierda, np.X, np.Y + 60);
                g.DrawLine(Pens.Black, np.X, np.Y + 20, hijo.X, hijo.Y);
            }

            if (np.Nodo.Derecha != null)
            {
                var hijo = BuscarNodo(np.Nodo.Derecha, np.X, np.Y + 60);
                g.DrawLine(Pens.Black, np.X, np.Y + 20, hijo.X, hijo.Y);
            }
        }

        private void DibujarNodo(Graphics g, NodoPosicionado np, int radio)
        {
            int x = np.X;
            int y = np.Y;

            g.FillEllipse(Brushes.LightBlue, x - radio, y - radio, radio * 2, radio * 2);
            g.DrawEllipse(Pens.Black, x - radio, y - radio, radio * 2, radio * 2);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            g.DrawString(np.Nodo.Valor.ToString(), new Font("Arial", 9), Brushes.Black,
                new Rectangle(x - radio, y - radio, radio * 2, radio * 2), sf);
        }

        private NodoPosicionado BuscarNodo(Nodo objetivo, int xBase, int yBase)
        {
            foreach (var np in ObtenerPosicionesPorNiveles(arbol.Raiz, pnlArbol.Width, pnlArbol.Height))
            {
                if (np.Nodo == objetivo)
                    return np;
            }
            return new NodoPosicionado(objetivo, xBase, yBase);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea salir de la aplicación?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); // Cierra toda la aplicación
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            arbol = new ArbolBinario();  // Reiniciar el árbol
            LimpiarPaneles();            // Limpiar Preorden, Inorden y Postorden
            pnlArbol.Invalidate();       // Redibujar el panel (lo dejará vacío)
            txtValor.Clear();            // Limpiar TextBox
            txtValor.Focus();            // Devolver foco
        }
    }

    public class NodoPosicionado
    {
        public Nodo Nodo { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public NodoPosicionado(Nodo nodo, int x, int y)
        {
            Nodo = nodo;
            X = x;
            Y = y;
        }
    }
}