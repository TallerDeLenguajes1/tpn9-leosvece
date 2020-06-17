using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using helpers;

namespace tp9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  string directorio = @"\taller y lenguaje\tp9\trabajo";
             String rutaOrigen;

             Console.WriteLine("Ingrese el nombre del archivo que desea crear");
             string nombre = Console.ReadLine();
             Console.WriteLine("rellene el archivo");
             string instruccion = Console.ReadLine();
             soporteParaConf.CrearArchivoDeConfiguracion(nombre, directorio);

             if (File.Exists(directorio + @"\trabajo\" + nombre + ".dat"))
             {

                 File.WriteAllText(directorio + @"\trabajo\" + nombre + ".dat", "1010101011");
                 string texto = File.ReadAllText(directorio + @"\trabajo\\" + nombre + ".dat");
                 Console.WriteLine("contenido del archivo \n" + texto);
                 string lectura = soporteParaConf.LeerConfiguracion(nombre, directorio);
                 Console.WriteLine(lectura);
             }
             else
             {
                 Console.WriteLine("no existe la ruta del archivo {0}", directorio);
             }
             //////////////////////////////punto b///////////////
             rutaOrigen = System.Environment.CurrentDirectory;
             List<string> listadoArchivos = Directory.GetFiles(rutaOrigen).ToList();
             foreach (string archivos in listadoArchivos)
             {
                 Console.WriteLine(archivos);
                 FileInfo file = new FileInfo(archivos);
                 if ((file.Extension == ".mp3") || (file.Extension == ".txt"))
                 {
                     string nuevoDestino = directorio + file.Name;
                     File.Move(archivos, nuevoDestino);
                 }
             }
             */


            Console.WriteLine("traductor a clave morse");
            Console.WriteLine("ingrese el texto que quiere traducir");

            string texto = Console.ReadLine();
            texto = texto.ToLower();

            Console.WriteLine("su traduccion: ");
            texto = soporteParaConf.morseAtexto(texto);
            Console.WriteLine(texto);

            Console.WriteLine("traductor de clave morse");
            Console.WriteLine("ingrese el texto que quiere traducir");

            string clave = Console.ReadLine();
            
            Console.WriteLine("su traduccion: ");
            clave = soporteParaConf.textoAmorse(clave);
            Console.WriteLine(clave);




        }
    }
}

