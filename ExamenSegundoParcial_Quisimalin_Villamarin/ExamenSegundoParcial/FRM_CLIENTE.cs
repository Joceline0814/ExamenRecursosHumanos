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
    public partial class FRM_CLIENTE : Form
    {
        public FRM_CLIENTE()
        {
            InitializeComponent();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            CLASESEXAMEN.CLIENTE CLIENTE1 = new CLASESEXAMEN.CLIENTE();
            CLIENTE1.APPATERNO1 = TXT_APPATERNO.Text;
            CLIENTE1.APMATERNO1 = TXT_APMATERNO.Text;
            CLIENTE1.NOMBRE1 = TXT_NOMBRES.Text;
            CLIENTE1.CEDULACLIENTES1 = TXT_CEDULA.Text;
            CLIENTE1.SEXO1 = CMB_SEXO.Text;
            CLIENTE1.NUMSEGSO1 = TXT_NUMSEGSO.Text;
            CLIENTE1.CATEGORIA1 = CMB_CATEGORIA.Text;
            CLIENTE1.GenerarCodidgoPedido();
            TXT_CODPEDI.Text = CLIENTE1.CODIGOPEDIDO1;
            DGV_CLIENTES.Rows.Insert(0, CLIENTE1.CEDULACLIENTES1, CLIENTE1.APPATERNO1, CLIENTE1.APMATERNO1, CLIENTE1.NOMBRE1, CLIENTE1.NUMSEGSO1, CLIENTE1.SEXO1, CLIENTE1.CATEGORIA1, CLIENTE1.CODIGOPEDIDO1);

        }
    }
}
