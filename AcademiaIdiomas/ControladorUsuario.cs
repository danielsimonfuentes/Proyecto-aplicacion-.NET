using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaIdiomas
{
    public class ControladorUsuario
    {
        public static void leerUsuarioTXT()
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("usuarios.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                    String[] lista;
                    lista = line.Split(',');
                    bool admin;
                    if (lista[8].Equals("true"))
                    {
                        admin = true;
                    }
                    else
                    {
                        admin = false;
                    }
                    Usuario.listaUsuarios.Add(new Usuario(lista[0], lista[1], lista[2], lista[3], lista[4], DateTime.Parse(lista[5]), lista[6], lista[7], admin));
                }
                //close the file
                sr.Close();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
