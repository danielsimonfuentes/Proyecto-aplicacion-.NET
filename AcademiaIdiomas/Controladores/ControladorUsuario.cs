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
            Usuario.listaUsuarios.Clear();
            String line;
            try
            {
                StreamReader sr = new StreamReader("usuarios.txt");
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        String[] lista = line.Split(',');
                        if (lista.Length >= 9)
                        {
                            bool admin;
                            if (lista[8].Equals("True"))
                            {
                                admin = true;
                            }
                            else
                            {
                                admin = false;
                            }

                            Usuario.listaUsuarios.Add(new Usuario(lista[0], lista[1], lista[2], lista[3], lista[4], DateTime.Parse(lista[5]), lista[6], lista[7], admin));
                        }
                    }
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public static void escribirUsuarioTXT()
        {
            try
            {
                StreamWriter sw = new StreamWriter("usuarios.txt");
                foreach (var item in Usuario.listaUsuarios)
                {
                    sw.WriteLine(item.toString2());
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
