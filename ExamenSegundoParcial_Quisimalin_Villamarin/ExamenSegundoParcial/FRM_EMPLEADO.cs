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
    public partial class FRM_EMPLEADO : Form
    {
        public FRM_EMPLEADO()
        {
            InitializeComponent();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            CLASESEXAMEN.EMPLEADO EMPLEADO1 = new CLASESEXAMEN.EMPLEADO();

            EMPLEADO1.CEDULAEMPLEADO1 = TXT_CEDULA.Text;
            EMPLEADO1.GenerarListaCedula();
            EMPLEADO1.APPATERNO1 = TXT_APPATERNO.Text;
            EMPLEADO1.APMATERNO1 = TXT_APMATERNO.Text;
            EMPLEADO1.NOMBRE1 = TXT_NOMBRES.Text;
            EMPLEADO1.NUMSEGSO1 = TXT_NUMSEGSO.Text;
            EMPLEADO1.SEXO1 = CMB_SEXO.Text;
            EMPLEADO1.TICONTRATO1 = CMB_TIPCONTRATO.Text;
            EMPLEADO1.CalcularSueldo(750);
            DGV_EMPLEADOS.Rows.Insert(0, EMPLEADO1.CEDULAEMPLEADO1, EMPLEADO1.APPATERNO1, EMPLEADO1.APMATERNO1, EMPLEADO1.NOMBRE1, EMPLEADO1.NUMSEGSO1, EMPLEADO1.SEXO1, EMPLEADO1.TICONTRATO1,EMPLEADO1.SUELDO1); ;
        
    }

        private void CMB_EMPLEADO_Enter(object sender, EventArgs e)
        {

        }
    }
}
