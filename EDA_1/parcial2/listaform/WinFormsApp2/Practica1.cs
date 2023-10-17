using System;
using System.Collections.Generic;
using System.Linq;

public class Articulo
{
    public string Nombre { get; set; }
    public int ID { get; set; }
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }

    public Articulo(int id, string nombre, decimal precio, int cantidad)
    {
        ID = id;
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
    }
}

public class GestorArticulos
{
    private List<Articulo> articulosDisponibles = new List<Articulo>();
    private List<Articulo> articulosRetirados = new List<Articulo>();
    private Random random = new Random();

    public void AgregarArticuloAleatorio()
    {
        string nombre = "Articulo Aleatorio " + (articulosDisponibles.Count + 1);
        int id = random.Next(1000, 9999);
        decimal precio = Convert.ToDecimal(random.Next(10, 100));
        int cantidad = random.Next(1, 100);

        Articulo articulo = new Articulo(id, nombre, precio, cantidad);

        articulosDisponibles.Add(articulo);

        if (OnProductosActualizados != null)
        {
            OnProductosActualizados();
        }
    }

    public bool RetirarArticuloPorID(int id)
    {
        Articulo articulo = articulosDisponibles.Find(a => a.ID == id);
        if (articulo != null)
        {
            articulosDisponibles.Remove(articulo);
            articulosRetirados.Add(articulo);

            if (OnProductosActualizados != null)
            {
                OnProductosActualizados();
            }

            return true;
        }
        return false;
    }

    public List<Articulo> ObtenerArticulosDisponibles()
    {
        return articulosDisponibles;
    }

    public List<Articulo> ObtenerArticulosRetirados()
    {
        return articulosRetirados;
    }

    public event Action OnProductosActualizados;
}
