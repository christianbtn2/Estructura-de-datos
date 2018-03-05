using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab2.Models;

namespace Lab2.Data
{
    public class DataCadena
    {
        private static DataCadena instance;
        public static DataCadena Instance
        {
            get
            {
                if (instance == null) instance = new DataCadena();
                return instance;
            }
        }


        public Arbol<Cadena> arbol;

        public DataCadena()
        {
            arbol = new Arbol<Cadena>();

        }



    }
}