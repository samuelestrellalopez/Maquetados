using System.Diagnostics.Contracts;

class PilaLigada{
    private Nodo inicial;
    public PilaLigada(){
        inicial = null;
    }

    public void Agrega(object el){
        Nodo nuevo = new Nodo(el, inicial);
        inicial = nuevo;
    }

    public object Retira(){
        object tmp;
        if(vacio())
            return "No hay elementos";
        else
        {
            tmp = inicial.dato;
            inicial = inicial.sig;
            return tmp;
        }
    }
    private bool vacio(){
        if (inicial == null){
            return true;
        }
        return false;
    }    
    public void Imprime(){
        Nodo tmp;

        if (vacio())
        {
            System.Console.WriteLine("NO hay elementos en la pila");
        }
        else
        {
            tmp = inicial;
            do{
                System.Console.WriteLine("----- "+tmp.dato+" ---------");                
                tmp = tmp.sig;
            } while ( tmp != null );
        }
    }

    public object Tope(){
        if (vacio()){
            return "No hay elementos";
        }
        return inicial.dato;
    }
    public bool busqueda(object el)
    {
        Nodo tmp;
        tmp = inicial;
        while ( tmp != null ){
            if ( tmp.dato.Equals(el) ) return true;
            tmp = tmp.sig;
        }
        return false;
    }
}