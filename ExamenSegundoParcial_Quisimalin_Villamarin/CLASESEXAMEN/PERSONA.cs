using System;
using System.Collections.Generic;
using System.Text;

namespace CLASESEXAMEN
{
   public class PERSONA
    {
        private string APPATERNO;
        private string APMATERNO;
        private string NOMBRE;
        private string NUMSEGSO;
        private string SEXO;
        private string CEDULA;

        // PROPIEDADES
        public string APPATERNO1
        {
            get => APPATERNO; 
            set => APPATERNO = value;
        }
        public string APMATERNO1
        {
            get => APMATERNO; 
            set => APMATERNO = value;
        }
        public string NUMSEGSO1 
        {
            get => NUMSEGSO; 
            set => NUMSEGSO = value; 
        }
        public string SEXO1
        {
            get => SEXO;
            set => SEXO = value; 
        }
        public string CEDULA1
        {
            get => CEDULA; 
            set => CEDULA = value;
        }
        public string NOMBRE1
        {
            get => NOMBRE; 
            set => NOMBRE = value;
        }

        //METODOS, PROCESOS O CALCULOS
        public void GENERARLISTACEDULA ()
        {
            this.CEDULA1 = "LOO" + this.CEDULA1.Substring(5,5);   
        }

    }
}
