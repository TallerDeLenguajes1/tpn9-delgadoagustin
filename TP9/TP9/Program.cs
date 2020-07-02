using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Helpers;
using System.Security.Cryptography;

namespace TP9
{
	class Program
	{
		static void Main(string[] args)
		{
			string directorioDat = Directory.GetCurrentDirectory()+"\\prueba.dat";
			string moveTo = Directory.GetCurrentDirectory()+"\\movido\\";
			
			SoporteParaConfiguracion.CrearArchivoDeConfiguracion(directorioDat, moveTo);

			DirectoryInfo directorio = new DirectoryInfo(Directory.GetCurrentDirectory());
			FileInfo[] lista = directorio.GetFiles();

			
			string destino = SoporteParaConfiguracion.LeerConfiguracion(directorioDat);
			foreach (FileInfo file in lista)
            {
				string[] arreglo = file.Name.Split(".");
                if(string.Equals(arreglo.Last(),"mp3") || string.Equals(arreglo.Last(),"txt"))
                {
                    if (!Directory.Exists(destino))
                    {
						Directory.CreateDirectory(destino);
                    }
					file.MoveTo(destino+file.Name);
                    Console.WriteLine("Movido");
                }
                else
                {
                    Console.WriteLine("No Movido");
                }
            }
		}
	}
}
