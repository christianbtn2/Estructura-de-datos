using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab2.Models;

namespace Lab2.Data
{
    public class DataEnteros
    {
        private static DataEnteros instance;
        public static DataEnteros Instance
        {
            get
            {
                if (instance == null) instance = new DataEnteros();
                return instance;
            }
        }


        public Arbol<Enteros> arbol;

        public DataEnteros()
        {
            arbol = new Arbol<Enteros>();

        }

    }
}