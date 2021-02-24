using System;
using System.Collections.Generic;
using System.Text;

namespace CLASESEXAMEN
{
    public class EMPLEADO: PERSONA
    {
        private string TICONTRATO;
        private double SUELDO;
        private string CEDULAEMPLEADO;
        

        // PROPIEDADES
        public string TICONTRATO1 
        {
            get => TICONTRATO;
            set => TICONTRATO = value;
        }
        public double SUELDO1
        {
            get => SUELDO; 
            set => SUELDO = value;
        }
        public string CEDULAEMPLEADO1 
        {
            get => CEDULAEMPLEADO; 
            set => CEDULAEMPLEADO = value; 
        }

        // METODOS, PROCESOS O CALCULOS
        public void CalcularSueldo(double SueldoPrincipal)
        {
            if (this.TICONTRATO1 == "NUEVO")
            {
                SUELDO = SueldoPrincipal + 500;
            }
            else if(this.TICONTRATO1== "LONGEVO")
                {
                    SUELDO = 2 * SueldoPrincipal + 1500;
                }
            else
            {
                this.SUELDO1 = 0;
            }
            
        }
        public void GenerarListaCedula()
        {
            this.CEDULAEMPLEADO1 = "JK" + this.CEDULAEMPLEADO1.Substring(0, 10);
        }

    }
}
