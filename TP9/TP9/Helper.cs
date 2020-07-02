using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Helpers
{
    static class SoporteParaConfiguracion
    {
        static public void CrearArchivoDeConfiguracion(string path, string moveTo)
        {
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path))
                {
                    byte[] data = new UTF8Encoding(true).GetBytes(moveTo);
                    fs.Write(data, 0, data.Length);
                }
                Console.WriteLine("Creado con Exito");
            }
            else
            {
                Console.WriteLine("Archivo Existente");
            }
        }
        static public string LeerConfiguracion(string path) 
        {
            using FileStream fs = File.OpenRead(path);
            using StreamReader sr = new StreamReader(fs);
            string dir;
            if((dir = sr.ReadLine()) != null)
            {
                return dir;
            }
            return "vacio";
        }
    }
    
    static class ConversorDeMorse
    {
        static Dictionary<char, string> Diccionario = new Dictionary<char, string>
        {
            {'a', ".-"},
            {'b', "-..."},
            {'c', "-.-."},
            {'d', "-.."},
            {'e', "."},
            {'f', "..-."},
            {'g', "--."},
            {'h', "...."},
            {'i', ".."},
            {'j', ".---"},
            {'k', "-.-"},
            {'l', ".-.."},
            {'m', "--"},
            {'n', "-."},
            {'o', "---"},
            {'p', ".--."},
            {'q', "--.-"},
            {'r', ".-."},
            {'s', "..."},
            {'t', "-"},
            {'u', "..-"},
            {'v', "...-"},
            {'w', ".--"},
            {'x', "-..-"},
            {'y', "-.--"},
            {'z', "--.."},
            {'0', "-----"},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {' ', "\\" },
        };
        //static public string MorseATexto(string Morse)
        //{
        //
        //}
        static public string TextoAMorse(string Texto)
        {
            string Morse="";
            foreach(char letter in Texto)
            {
                Morse.Concat(Diccionario[letter]);
            }
            return Morse;
        }
    }
}
