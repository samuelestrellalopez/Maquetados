using System;
using System.Collections.Generic;

namespace WinFormsApp2
{
    public class ValidadorPalindromo
    {
        public bool EsPalindromo(string palabra)
        {
            // Convertimos la palabra a minúsculas y eliminamos espacios y signos de puntuación
            palabra = palabra.ToLower();
            palabra = new string(palabra.ToCharArray().Where(c => Char.IsLetter(c)).ToArray());

            List<char> caracteres = new List<char>(palabra.ToCharArray());
            List<char> caracteresInvertidos = new List<char>(caracteres);
            caracteresInvertidos.Reverse();

            return Enumerable.SequenceEqual(caracteres, caracteresInvertidos);
        }
    }
}
