using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public delegate bool DelegateComparacion(Libro libro);
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Libro> lista = new LinkedList<Libro>();
            lista.AddLast(new Libro() { id = 1, nombre = "El Quijote", edicion = "primera" });
            lista.AddLast(new Libro() { id = 2, nombre = "Baldor", edicion = "tercera" });
            lista.AddLast(new Libro() { id = 3, nombre = "Sr Presidente", edicion = "segunda" });

            //instanciar delegado
            DelegateComparacion delegado = new DelegateComparacion(EsPrimeraEdicion);
            Console.WriteLine(delegado(lista.First()));
            DelegateComparacion delegado2 = x => x.edicion == "primera";
            DelegateComparacion delegado3 = x =>
                {
                    if (x.edicion == "Primera")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                };

            // buscar el libro que tiene como nombre Baldor
            var result = lista.Where(libro => libro.nombre == "Baldor").ToList();
            var datos = lista.Where(x => x.id == 1).ToList();

            Console.WriteLine(result.First().nombre);

            Console.ReadKey();
        }

        static bool EsPrimeraEdicion(Libro libro)
        {
            if (libro.edicion == "primera")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static Libro EsBaldor(Libro libro)
        {
            if (libro.nombre == "Baldor")
            {
                return libro;
            }
            else
            {
                return null;
            }
        }
       
    }

    public class Libro
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string edicion { get; set; }
    }
}
