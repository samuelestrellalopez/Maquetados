using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Producto
{
    public int Clave { get; set; }
    public string Nombre { get; set; }
    public double Precio { get; set; }

    public Producto(int clave, string nombre, double precio)
    {
        Clave = clave;
        Nombre = nombre;
        Precio = precio;
    }
}

public class GestionProductos
{
    private List<Producto> listaProductos = new List<Producto>();

    public void AgregarProducto(int clave, string nombre, double precio)
    {
        if (!EsNumeroEntero(clave))
        {
            throw new ArgumentException("Por favor, ingresa una clave válida.");
        }

        if (precio < 0)
        {
            throw new ArgumentException("El precio no puede ser negativo.");
        }

        if (listaProductos.Any(p => p.Clave == clave))
        {
            throw new ArgumentException("La clave ya está en uso.");
        }

        Producto producto = new Producto(clave, nombre, precio);
        listaProductos.Add(producto);
    }
    private bool EsNumeroEntero(double numero)
    {
        return Math.Abs(numero % 1) < double.Epsilon;
    }

    public void EliminarProducto(int clave)
    {
        if (!EsNumeroEntero(clave))
        {
            throw new ArgumentException("Por favor, ingresa una clave válida.");
        }

        Producto producto = listaProductos.Find(p => p.Clave == clave);

        if (producto != null)
        {
            listaProductos.Remove(producto);
        }
        else
        {
            throw new ArgumentException("Este producto no existe.");
        }
    }

    public List<Producto> ObtenerProductosOrdenadosPorNombre()
    {
        return listaProductos.OrderBy(p => p.Nombre).ToList();
    }

    public double CalcularCostoTotal()
    {
        return listaProductos.Sum(p => p.Precio);
    }
}



















