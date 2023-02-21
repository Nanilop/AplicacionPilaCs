using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionPilaCs.Clases
{
    internal class Pila
    {
        Contacto top;

        public Pila(){
            top = null;
}

        public void Push(Contacto contacto)
        {   if (top == null)
            {
                top = contacto;
                return;
            }
            contacto.Siguiente = top;
            top = contacto;
        }
        public Contacto Pop() {
            if (top != null) {
                Contacto c = top;
                top = top.Siguiente;
                return c;
            }
            return top;
        }
    }
}
