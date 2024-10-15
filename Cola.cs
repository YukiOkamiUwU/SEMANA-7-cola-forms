using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMANA_7
{
    internal class Cola
    {
        Nodo pri, ulti;
        private int cant = 0;
       public Cola() 
        {
            pri=null;
            ulti=null;
        }

        public void Encolar(int dato) 
        {
            Nodo nuevo = new Nodo();

            nuevo.Dato = dato;
            if (Buscar(dato)) MessageBox.Show("Que fue mano? ya existe");
            else if (dato <= 9 || dato>=100) MessageBox.Show("Ingrese edad de 2 digitos");
            else if (pri == null)
            {
                pri = nuevo;
                ulti = nuevo;
                ulti.Sgte = null;
            }
            else
            {
                ulti.Sgte = nuevo;
                ulti = nuevo;
                ulti.Sgte = null;

            }
            cant++;
        }
        public void DesEncolar() 
        {
            if (pri == null) MessageBox.Show("La cola esta vacia :c");
            else pri = pri.Sgte;
            cant--;
        }

        public void Listar(ListBox lista) 
        {
            Nodo actual=pri;

            while (actual != null) 
            {
                lista.Items.Add(actual.Dato);
                actual= actual.Sgte;
            }

        }
        public bool Buscar(int dato) 
        {
            Nodo actual = pri;
            while (actual != null) 
            {
                if(actual.Dato == dato) return true;
                 actual = actual.Sgte;  

            }
            return false;
        }

        public void Modificar(int d1, int d2) 
        {
            Nodo actual = pri;
            while (actual != null)
            {
                if (actual.Dato == d1) actual.Dato = d2;

                actual = actual.Sgte;
            }

        }
        public void Contar()
        {
            Nodo actual = pri;

            int cant = 0;
            double suma = 0.0;
            int mayor = actual.Dato;
            while (actual != null) 
            {
                cant++;
                suma += actual.Dato;
                if (actual.Dato > mayor) mayor = actual.Dato; 
                actual=actual.Sgte;
            }
            MessageBox.Show("La cola tiene: " + cant + "elementos"+" \nel promedio es: "+suma/cant + "\nel numero mayor es: "+mayor);

        }
        

    }
}
