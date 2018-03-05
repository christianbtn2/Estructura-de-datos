using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab2.Models;

namespace Lab2.Data
{
    public class DataPais
    {
        private static DataPais instance;
        public static DataPais Instance
        {
            get
            {
                if (instance == null) instance = new DataPais();
                return instance;
            }
        }


        public Arbol<Pais> arbol;
        
        public DataPais()
        {
            arbol = new Arbol<Pais>();
            
        }

        


    }
}
