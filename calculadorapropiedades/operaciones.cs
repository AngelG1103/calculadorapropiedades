using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadorapropiedades
{
    class operaciones
    {
        private float V1;
        private float V2;

        public float V11 { get => V1; set => V1 = value; }
        public float V22 { get => V2; set => V2 = value; }


        public float suma()
        {
            return V1 + V2;
        }

        public float resta()
        {
            return V1 - V2;
        }

        public float multiplicacion()
        {
            return V1 * V2;
        }

        public float division()
        {
            return V1 / V2;
        }
    }
}

