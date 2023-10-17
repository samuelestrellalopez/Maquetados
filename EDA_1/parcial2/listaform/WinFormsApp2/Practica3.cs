using System;
using System.Collections.Generic;
using System.Linq;

public class Alumno
{
    private double calificacion1;
    private double calificacion2;
    private double calificacion3;

    public string Nombre { get; set; }

    public double Calificacion1
    {
        get => calificacion1;
        set
        {
            if (EsDecimalValido(value))
            {
                calificacion1 = value;
                CalcularPromedio();
            }
            else
            {
                throw new ArgumentException("Ingresa valores válidos dentro del rango de 1 al 10.");
            }
        }
    }

    public double Calificacion2
    {
        get => calificacion2;
        set
        {
            if (EsDecimalValido(value))
            {
                calificacion2 = value;
                CalcularPromedio();
            }
            else
            {
                throw new ArgumentException("Ingresa valores válidos dentro del rango de 1 al 10.");
            }
        }
    }

    public double Calificacion3
    {
        get => calificacion3;
        set
        {
            if (EsDecimalValido(value))
            {
                calificacion3 = value;
                CalcularPromedio();
            }
            else
            {
                throw new ArgumentException("Ingresa valores válidos dentro del rango de 1 al 10.");
            }
        }
    }

    public double Promedio { get; private set; }

    public Alumno(string nombre, double calificacion1, double calificacion2, double calificacion3)
    {
        Nombre = nombre;
        Calificacion1 = calificacion1;
        Calificacion2 = calificacion2;
        Calificacion3 = calificacion3;
        CalcularPromedio();
    }

    private void CalcularPromedio()
    {
        double promedioExacto = (Calificacion1 + Calificacion2 + Calificacion3) / 3;
        Promedio = Math.Round(promedioExacto, 1);
    }

    private bool EsDecimalValido(double valor)
    {
        return valor >= 1 && valor <= 10;
    }
}

public class GestorAlumnos
{
    private List<Alumno> listaAlumnos;

    public GestorAlumnos()
    {
        listaAlumnos = new List<Alumno>();
    }

    public void AgregarAlumno(Alumno alumno)
    {
        listaAlumnos.Add(alumno);
    }

    public List<Alumno> ObtenerAprobados()
    {
        return listaAlumnos.Where(alumno => alumno.Promedio >= 7).ToList();
    }

    public List<Alumno> ObtenerReprobados()
    {
        return listaAlumnos.Where(alumno => alumno.Promedio < 7).ToList();
    }
}
