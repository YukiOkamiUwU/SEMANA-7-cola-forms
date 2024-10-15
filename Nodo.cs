using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_7
{
    internal class Nodo
    {
        private int dato;
        private Nodo sgte;

        public int Dato { get => dato; set => dato = value; }
        internal Nodo Sgte { get => sgte; set => sgte = value; }
    }
}
