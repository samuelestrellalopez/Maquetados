using System;
using System.Collections.Generic;

namespace WinFormsApp2
{
    public class GestorPalabras
    {
        private Dictionary<char, List<string>> palabrasPorLetra;

        public GestorPalabras()
        {
            palabrasPorLetra = new Dictionary<char, List<string>>();
        }

        public void AgregarPalabra(string palabra)
        {
            char primeraLetra = palabra.ToLower()[0]; // Obtenemos la primera letra en minúscula
            if (!palabrasPorLetra.ContainsKey(primeraLetra))
            {
                palabrasPorLetra[primeraLetra] = new List<string>();
            }
            palabrasPorLetra[primeraLetra].Add(palabra);
        }

        public Dictionary<char, List<string>> ObtenerPalabrasPorLetra()
        {
            return palabrasPorLetra;
        }
    }
}
