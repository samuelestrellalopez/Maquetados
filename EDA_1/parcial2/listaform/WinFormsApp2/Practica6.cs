using System;
using System.Collections.Generic;

namespace WinFormsApp2
{
    public class GestionPalabrasInvertidas
    {
        public List<string> InvertirPalabras(List<string> palabras)
        {
            List<string> palabrasInvertidas = new List<string>();

            foreach (string palabra in palabras)
            {
                char[] caracteres = palabra.ToCharArray();
                Array.Reverse(caracteres);
                palabrasInvertidas.Add(new string(caracteres));
            }

            return palabrasInvertidas;
        }
    }
}
