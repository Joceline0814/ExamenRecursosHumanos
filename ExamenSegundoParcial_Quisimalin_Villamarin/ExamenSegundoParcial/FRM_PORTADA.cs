using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenSegundoParcial
{
    public partial class FRM_PORTADA : Form
    {
        public FRM_PORTADA()
        {
            InitializeComponent();
        }
        public static void Main()
        {
            ExamenSegundoParcial.FRM_PORTADA PORTADA = new ExamenSegundoParcial.FRM_PORTADA();
            PORTADA.ShowDialog();
        }
        private void FRM_PORTADA_Load(object sender, EventArgs e)
        {

        }

        private void BTN_CLIENTE_Click(object sender, EventArgs e)
        {
           ExamenSegundoParcial.FRM_CLIENTE CLIENTE = new ExamenSegundoParcial.FRM_CLIENTE();
            CLIENTE.Show();
        }

        private void BTN_EMPLEADO_Click(object sender, EventArgs e)
        {
           ExamenSegundoParcial.FRM_EMPLEADO EMPLEADO = new ExamenSegundoParcial.FRM_EMPLEADO();
            EMPLEADO.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
