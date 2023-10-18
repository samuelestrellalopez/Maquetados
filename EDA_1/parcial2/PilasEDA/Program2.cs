
using System;
using System.Collections.Generic;
using System.Text;

class Nodo{
    public object dato;
    public Nodo sig;

    public Nodo(object el, Nodo els){
        dato = el;
        sig = els;
    }

}