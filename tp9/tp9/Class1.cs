using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace helpers
{
    static class soporteParaConf
    { 
        public static void CrearArchivoDeConfiguracion(string nombre, string directorio)
        {
            
            if (!(Directory.Exists(directorio + @"\trabajo")))
            {
                Directory.CreateDirectory(directorio + @"\trabajo");
            }
            if(!(File.Exists(directorio + @"\trabajo\" + nombre + ".dat")))
            {
                File.Create(directorio + @"\trabajo\" + nombre + ".dat");
            }

        }

        public static string LeerConfiguracion(string nombre, string directorio)
        {
            string nota;
            if (File.Exists(directorio + @"\trabajo\" + nombre + ".dat"))
            {
                
                string a = directorio + @"\trabajo\" + nombre + ".dat";
                FileInfo archivo = new FileInfo(a);
                nota = "nombre: " +archivo.Name + "\n";
                nota += "extencion: " + archivo.Extension + "\n";
                nota += "fecha de creacion: " + archivo.CreationTime + "\n";
                long bits = (archivo.Length / 2014);
                nota += "tamaño: " + Convert.ToString(bits);
                return nota;
            }
            else
            {
                return "no existe el archivo seleccionado";
            }            
            
        }

        static Dictionary<char, String> claveMorse = new Dictionary<char, String>()
        {
            {'a' , ".-"},
            {'b' , "-..."},
            {'c' , "-.-."},
            {'d' , "-.."},
            {'e' , "."},
            {'f' , "..-."},
            {'g' , "--."},
            {'h' , "...."},
            {'i' , ".."},
            {'j' , ".---"},
            {'k' , "-.-"},
            {'l' , ".-.."},
            {'m' , "--"},
            {'n' , "-."},
            {'o' , "---"},
            {'p' , ".--."},
            {'q' , "--.-"},
            {'r' , ".-."},
            {'s' , "..."},
            {'t' , "-"},
            {'u' , "..-"},
            {'v' , "...-"},
            {'w' , ".--"},
            {'x' , "-..-"},
            {'y' , "-.--"},
            {'z' , "--.."},
            {'0' , "-----"},
            {'1' , ".----"},
            {'2' , "..---"},
            {'3' , "...--"},
            {'4' , "....-"},
            {'5' , "....."},
            {'6' , "-...."},
            {'7' , "--..."},
            {'8' , "---.."},
            {'9' , "----."},
        };

        static Dictionary<string, char> caracteres = new Dictionary<string, char>()
        {
            {".-",'a'},
            { "-...",'b'},
            {"-.-.",'c'},
            {"-..",'d'},
            { ".",'e'},
            {"..-.", 'f' },
            {"--.",'g' },
            {"....",'h' },
            { "..",'i' },
            { ".---",'j'},
            { "-.-",'k'},
            {".-..",'l' },
            {"--",'m' },
            { "-.",'n'},
            { "---",'o'},
            { ".--.",'p'},
            {"--.-", 'q'},
            {".-.",'r'},
            {"...",'s' },
            { "-",'t'},
            {"..-",'u'},
            {"...-",'v'},
            { ".--", 'w'},
            { "-..-",'x'},
            {"-.--", 'y'},
            {"--..",'z'},
            {"-----",'0' },
            {".----",'1'},
            {"..---",'2'},
            { "...--",'3'},
            { "....-",'4'},
            {"....." ,'5'},
            {"-....",'6' },
            { "--...",'7'},
            { "---..",'8'},
            {"----.",'9'},
        };
        public static string morseAtexto(string texto)
        {
            string traduccion = null;

            foreach (char caracter in texto)
            {
                if(caracter == ' ')
                {
                    traduccion += "/";
                }
                else
                {
                    traduccion += claveMorse[caracter] + " ";
                }
            }

            return traduccion;
        }

        public static string textoAmorse(string texto)
        {
            string traduccion = null, aux = null;

            foreach (char caracter in texto)
            {
                if (caracter == '/')
                {
                    traduccion += " ";
                }
                else if(caracter != ' ')
                {
                    aux += caracter;              
                }
                else
                {
                    traduccion += caracteres[aux];
                    aux = null;
                }
                
            }
            traduccion += caracteres[aux];

            return traduccion;
        }

    }
}
